using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MovieRentalApp
{
    public partial class CustomerDetailsForm : Form
    {
        private SqlConnection myConnection;
        private int customerId;

        public CustomerDetailsForm(SqlConnection connection, int selectedCustomerId)
        {
            InitializeComponent();
            myConnection = connection;
            customerId = selectedCustomerId;
            LoadCustomerDetails();
            LoadCustomerPhones();
        }

        private void LoadCustomerDetails()
        {
            try
            {
                string query = @"
                    SELECT CustomerID, FirstName, LastName, Address, City, State,
                           ZipCode, Email, AccountNum, CardNum
                    FROM Customer
                    WHERE CustomerID = @customerId;";

                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = customerId;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtCustomerID.Text = reader["CustomerID"].ToString();
                            txtFirstName.Text = reader["FirstName"].ToString();
                            txtLastName.Text = reader["LastName"].ToString();
                            txtAddress.Text = reader["Address"].ToString();
                            txtCity.Text = reader["City"].ToString();
                            txtState.Text = reader["State"].ToString();
                            txtZip.Text = reader["ZipCode"].ToString();
                            txtEmail.Text = reader["Email"].ToString();
                            txtAccountNum.Text = reader["AccountNum"].ToString();
                            txtCardNum.Text = reader["CardNum"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Load Customer Error");
            }
        }

        private void LoadCustomerPhones()
        {
            lstPhones.Items.Clear();

            try
            {
                string query = @"
                    SELECT PhoneNum
                    FROM CustomerPhone
                    WHERE CustomerID = @customerId;";

                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = customerId;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lstPhones.Items.Add(reader["PhoneNum"].ToString().Trim());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Load Phones Error");
            }
        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            string phone = txtPhone.Text.Trim();

            if (phone == "")
            {
                MessageBox.Show("Enter a phone number first.");
                return;
            }

            try
            {
                string query = @"
                    INSERT INTO CustomerPhone (CustomerID, PhoneNum)
                    VALUES (@customerId, @phoneNum);";

                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = customerId;
                    cmd.Parameters.Add("@phoneNum", SqlDbType.NChar, 10).Value = phone;
                    cmd.ExecuteNonQuery();
                }

                txtPhone.Clear();
                LoadCustomerPhones();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Add Phone Error");
            }
        }

        private void btnRemovePhone_Click(object sender, EventArgs e)
        {
            if (lstPhones.SelectedItem == null)
            {
                MessageBox.Show("Select a phone number first.");
                return;
            }

            try
            {
                string query = @"
                    DELETE FROM CustomerPhone
                    WHERE CustomerID = @customerId
                      AND PhoneNum = @phoneNum;";

                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = customerId;
                    cmd.Parameters.Add("@phoneNum", SqlDbType.NChar, 10).Value = lstPhones.SelectedItem.ToString();
                    cmd.ExecuteNonQuery();
                }

                LoadCustomerPhones();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Remove Phone Error");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"
                    UPDATE Customer
                    SET FirstName = @firstName,
                        LastName = @lastName,
                        Address = @address,
                        City = @city,
                        State = @state,
                        ZipCode = @zip,
                        Email = @email,
                        AccountNum = @accountNum,
                        CardNum = @cardNum
                    WHERE CustomerID = @customerId;";

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this customer?",
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
                    "DELETE FROM CustomerPhone WHERE CustomerID = @customerId;", myConnection, transaction))
                {
                    cmd1.Parameters.Add("@customerId", SqlDbType.Int).Value = customerId;
                    cmd1.ExecuteNonQuery();
                }

                using (SqlCommand cmd2 = new SqlCommand(
                    "DELETE FROM QueueUp WHERE CustomerID = @customerId;", myConnection, transaction))
                {
                    cmd2.Parameters.Add("@customerId", SqlDbType.Int).Value = customerId;
                    cmd2.ExecuteNonQuery();
                }

                using (SqlCommand cmd3 = new SqlCommand(
                    "DELETE FROM Customer WHERE CustomerID = @customerId;", myConnection, transaction))
                {
                    cmd3.Parameters.Add("@customerId", SqlDbType.Int).Value = customerId;
                    cmd3.ExecuteNonQuery();
                }

                transaction.Commit();
                MessageBox.Show("Customer deleted successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                if (transaction != null)
                    transaction.Rollback();

                MessageBox.Show(ex.ToString(), "Delete Error");
            }
        }
    }
}