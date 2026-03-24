using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MovieRentalApp
{
    public partial class DashboardForm : Form
    {
        private SqlConnection myConnection;
        private string currentUser;

        public DashboardForm(SqlConnection connection, string username)
        {
            InitializeComponent();

            myConnection = connection;
            currentUser = username;

            lblPlaceholder.Text = "Logged in as: " + currentUser;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (myConnection != null && myConnection.State == ConnectionState.Open)
            {
                myConnection.Close();
            }

            Application.Exit();
        }

        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (myConnection != null && myConnection.State == ConnectionState.Open)
            {
                myConnection.Close();
            }

            Application.Exit();
        }

        private void lblPlaceholder_Click(object sender, EventArgs e)
        {

        }
    }
}