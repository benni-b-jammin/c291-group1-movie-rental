using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace MovieRentalApp
{
    public partial class DashboardForm : Form
    {
        private SqlConnection myConnection;
        private string currentUser;
        private Form loginForm;
        private bool isLoggingOut = false;

        public DashboardForm(SqlConnection connection, string username, Form previousLoginForm)
        {
            InitializeComponent();

            myConnection = connection;
            currentUser = username;
            loginForm = previousLoginForm;

            lblPlaceholder.Text = "Logged in as: " + currentUser;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            isLoggingOut = true;

            if (loginForm != null)
            {
                loginForm.Show();
            }
            this.Close();
        }

        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isLoggingOut)
            {
                if (myConnection != null && myConnection.State == ConnectionState.Open)
                {
                    myConnection.Close();
                }

                Application.Exit();
            }
        }

        private void btnCustomerScreen_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm(myConnection);
            customerForm.Show();
        }

        private void btnRentalScreen_Click(object sender, EventArgs e)
        {
            RentalForm rentalForm = new RentalForm(myConnection);
            rentalForm.Show();

        }

        private void lblPlaceholder_Click(object sender, EventArgs e)
        {
        }
    }
}
