using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

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
        private void CreateMovie_Click(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void lstCreateMovieType_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void MovieForm_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblSearchMovieName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblCreateSFeaturedActors_Click(object sender, EventArgs e)
        {

        }
    }




}
