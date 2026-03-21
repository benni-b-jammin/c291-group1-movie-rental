using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MovieRentalApp
{
    public partial class LoginForm : Form
    {
        private SqlConnection myConnection;

        public LoginForm()
        {
            InitializeComponent();

            this.AcceptButton = btnLogin;

            myConnection = new SqlConnection(
                "user id=superuser;" +
                "password=dbaccess;" +
                "server=localhost;" +
                "database=RentalDB;" +
                "connection timeout=30"
            );

            try
            {
                myConnection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Database Connection Error");
                this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter both username and password.", "Login Failed");
                return;
            }

            try
            {
                string query = @"
                    SELECT COUNT(*)
                    FROM Employee
                    WHERE Username = @username
                      AND PasswordHash = HASHBYTES('SHA2_256', @password);";

                using (SqlCommand loginCommand = new SqlCommand(query, myConnection))
                {
                    loginCommand.Parameters.Add("@username", SqlDbType.VarChar, 40).Value = username;
                    loginCommand.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = password;

                    int count = Convert.ToInt32(loginCommand.ExecuteScalar());

                    if (count > 0)
                    {
                        DashboardForm dashboard = new DashboardForm(myConnection, username);
                        dashboard.FormClosed += Dashboard_FormClosed;
                        dashboard.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Login Failed");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Login Error");
            }
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (myConnection != null && myConnection.State == ConnectionState.Open)
            {
                myConnection.Close();
            }

            this.Close();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (myConnection != null && myConnection.State == ConnectionState.Open)
            {
                myConnection.Close();
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
        }
    }
}