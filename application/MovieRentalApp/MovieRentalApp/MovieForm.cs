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


        private void MovieForm_Load(object sender, EventArgs e)
        {
        }

        private void btnSearchMovie_Click(object sender, EventArgs e)
        {

        }
        private void btnMovieDetails_Click(object sender, EventArgs e)
        {

        }

    }




}
