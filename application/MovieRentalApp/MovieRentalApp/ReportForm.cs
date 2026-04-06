using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Text;
using System.Transactions;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MovieRentalApp
{
    public partial class ReportForm : Form
    {
        private SqlConnection myConnection;

        public ReportForm(SqlConnection connection)
        {
            InitializeComponent();
            myConnection = connection;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Actors_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ActressActor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RunReport_Click(object sender, EventArgs e)
        {
            try
            {
                // gender checker
                int? genderFilter = null;

                //Radio buttons
                if (Actors.Checked)
                    genderFilter = 1; //Actors
                if (Actress.Checked)
                    genderFilter = 0; //Actresses
                else if (ActressActor.Checked)
                    genderFilter = null; //Both

                // Gets top 5 with ties using the gender selected in the radio buttons
                string query = @"
                    SELECT TOP 5 WITH TIES
                        A.ActorID,
                        A.ActorName,
                        A.Gender,
                        AVG(CAST(AR.ARate AS FLOAT)) AS AvgRating
                    FROM ACTOR A
                    JOIN ActorRating AR on A.ActorID = AR.ActorID
                    WHERE (@GenderFilter IS NULL or A.Gender = @GenderFilter)
                    GROUP BY
                        A.ActorID,
                        A.ActorName,
                        A.Gender
                    ORDER BY
                        AvgRating DESC;";

                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    if (genderFilter.HasValue)
                        cmd.Parameters.AddWithValue("@GenderFilter", genderFilter.Value);
                    else
                        cmd.Parameters.AddWithValue("@GenderFilter", DBNull.Value);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Create the new window for results
                    Form resultsForm = new Form();
                    DataGridView grid = new DataGridView
                    {
                        Dock = DockStyle.Fill,
                        DataSource = table,
                        AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    };
                    resultsForm.Text = "Top 5 Rated Actors";
                    resultsForm.Controls.Add(grid);
                    resultsForm.Size = new Size(600, 400);
                    resultsForm.Show();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void RunSalesReport_Click(object sender, EventArgs e)
        {
            try
            {
                // Get month and year
                string selectedMonth = SalesMonth.SelectedItem.ToString();
                int selectedYear = Convert.ToInt32(SalesYear.SelectedItem);

                // Convert month name to number
                int monthNumber = DateTime.ParseExact(selectedMonth, "MMMM", null).Month;

                // Query
                string query = @"
                    SELECT
                        DATENAME(MONTH, R.CheckoutDate) As Month,
                        YEAR(R.CheckoutDate) AS Year,
                        SUM(M.DistFee) As TotalRevenue
                    FROM Rental R
                    JOIN Movie M ON R.MovieID = M.MovieID
                    WHERE
                        MONTH(R.CheckoutDate) = @Month
                        AND YEAR(R.CheckoutDate) = @Year
                    GROUP BY
                        DATENAME(MONTH, R.CheckoutDate),
                        YEAR(R.CheckoutDate);";

                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    cmd.Parameters.AddWithValue("@Month", monthNumber);
                    cmd.Parameters.AddWithValue("@Year", selectedYear);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Results form creation

                    Form resultsForm = new Form();
                    DataGridView grid = new DataGridView
                    {
                        Dock = DockStyle.Fill,
                        DataSource = table,
                        AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    };

                    resultsForm.Text = "Sales Report";
                    resultsForm.Controls.Add(grid);
                    resultsForm.Size = new Size(600, 400);
                    resultsForm.Show();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RunTopEmployees_Click(object sender, EventArgs e)
        {
            try
            {
                // Selected values
                string selectedMonth = EmployeeMonth.SelectedItem.ToString();
                int selectedYear = Convert.ToInt32(EmployeeYear.SelectedItem);

                // string month -> number
                int monthNumber = DateTime.ParseExact(selectedMonth, "MMMM", null).Month;

                // query
                string query = @"
                    SELECT TOP 3 WITH TIES
                        E.EmployeeID,
                        E.FirstName,
                        E.LastName,
                        COUNT(R.RentalID) AS TotalOrders
                    FROM Employee E
                    JOIN Rental R ON E.EmployeeID = R.EmployeeID
                    WHERE
                        MONTH(R.CheckoutDate) = @Month
                        AND YEAR(R.CheckoutDate) = @Year
                    GROUP BY
                        E.EmployeeID,
                        E.FirstName,
                        E.LastName
                    ORDER BY
                        TotalOrders DESC;";

                using(SqlCommand cmd = new SqlCommand(query,myConnection))
                {
                    cmd.Parameters.AddWithValue("@Month", monthNumber);
                    cmd.Parameters.AddWithValue("@Year", selectedYear);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    //Results
                    Form resultsForm = new Form();
                    DataGridView grid = new DataGridView
                    {
                        Dock = DockStyle.Fill,
                        DataSource = table,
                        AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    };

                    resultsForm.Text = "Top 3 Employees";
                    resultsForm.Controls.Add(grid);
                    resultsForm.Size = new Size(600, 400);
                    resultsForm.Show();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
