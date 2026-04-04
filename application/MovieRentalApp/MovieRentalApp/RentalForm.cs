using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MovieRentalApp
{
    public partial class RentalForm : Form
    {
        private SqlConnection myConnection;
        string currentUser;
        public RentalForm(SqlConnection connection, string username)
        { 
            InitializeComponent();
            myConnection = connection;
            LoadCustomers();
            currentUser = username;
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

                if (!(FirstNameText.Text == ""))
                {
                    query += " AND FirstName = @FirstName";
                }

                if (!(LastNameText.Text == ""))
                {
                    query += " AND LastName = @LastName";
                }


                SqlDataAdapter adapter = new SqlDataAdapter(query, myConnection);
                if (!(FirstNameText.Text == ""))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@FirstName", FirstNameText.Text);
                }

                if (!(LastNameText.Text == ""))
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
            if(listCust.SelectedValue == null)
{
                MessageBox.Show("Please Select Customer");
                return;
            }

            if (listQueue.SelectedValue == null)
            {
                MessageBox.Show("Please Select Movie");
                return;
            }

            
            if (listQueue.Text.Contains("Unavailable"))
            {
                MessageBox.Show("Movie is unavailable");
                return;
            }

            int customerID = Convert.ToInt32(listCust.SelectedValue);
            int movieID = Convert.ToInt32(listQueue.SelectedValue);
            int position = listQueue.SelectedIndex + 1;

            SqlTransaction transaction = null;
            
            try
            {
                transaction = myConnection.BeginTransaction();


                string rentalQuery = @"
                    INSERT INTO Rental
                    (
                        RentalID, EmployeeID, CustomerID, MovieID
                    )
                    VALUES
                    (
                        NEXT VALUE FOR RentalIDSeq,
                        (SELECT EmployeeID FROM Employee WHERE Username = @currentUser), 
                        @customerID,
                        @movieID
                    );";

                using (SqlCommand cmd = new SqlCommand(rentalQuery, myConnection, transaction))
                {
                    cmd.Parameters.Add("@currentUser", SqlDbType.VarChar, 40).Value = currentUser;
                    cmd.Parameters.Add("@customerID", SqlDbType.Int).Value = customerID;
                    cmd.Parameters.Add("@movieID", SqlDbType.Int).Value = movieID;
                    cmd.ExecuteNonQuery();
                }

                string deleteQueue = @"
                DELETE FROM QueueUp
                WHERE CustomerID = @customerID AND MovieID = @movieID";

                using (SqlCommand cmd = new SqlCommand(deleteQueue, myConnection, transaction))
                {
                    cmd.Parameters.Add("@customerID", SqlDbType.Int).Value = customerID;
                    cmd.Parameters.Add("@movieID", SqlDbType.Int).Value = movieID;
                    cmd.ExecuteNonQuery();
                }

                string shiftQueue = @"
                UPDATE QueueUp
                SET QueuePosition = QueuePosition - 1
                WHERE CustomerID = @customerID AND QueuePosition > @position";

                using (SqlCommand cmd = new SqlCommand(shiftQueue, myConnection, transaction))
                {
                    cmd.Parameters.Add("@customerID", SqlDbType.Int).Value = customerID;
                    cmd.Parameters.Add("@position", SqlDbType.Int).Value = position;
                    cmd.ExecuteNonQuery();
                }

                string copiesRented = @"
                UPDATE Movie
                SET CopiesRented = CopiesRented + 1
                WHERE MovieID = @movieID";

                using (SqlCommand cmd = new SqlCommand(copiesRented, myConnection, transaction))
                {
                    cmd.Parameters.Add("@movieID", SqlDbType.Int).Value = movieID;
                    cmd.ExecuteNonQuery();
                }

                transaction.Commit();

                if (int.TryParse(listCust.SelectedValue.ToString(), out int customerId))
                {
                    LoadQueue(customerId);
                }

                MessageBox.Show("Movie Added to Customer Rental.");
           
            }
            catch (Exception ex)
            {
                if (transaction != null)
                    transaction.Rollback();

                MessageBox.Show(ex.ToString(), "Dispense Error");
            }
            
        }
    }
}
