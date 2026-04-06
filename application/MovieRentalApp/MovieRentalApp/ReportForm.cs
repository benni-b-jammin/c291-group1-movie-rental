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
                int? genderFilter = null;

                //Radio buttons
                if (Actors.Checked)
                    genderFilter = 1; //Actors
                if (Actress.Checked)
                    genderFilter = 0; //Actresses
                else if (ActressActor.Checked)
                    genderFilter = null; //Both

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
    }
}
