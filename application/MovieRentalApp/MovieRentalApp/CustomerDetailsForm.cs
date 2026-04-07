using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Text.RegularExpressions;
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

            if (!IsValidPhone(phone))
            {
                MessageBox.Show("Phone number must be exactly 10 digits.");
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
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string address = txtAddress.Text.Trim();
            string city = txtCity.Text.Trim();
            string state = txtState.Text.Trim().ToUpper();
            string zip = txtZip.Text.Trim().ToUpper();
            string email = txtEmail.Text.Trim();
            string cardNum = txtCardNum.Text.Trim();

            int accountNum;
            if (!int.TryParse(txtAccountNum.Text.Trim(), out accountNum))
            {
                MessageBox.Show("Account number must be an integer.");
                return;
            }

            if (firstName == "" || lastName == "" || address == "" || city == "" ||
                state == "" || zip == "" || email == "" || cardNum == "")
            {
                MessageBox.Show("Please fill in all customer fields.");
                return;
            }

            if (!IsValidName(firstName))
            {
                MessageBox.Show("First name contains invalid characters.");
                return;
            }

            if (!IsValidName(lastName))
            {
                MessageBox.Show("Last name contains invalid characters.");
                return;
            }

            if (!IsValidState(state))
            {
                MessageBox.Show("State must be exactly 2 letters.");
                return;
            }

            if (!IsValidZip(zip))
            {
                MessageBox.Show("Zip code must be exactly 6 letters/numbers.");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Enter a valid email address.");
                return;
            }

            if (accountNum <= 0)
            {
                MessageBox.Show("Account number must be a positive integer.");
                return;
            }

            if (!IsValidCardNumber(cardNum))
            {
                MessageBox.Show("Card number must be exactly 16 digits.");
                return;
            }

            if (lstPhones.Items.Count == 0)
            {
                MessageBox.Show("Customer must have at least one phone number.");
                return;
            }

            try
            {
                string checkEmailQuery = @"
                    SELECT COUNT(*)
                    FROM Customer
                    WHERE Email = @email
                      AND CustomerID <> @customerId;";

                using (SqlCommand checkCmd = new SqlCommand(checkEmailQuery, myConnection))
                {
                    checkCmd.Parameters.Add("@email", SqlDbType.VarChar, 40).Value = email;
                    checkCmd.Parameters.Add("@customerId", SqlDbType.Int).Value = customerId;

                    int existingCount = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (existingCount > 0)
                    {
                        MessageBox.Show("Another customer with that email already exists.");
                        return;
                    }
                }

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
                    cmd.Parameters.Add("@firstName", SqlDbType.VarChar, 40).Value = firstName;
                    cmd.Parameters.Add("@lastName", SqlDbType.VarChar, 40).Value = lastName;
                    cmd.Parameters.Add("@address", SqlDbType.VarChar, 40).Value = address;
                    cmd.Parameters.Add("@city", SqlDbType.VarChar, 40).Value = city;
                    cmd.Parameters.Add("@state", SqlDbType.NChar, 2).Value = state;
                    cmd.Parameters.Add("@zip", SqlDbType.NChar, 6).Value = zip;
                    cmd.Parameters.Add("@email", SqlDbType.VarChar, 40).Value = email;
                    cmd.Parameters.Add("@accountNum", SqlDbType.Int).Value = accountNum;
                    cmd.Parameters.Add("@cardNum", SqlDbType.NChar, 16).Value = cardNum;
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

        private bool IsValidPhone(string phone)
        {
            return Regex.IsMatch(phone, @"^\d{10}$");
        }

        private bool IsValidCardNumber(string cardNumber)
        {
            return Regex.IsMatch(cardNumber, @"^\d{16}$");
        }

        private bool IsValidState(string state)
        {
            return Regex.IsMatch(state, @"^[A-Za-z]{2}$");
        }

        private bool IsValidZip(string zip)
        {
            return Regex.IsMatch(zip, @"^[A-Za-z0-9]{6}$");
        }

        private bool IsValidName(string name)
        {
            return Regex.IsMatch(name, @"^[A-Za-z\s'\-]+$");
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                MailAddress addr = new MailAddress(email);
                return addr.Address == email && email.Contains("@");
            }
            catch
            {
                return false;
            }
        }
    }
}