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
            try
            {
                string query = @"
                    UPDATE Customer
                    SET MovieName = @movieName,
                        MovieType = @movieType,
                        DistFee = @distFee,
                        NumOfCopies = @numOfCopies
                        
                    WHERE MovieID = @movieID;";

                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    cmd.Parameters.Add("@firstName", SqlDbType.VarChar, 40).Value = txtFirstName.Text.Trim();
                    cmd.Parameters.Add("@lastName", SqlDbType.VarChar, 40).Value = txtLastName.Text.Trim();
                    cmd.Parameters.Add("@address", SqlDbType.VarChar, 40).Value = txtAddress.Text.Trim();
                    cmd.Parameters.Add("@city", SqlDbType.VarChar, 40).Value = txtCity.Text.Trim();
                    cmd.Parameters.Add("@state", SqlDbType.NChar, 2).Value = txtState.Text.Trim();
                    cmd.Parameters.Add("@zip", SqlDbType.NChar, 6).Value = txtZip.Text.Trim();
                    cmd.Parameters.Add("@email", SqlDbType.VarChar, 40).Value = txtEmail.Text.Trim();
                    cmd.Parameters.Add("@accountNum", SqlDbType.Int).Value = Convert.ToInt32(txtAccountNum.Text.Trim());
                    cmd.Parameters.Add("@cardNum", SqlDbType.NChar, 16).Value = txtCardNum.Text.Trim();
                    cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = customerId;

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Customer updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Update Error");
            }

        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {

        }
    }
}