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
    public partial class MovieDetailsForm : Form
    {
        private SqlConnection myConnection;
        public MovieDetailsForm(SqlConnection connection)
        {
            InitializeComponent();
            myConnection = connection;
        }


    }
}