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
                    CAST(CustomerID AS VARCHAR) + ' - ' + FirstName + ' ' + LastName AS DisplayText
                    FROM Customer;";

                SqlDataAdapter adapter = new SqlDataAdapter(query, myConnection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                listCust.DataSource = table;
                listCust.DisplayMember = "DisplayText";   
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
                        END + ')' AS DisplayText
                        FROM QueueUp q
                        JOIN Movie m ON q.MovieID = m.MovieID
                        WHERE q.CustomerID = @CustomerID
                        ORDER BY q.QueuePosition;";

                SqlDataAdapter adapter = new SqlDataAdapter(query, myConnection);
                adapter.SelectCommand.Parameters.AddWithValue("@CustomerID", customerId);

                DataTable table = new DataTable();
                adapter.Fill(table);

                listQueue.DataSource = table;
                listQueue.DisplayMember = "DisplayText"; 
                listQueue.ValueMember = "MovieID";       
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Queue Load Error");
            }
        }
    }
}
