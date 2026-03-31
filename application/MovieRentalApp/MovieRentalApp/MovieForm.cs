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
        // string firstName = txtCreateFirstName.Text.Trim(); EG
        private void btnRemoveActor_Click(object sender, EventArgs e)
        {
            // can user just delete manually from the listbox..? Can I have the user click actor and add them to the listbox?
        }
        private void btnAddActor_Click(object sender, EventArgs e)
        {
            // add actor to listbox to later be related to the movie (appearedin relation)
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
        private void btnMovieDetails_Click(object sender, EventArgs e)
        {
        }
        private void btnSearchMovie_Click(object sender, EventArgs e)
        {
            // Use FName and LName to search for actors; when search is clicked we show results.
            //string txtCreateActorFN = txtCreateActorFN.Text.Trim();
            //string txtCreateActorLN = txtCreateMovieName.Text.Trim();
        }

        private void txtCreateMovieName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstCreateMovieType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
