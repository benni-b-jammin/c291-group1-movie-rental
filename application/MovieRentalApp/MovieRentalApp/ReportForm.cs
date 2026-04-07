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
                        AVG(CAST(AR.ARate AS FLOAT)) AS AvgRating
                    FROM ACTOR A
                    JOIN ActorRating AR on A.ActorID = AR.ActorID
                    WHERE (@GenderFilter IS NULL or A.Gender = @GenderFilter)
                    GROUP BY
                        A.ActorID,
                        A.ActorName,
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
                // Get year
                int selectedYear = Convert.ToInt32(SalesYear.SelectedItem);

                // Query
                string query = @"
                    SELECT
                        DATENAME(MONTH, R.CheckoutDate) As SalesMonth,
                        YEAR(R.CheckoutDate) AS Year,
                        SUM(M.DistFee) As TotalRevenue
                    FROM Rental R
                    JOIN Movie M ON R.MovieID = M.MovieID
                    WHERE
                        YEAR(R.CheckoutDate) = @Year
                    GROUP BY
                        MONTH(R.CheckoutDate),
                        DATENAME(MONTH, R.CheckoutDate),
                        YEAR(R.CheckoutDate)
                    ORDER BY
                        MONTH(R.CheckoutDate);";

                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
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

                using (SqlCommand cmd = new SqlCommand(query, myConnection))
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

        private void RunMovieReport_Click(object sender, EventArgs e)
        {
            try
            {
                // Selected values
                string selectedMonth = MovieMonth.SelectedItem.ToString();
                int selectedYear = Convert.ToInt32(MovieYear.SelectedItem);

                // string month -> number
                int monthNumber = DateTime.ParseExact(selectedMonth, "MMMM", null).Month;

                // query
                string query = @"
                    SELECT TOP 3 WITH TIES
                        M.MovieID,
                        M.MovieName,
                        COUNT(R.RentalID) AS TimesRented
                    FROM Movie M
                    JOIN Rental R ON M.MovieID = R.MovieID
                    WHERE
                        MONTH(R.CheckoutDate) = @Month
                        AND YEAR(R.CheckoutDate) = @Year
                    GROUP BY
                        M.MovieID,
                        M.MovieName
                    ORDER BY
                        TimesRented DESC;";

                using (SqlCommand cmd = new SqlCommand(query, myConnection))
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

                    resultsForm.Text = "Top 3 Movies";
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

        // Get all the customers for the combo box
        private void LoadCustomers()
        {
            string query = @"
                SELECT CustomerID, FirstName + ' ' + LastName AS FullName
                FROM Customer
                ORDER BY FullName;";

            using (SqlCommand cmd = new SqlCommand(query, myConnection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                CustomerBox.DataSource = table;
                CustomerBox.DisplayMember = "FullName"; // Displays full name
                CustomerBox.ValueMember = "CustomerId"; // Based on customer id
            }
        }

        // Load in the customers when the form is loaded
        private void ReportForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();

            // Setting defaults so the form doesn't crash
            //SalesMonth.SelectedItem = "January";
            SalesYear.SelectedItem = "2025";

            EmployeeMonth.SelectedItem = "January";
            EmployeeYear.SelectedItem = "2025";

            MovieMonth.SelectedItem = "January";
            MovieYear.SelectedItem = "2025";
        }

        private void RUNMOVIESUGGEST_Click(object sender, EventArgs e)
        {
            try
            {
                int customerid = Convert.ToInt32(CustomerBox.SelectedValue);

                string query = @"
                    WITH CustomerInfo AS (
                        SELECT CustomerID, City
                        FROM Customer
                        WHERE CustomerID = @CustomerID
                    ),
                    FavouriteGenre AS (
                        SELECT TOP 1
                            M.MovieType
                        FROM Rental R
                        JOIN Movie M ON R.MovieID = M.MovieID
                        WHERE R.CustomerID = @CustomerID
                        GROUP BY M.MovieType
                        ORDER BY COUNT(*) DESC
                    ),
                    TopAreaMovies AS (
                        SELECT TOP 2
                            M.MovieID,
                            M.MovieName,
                            COUNT(*) AS RentalCount,
                            'Popular in Area' AS Category
                        FROM Rental R
                        JOIN Customer C ON R.CustomerID = C.CustomerID
                        JOIN Movie M ON R.MovieID = M.MovieID
                        WHERE C.City = (SELECT City FROM CustomerINFO)
                        GROUP BY M.MovieID, M.MovieName
                        ORDER BY COUNT(*) DESC
                    ),
                    TopGenreMovies AS (
                        SELECT TOP 3
                            M.MovieID,
                            M.MovieName,
                            COUNT(*) AS RentalCount,
                            'Favourite Genre' AS Category
                        FROM Rental R
                        JOIN Movie M on R.MovieID = M.MovieID
                        WHERE M.MovieType IN (SELECT MovieType FROM FavouriteGenre)
                        GROUP BY M.MovieID, M.MovieName
                        ORDER BY COUNT(*) DESC
                    )

                    SELECT * FROM TopAreaMovies
                    UNION ALL
                    SELECT * FROM TopGenreMovies;";

                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerid);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    Form resultsForm = new Form();
                    DataGridView grid = new DataGridView
                    {
                        Dock = DockStyle.Fill,
                        DataSource = table,
                        AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    };

                    resultsForm.Text = "Recommended Movies";
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
    }
}
