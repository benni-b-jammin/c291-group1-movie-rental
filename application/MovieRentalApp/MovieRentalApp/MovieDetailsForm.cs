using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Text;
using System.Transactions;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace MovieRentalApp
{
    public partial class MovieDetailsForm : Form
    {
        private SqlConnection myConnection;
        int movieID;
        public MovieDetailsForm(SqlConnection connection, int selectedMovieID)
        {
            InitializeComponent();
            myConnection = connection;
            movieID = selectedMovieID;
            LoadMovieDetails();
            LoadActorDetails();
        }

        private void LoadMovieDetails()
        {
            try
            {
                string query = @"
                    SELECT MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented
                    FROM Movie
                    WHERE MovieID = @movieID;";

                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    cmd.Parameters.Add("@movieID", SqlDbType.Int).Value = movieID;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtMovieName.Text = reader["MovieName"].ToString();
                            txtDistFee.Text = reader["DistFee"].ToString();
                            txtNumCopies.Text = reader["NumOfCopies"].ToString();
                            cbMovieType.SelectedItem = reader["MovieType"].ToString();
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Load Movie Error");
            }
        }

        private void LoadActorDetails()
        {
            List<string> actors = new List<string>();
            try
            {
                string query = @"
                    SELECT ActorID
                    FROM AppearedIn
                    WHERE MovieID = @movieID;";

                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    cmd.Parameters.Add("@movieID", SqlDbType.Int).Value = movieID;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            actors.Add(reader["ActorID"].ToString().Trim());
                        }
                    }
                }

                foreach (string actorID in actors)
                {
                    string actorQuery = @"
                        SELECT ActorName
                        FROM Actor
                        WHERE ActorID = @actorID;";

                    using (SqlCommand actorCmd = new SqlCommand(actorQuery, myConnection))
                    {
                        actorCmd.Parameters.Add("@actorID", SqlDbType.Int).Value = Convert.ToInt32(actorID);

                        using (SqlDataReader actorReader = actorCmd.ExecuteReader())
                        {
                            if (actorReader.Read())
                            {
                                lstActors.Items.Add((actorReader["ActorName"].ToString().Trim()) + " (" + actorID + ")");
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Load Actors Error");
            }
        }

        private void btnSearchActor_Click(object sender, EventArgs e)
        {
            string actorFN = txtActorFN.Text.Trim();
            string actorLN = txtActorLN.Text.Trim();

            if (actorFN.Length < 2 && actorLN.Length < 2)
            {
                MessageBox.Show("Enter at least 2 characters in first or last name.");
                return;
            }

            try
            {
                string query = @"
                    SELECT ActorID, ActorName, Gender, DoB
                    FROM Actor
                    WHERE (@actorFN = '' OR ActorName LIKE @actorFNLike)
                    AND (@actorLN = '' OR ActorName LIKE @actorLNLike)
                    ORDER BY ActorName;";

                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    cmd.Parameters.Add("@actorFN", SqlDbType.VarChar, 40).Value = actorFN;
                    cmd.Parameters.Add("@actorLN", SqlDbType.VarChar, 40).Value = actorLN;
                    cmd.Parameters.Add("@actorFNLike", SqlDbType.VarChar, 50).Value = actorFN + "%";
                    cmd.Parameters.Add("@actorLNLike", SqlDbType.VarChar, 50).Value = "%" + actorLN + "%";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvCreateActors.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Search Error");
            }
        }

        private void btnAddActor_Click(object sender, EventArgs e)
        {
            if (dgvCreateActors.CurrentRow == null)
            {
                MessageBox.Show("Please select an actor.");
                return;
            }

            string actorID = Convert.ToString(dgvCreateActors.CurrentRow.Cells["ActorID"].Value);
            string actorName = Convert.ToString(dgvCreateActors.CurrentRow.Cells["ActorName"].Value);

            if (!lstActors.Items.Contains(actorName + " (" + actorID + ")"))
            {
                lstActors.Items.Add(actorName + " (" + actorID + ")");
            }
            else
            {
                MessageBox.Show("The selected actor is already in the movie.");
            }
        }

        private void btnRemoveActor_Click(object sender, EventArgs e)
        {
            if (lstActors.SelectedItem != null)
            {
                lstActors.Items.Remove(lstActors.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select an actor from the list.");
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            // Ensure all necessary information is still provided.
            if (txtMovieName.Text.Trim() == "" ||
                cbMovieType.SelectedIndex == -1 ||
                txtDistFee.Text.Trim() == "" ||
                decimal.Parse(txtDistFee.Text.Trim()) <= 0 ||
                txtNumCopies.Text.Trim() == "" ||
                int.Parse(txtNumCopies.Text.Trim()) <= 0)
            {
                MessageBox.Show("Please fill in all required fields.\nNumber of copies and distribution fee must be greater than 0.");
                return;
            }

            if (decimal.Parse(txtDistFee.Text.Trim()) >= 9999.99m) 
            {
                MessageBox.Show("Please enter a valid distribution fee.");
                return;
            }

            int copiesRented = GetCopiesRented();
            if (copiesRented > int.Parse(txtNumCopies.Text.Trim()))
            {
                MessageBox.Show("There are currently " + copiesRented + " copies of this movie rented by customers.\nPlease adjust the number of copies.");
                return;
            }

            // Update the movie details.
            SqlTransaction transaction = null;
            try
            {
                transaction = myConnection.BeginTransaction();
                string query = @"
                    UPDATE Movie
                    SET MovieName = @movieName,
                        MovieType = @movieType,
                        DistFee = @distFee,
                        NumOfCopies = @numOfCopies
                    WHERE MovieID = @movieID;";

                using (SqlCommand cmd = new SqlCommand(query, myConnection, transaction))
                {
                    cmd.Parameters.Add("@movieName", SqlDbType.VarChar, 40).Value = txtMovieName.Text.Trim();
                    cmd.Parameters.Add("@movieType", SqlDbType.VarChar, 40).Value = (cbMovieType.SelectedItem).ToString();

                    var distFeeParam = cmd.Parameters.Add("@distFee", SqlDbType.Decimal);
                    distFeeParam.Precision = 6;
                    distFeeParam.Scale = 2;
                    distFeeParam.Value = Math.Round(decimal.Parse(txtDistFee.Text.Trim()), 2);

                    cmd.Parameters.Add("@numOfCopies", SqlDbType.VarChar, 40).Value = int.Parse(txtNumCopies.Text.Trim());
                    cmd.Parameters.Add("@movieID", SqlDbType.Int).Value = movieID;
                    cmd.ExecuteNonQuery();
                }

                using (SqlCommand cmd = new SqlCommand("DELETE FROM AppearedIn WHERE MovieID = @movieID", myConnection, transaction))
                {
                    cmd.Parameters.Add("@movieID", SqlDbType.Int).Value = movieID;
                    cmd.ExecuteNonQuery();
                }

                if (lstActors.Items.Count != 0)
                {
                    // Update the related actors in AppearedIn.
                    foreach (var item in lstActors.Items)
                    {
                        string actorInfo = item.ToString();
                        int start = actorInfo.IndexOf('(') + 1;
                        int end = actorInfo.IndexOf(')');
                        int actorID = int.Parse(actorInfo.Substring(start, end - start));

                        string insertAppearedIn = @"
                        INSERT INTO AppearedIn (MovieID, ActorID)
                        VALUES (@movieID, @actorID);";

                        using (SqlCommand cmd = new SqlCommand(insertAppearedIn, myConnection, transaction))
                        {
                            cmd.Parameters.Add("@movieID", SqlDbType.Int).Value = movieID;
                            cmd.Parameters.Add("@actorID", SqlDbType.Int).Value = actorID;
                            cmd.ExecuteNonQuery();
                        }
                    }
                    
                }
                transaction.Commit();
                MessageBox.Show("Movie updated successfully.");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Update Error");
            }
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            int copiesRented = GetCopiesRented();
            if (copiesRented != 0)
            {
                MessageBox.Show("Cannot delete movie while copies are currently rented out.\nPlease try again later.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this movie?",
                "Confirm Delete",
                MessageBoxButtons.YesNo
            );

            if (result != DialogResult.Yes)
                return;

            SqlTransaction transaction = null;
            try
            {
                transaction = myConnection.BeginTransaction();

                using (SqlCommand cmd1 = new SqlCommand(
                    "DELETE FROM QueueUp WHERE MovieID = @movieID;", myConnection, transaction))
                {
                    cmd1.Parameters.Add("@movieID", SqlDbType.Int).Value = movieID;
                    cmd1.ExecuteNonQuery();
                }

                using (SqlCommand cmd2 = new SqlCommand(
                    "DELETE FROM AppearedIn WHERE MovieID = @movieID;", myConnection, transaction))
                {
                    cmd2.Parameters.Add("@movieID", SqlDbType.Int).Value = movieID;
                    cmd2.ExecuteNonQuery();
                }

                using (SqlCommand cmd3 = new SqlCommand(
                    "DELETE FROM Movie WHERE MovieID = @movieID;", myConnection, transaction))
                {
                    cmd3.Parameters.Add("@movieID", SqlDbType.Int).Value = movieID;
                    cmd3.ExecuteNonQuery();
                }

                transaction.Commit();
                MessageBox.Show("Movie deleted successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                if (transaction != null)
                    transaction.Rollback();

                MessageBox.Show(ex.ToString(), "Delete Error");
            }
        }

        private int GetCopiesRented() 
        {
            string getMovieIDQuery = @"
                    SELECT CopiesRented
                    FROM Movie
                    WHERE MovieID = @movieID";

            using (SqlCommand cmd = new SqlCommand(getMovieIDQuery, myConnection))
            {
                cmd.Parameters.Add("@movieID", SqlDbType.Int).Value = movieID;
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

    }
}
