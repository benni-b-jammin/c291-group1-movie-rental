using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MovieRentalApp
{
    // Connect to database.
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
                MessageBox.Show("Select an actor first.");
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
                MessageBox.Show("That actor is already in the movie.");
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
                MessageBox.Show("Select an actor from the list first.");
            }
        }
        
        private void btnCreateMovie_Click(object sender, EventArgs e)
        {
            string movieName = txtCreateMovieName.Text.Trim();
            //... movieType = lstCreateMovieType ...
            float distFee = int.Parse(txtCreateDistFee.Text.Trim()); //not saved as int, is saved as numeric(6,2) in db
            int numCopies = int.Parse(txtCreateNumCopies.Text.Trim()); //**int
            // from lstCreateActors.Items, create a list of actors to add to the movie/relate to the movie in the database; and add them

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
