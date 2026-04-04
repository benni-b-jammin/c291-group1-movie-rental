using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class MovieForm : Form
    {
        private SqlConnection myConnection;
        public MovieForm(SqlConnection connection)
        {
            InitializeComponent();
            myConnection = connection;
        }

        // Button interactivity:
        // Create Movie Screen
        private void btnSearchActor_Click(object sender, EventArgs e)
        {
            string actorFN = txtCreateActorFN.Text.Trim();
            string actorLN = txtCreateActorLN.Text.Trim();

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

            string actorId = Convert.ToString(dgvCreateActors.CurrentRow.Cells["ActorID"].Value); 
            string actorName = Convert.ToString(dgvCreateActors.CurrentRow.Cells["ActorName"].Value);

            if (!lstCreateActors.Items.Contains(actorName + " (" + actorId + ")"))
            {
                lstCreateActors.Items.Add(actorName + " (" + actorId + ")");
            }
            else
            {
                MessageBox.Show("The selected actor is already in the movie.");
            }
        }

        private void btnRemoveActor_Click(object sender, EventArgs e)
        {
            if (lstCreateActors.SelectedItem != null)
            {
                lstCreateActors.Items.Remove(lstCreateActors.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select an actor from the list.");
            }
        }

        private void btnCreateMovie_Click(object sender, EventArgs e)
        {

            // Ensure all necessary information is provided.
            if (txtCreateMovieName.Text.Trim() == "" ||
                cbCreateMovieType.SelectedIndex == -1 ||
                txtCreateDistFee.Text.Trim() == "" ||
                decimal.Parse(txtCreateDistFee.Text.Trim()) <= 0 ||
                txtCreateNumCopies.Text.Trim() == "" ||
                int.Parse(txtCreateNumCopies.Text.Trim()) <= 0)
            {

                MessageBox.Show("Please fill in all required fields.\nNumber of copies and distribution fee must be greater than 0.");
                return;
            }

            string movieName = txtCreateMovieName.Text.Trim();
            string movieType = (cbCreateMovieType.SelectedItem).ToString();
            decimal distFee = decimal.Parse(txtCreateDistFee.Text.Trim()); //numeric(6,2 aka ####.##) in db
            int numCopies = int.Parse(txtCreateNumCopies.Text.Trim());

            //string input = txtCreateDistFee.Text.Trim();

            //if (!decimal.TryParse(input, out decimal distFee))
            //{
            //    MessageBox.Show("Please enter a valid distribution fee.");
            //    return;
            //}

            SqlTransaction transaction = null;

            // Add the movie to the DB.
            try
            {
                transaction = myConnection.BeginTransaction();

                string insertCustomerQuery = @"
                    INSERT INTO Movie
                    (
                        MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented
                    )
                    VALUES
                    (
                        NEXT VALUE FOR MovieIDSeq, @movieName, @movieType, @distFee, @numCopies, 0
                    );";

                using (SqlCommand cmd = new SqlCommand(insertCustomerQuery, myConnection, transaction))
                {
                    cmd.Parameters.Add("@movieName", SqlDbType.VarChar, 40).Value = movieName;
                    cmd.Parameters.Add("@movieType", SqlDbType.VarChar, 10).Value = movieType;

                    var distFeeParam = cmd.Parameters.Add("@distFee", SqlDbType.Decimal);
                    distFeeParam.Precision = 6;
                    distFeeParam.Scale = 2;
                    distFeeParam.Value = distFee;

                    cmd.Parameters.Add("@numCopies", SqlDbType.Int).Value = numCopies;
                    cmd.ExecuteNonQuery();
                }

                // Get the MovieID to insert relation into AppearedIn. Very limited search in case of multiple movies with the same name.
                int movieID;
                string getMovieIDQuery = @"
                    SELECT MovieID
                    FROM Movie
                    WHERE MovieName = @movieName
                    AND MovieType = @movieType
                    AND DistFee = @distFee
                    AND NumOfCopies = @numCopies;";

                using (SqlCommand cmd = new SqlCommand(getMovieIDQuery, myConnection, transaction))
                {
                    cmd.Parameters.Add("@movieName", SqlDbType.VarChar, 40).Value = movieName;
                    cmd.Parameters.Add("@movieType", SqlDbType.VarChar, 10).Value = movieType;

                    var distFeeParam = cmd.Parameters.Add("@distFee", SqlDbType.Decimal);
                    distFeeParam.Precision = 6;
                    distFeeParam.Scale = 2;
                    distFeeParam.Value = distFee;

                    cmd.Parameters.Add("@numCopies", SqlDbType.Int).Value = numCopies;
                    movieID = Convert.ToInt32(cmd.ExecuteScalar());
                }

                // from lstCreateActors.Items, create a list of actors to add to the movie/relate to the movie in the database; and add them
                foreach (var item in lstCreateActors.Items)
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

                transaction.Commit();
                MessageBox.Show("Movie created successfully.");
                ClearCreateFields();
                }

                catch (Exception ex)
                {
                if (transaction != null)
                    transaction.Rollback();

                MessageBox.Show(ex.ToString(), "Create Movie Error");
                }
               }
        private void ClearCreateFields()
        {
            txtCreateMovieName.Clear();
            txtCreateDistFee.Clear();
            txtCreateNumCopies.Clear();
            txtCreateActorFN.Clear();
            txtCreateActorLN.Clear();
            lstCreateActors.Items.Clear();
            dgvCreateActors.DataSource = null;
            cbCreateMovieType.SelectedIndex = -1;
        }

        // Search Movie Screen

        private void btnSearchMovie_Click(object sender, EventArgs e)
        {
            string movieName = txtSearchMovie.Text.Trim();
            if (movieName.Length < 2)
            {
                MessageBox.Show("Enter at least 2 characters of the movie's name.");
                return;
            }

            try
            {
                string query = @"
                    SELECT MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented
                    FROM Movie
                    WHERE (MovieName LIKE @movieNameLike)
                    ORDER BY MovieName;";

                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    cmd.Parameters.Add("@movieName", SqlDbType.VarChar, 40).Value = movieName;
                    cmd.Parameters.Add("@movieNameLike", SqlDbType.VarChar, 50).Value = movieName + "%";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvSearchMovie.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Search Error");
            }
        }

        private void btnMovieDetails_Click(object sender, EventArgs e)
        {
        }
        

        private void txtCreateMovieName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
