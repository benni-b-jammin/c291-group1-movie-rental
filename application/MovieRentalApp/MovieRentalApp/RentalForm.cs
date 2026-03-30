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
        }
    }
}
