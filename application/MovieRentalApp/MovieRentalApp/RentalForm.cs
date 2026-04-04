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
    public partial class RentalForm : Form
    {
        private SqlConnection myConnection;
        public RentalForm(SqlConnection connection)
        {
            InitializeComponent();
            myConnection = connection;
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            listCust.Items.Clear();

            try
            {
                string query = @"
                    SELECT CustomerID, 
                    CAST(CustomerID AS VARCHAR) + ' - ' + FirstName + ' ' + LastName AS ListDisplay
                    FROM Customer;";

                SqlDataAdapter adapter = new SqlDataAdapter(query, myConnection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                listCust.DataSource = table;
                listCust.DisplayMember = "ListDisplay";
                listCust.ValueMember = "CustomerID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "List Customer Error");
            }
        }

        private void listCust_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listCust.SelectedValue == null)
                return;

            if (int.TryParse(listCust.SelectedValue.ToString(), out int customerId))
            {
                LoadQueue(customerId);
            }
        }

        private void LoadQueue(int customerId)
        {

            try
            {
                string query = @"
                    SELECT 
                        q.MovieID,
                        q.QueuePosition,
                        m.MovieName,
                        CASE
                            WHEN (m.NumOfCopies - m.CopiesRented) > 0 THEN 'Available'
                            ELSE 'Unavailable'
                            END AS Availibility,
                        CAST(q.QueuePosition AS VARCHAR) + '. ' + m.MovieName + ' (' + 
                        CASE 
                            WHEN (m.NumOfCopies - m.CopiesRented) > 0 THEN 'Available'
                            ELSE 'Unavailable'
                        END + ')' AS ListDisplay
                        FROM QueueUp q
                        JOIN Movie m ON q.MovieID = m.MovieID
                        WHERE q.CustomerID = @CustomerID
                        ORDER BY q.QueuePosition;";

                SqlDataAdapter adapter = new SqlDataAdapter(query, myConnection);
                adapter.SelectCommand.Parameters.AddWithValue("@CustomerID", customerId);

                DataTable table = new DataTable();
                adapter.Fill(table);

                listQueue.DataSource = table;
                listQueue.DisplayMember = "ListDisplay";
                listQueue.ValueMember = "MovieID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "List Queue Error");
            }
        }

        

        private void buttonFilter_Click(object sender, EventArgs e)
        {

            try
            {
                string query = @"
                    SELECT CustomerID, 
                    CAST(CustomerID AS VARCHAR) + ' - ' + FirstName + ' ' + LastName AS ListDisplay
                    FROM Customer
                    WHERE 1=1";

                if (!string.IsNullOrWhiteSpace(FirstNameText.Text))
                {
                    query += " AND FirstName = @FirstName";
                }

                if (!string.IsNullOrWhiteSpace(LastNameText.Text))
                {
                    query += " AND LastName = @LastName";
                }


                SqlDataAdapter adapter = new SqlDataAdapter(query, myConnection);
                if (!string.IsNullOrWhiteSpace(FirstNameText.Text))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@FirstName", FirstNameText.Text);
                }

                if (!string.IsNullOrWhiteSpace(LastNameText.Text))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@LastName", LastNameText.Text);
                }

                DataTable table = new DataTable();
                adapter.Fill(table);

                listCust.DataSource = table;
                listCust.DisplayMember = "ListDisplay";
                listCust.ValueMember = "CustomerID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "List Customer Error");
            }
        }

        private void DispenseButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
