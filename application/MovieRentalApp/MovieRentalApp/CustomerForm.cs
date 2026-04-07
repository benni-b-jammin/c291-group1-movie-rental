using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MovieRentalApp
{
    public partial class CustomerForm : Form
    {
        private SqlConnection myConnection;

        public CustomerForm(SqlConnection connection)
        {
            InitializeComponent();
            myConnection = connection;
        }

        private void btnAddPhoneCreate_Click(object sender, EventArgs e)
        {
            string phone = txtCreatePhone.Text.Trim();

            if (!IsValidPhone(phone))
            {
                MessageBox.Show("Phone number must be exactly 10 digits.");
                return;
            }

            if (!lstCreatePhones.Items.Contains(phone))
            {
                lstCreatePhones.Items.Add(phone);
                txtCreatePhone.Clear();
            }
            else
            {
                MessageBox.Show("That phone number is already in the list.");
            }
        }

        private void btnRemovePhoneCreate_Click(object sender, EventArgs e)
        {
            if (lstCreatePhones.SelectedItem != null)
            {
                lstCreatePhones.Items.Remove(lstCreatePhones.SelectedItem);
            }
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            string firstName = txtCreateFirstName.Text.Trim();
            string lastName = txtCreateLastName.Text.Trim();
            string address = txtCreateAddress.Text.Trim();
            string city = txtCreateCity.Text.Trim();
            string state = txtCreateState.Text.Trim().ToUpper();
            string zip = txtCreateZip.Text.Trim().ToUpper();
            string email = txtCreateEmail.Text.Trim();
            string cardNum = txtCreateCardNum.Text.Trim();

            int accountNum;
            if (!int.TryParse(txtCreateAccountNum.Text.Trim(), out accountNum))
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

            if (lstCreatePhones.Items.Count == 0)
            {
                MessageBox.Show("Add at least one phone number.");
                return;
            }

            try
            {
                string checkEmailQuery = "SELECT COUNT(*) FROM Customer WHERE Email = @email;";

                using (SqlCommand cmd = new SqlCommand(checkEmailQuery, myConnection))
                {
                    cmd.Parameters.Add("@email", SqlDbType.VarChar, 40).Value = email;

                    int existingCount = Convert.ToInt32(cmd.ExecuteScalar());
                    if (existingCount > 0)
                    {
                        MessageBox.Show("A customer with that email already exists.");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Validation Error");
                return;
            }

            SqlTransaction transaction = null;

            try
            {
                transaction = myConnection.BeginTransaction();

                string insertCustomerQuery = @"
                    INSERT INTO Customer
                    (
                        CustomerID, LastName, FirstName, Address, City, State, ZipCode,
                        Email, AccountNum, CardNum
                    )
                    VALUES
                    (
                        NEXT VALUE FOR CustomerIDSeq, @lastName, @firstName, @address, @city,
                        @state, @zip, @email, @accountNum, @cardNum
                    );";

                using (SqlCommand cmd = new SqlCommand(insertCustomerQuery, myConnection, transaction))
                {
                    cmd.Parameters.Add("@lastName", SqlDbType.VarChar, 40).Value = lastName;
                    cmd.Parameters.Add("@firstName", SqlDbType.VarChar, 40).Value = firstName;
                    cmd.Parameters.Add("@address", SqlDbType.VarChar, 40).Value = address;
                    cmd.Parameters.Add("@city", SqlDbType.VarChar, 40).Value = city;
                    cmd.Parameters.Add("@state", SqlDbType.NChar, 2).Value = state;
                    cmd.Parameters.Add("@zip", SqlDbType.NChar, 6).Value = zip;
                    cmd.Parameters.Add("@email", SqlDbType.VarChar, 40).Value = email;
                    cmd.Parameters.Add("@accountNum", SqlDbType.Int).Value = accountNum;
                    cmd.Parameters.Add("@cardNum", SqlDbType.NChar, 16).Value = cardNum;
                    cmd.ExecuteNonQuery();
                }

                int customerId;
                string getCustomerIdQuery = @"
                    SELECT CustomerID
                    FROM Customer
                    WHERE Email = @email;";

                using (SqlCommand cmd = new SqlCommand(getCustomerIdQuery, myConnection, transaction))
                {
                    cmd.Parameters.Add("@email", SqlDbType.VarChar, 40).Value = email;
                    customerId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                foreach (var item in lstCreatePhones.Items)
                {
                    string phone = item.ToString();

                    string insertPhoneQuery = @"
                        INSERT INTO CustomerPhone (CustomerID, PhoneNum)
                        VALUES (@customerId, @phoneNum);";

                    using (SqlCommand cmd = new SqlCommand(insertPhoneQuery, myConnection, transaction))
                    {
                        cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = customerId;
                        cmd.Parameters.Add("@phoneNum", SqlDbType.NChar, 10).Value = phone;
                        cmd.ExecuteNonQuery();
                    }
                }

                transaction.Commit();
                MessageBox.Show("Customer created successfully.");
                ClearCreateFields();
            }
            catch (Exception ex)
            {
                if (transaction != null)
                    transaction.Rollback();

                MessageBox.Show(ex.ToString(), "Create Customer Error");
            }
        }

        private void ClearCreateFields()
        {
            txtCreateFirstName.Clear();
            txtCreateLastName.Clear();
            txtCreateAddress.Clear();
            txtCreateCity.Clear();
            txtCreateState.Clear();
            txtCreateZip.Clear();
            txtCreateEmail.Clear();
            txtCreateAccountNum.Clear();
            txtCreateCardNum.Clear();
            txtCreatePhone.Clear();
            lstCreatePhones.Items.Clear();
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            string firstName = txtSearchFirstName.Text.Trim();
            string lastName = txtSearchLastName.Text.Trim();

            if ((firstName != "" && firstName.Length < 2) ||
                (lastName != "" && lastName.Length < 2))
            {
                MessageBox.Show("If used, first or last name must be at least 2 characters.");
                return;
            }

            try
            {
                string query = @"
                    SELECT CustomerID, FirstName, LastName, Email, AccountNum
                    FROM Customer
                    WHERE (@firstName = '' OR FirstName LIKE @firstNameLike)
                      AND (@lastName = '' OR LastName LIKE @lastNameLike)
                    ORDER BY LastName, FirstName;";

                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    cmd.Parameters.Add("@firstName", SqlDbType.VarChar, 40).Value = firstName;
                    cmd.Parameters.Add("@lastName", SqlDbType.VarChar, 40).Value = lastName;
                    cmd.Parameters.Add("@firstNameLike", SqlDbType.VarChar, 50).Value = firstName + "%";
                    cmd.Parameters.Add("@lastNameLike", SqlDbType.VarChar, 50).Value = lastName + "%";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvSearchResults.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Search Error");
            }
        }

        private void btnOpenDetails_Click(object sender, EventArgs e)
        {
            if (dgvSearchResults.CurrentRow == null)
            {
                MessageBox.Show("Select a customer first.");
                return;
            }

            int customerId = Convert.ToInt32(dgvSearchResults.CurrentRow.Cells["CustomerID"].Value);

            CustomerDetailsForm detailsForm = new CustomerDetailsForm(myConnection, customerId);
            detailsForm.ShowDialog();

            btnSearchCustomer.PerformClick();
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