using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class BorrowingHistoryForm : Form
    {
        public BorrowingHistoryForm()
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.;initial catalog =Library_Management_System;integrated security=true";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Borrow";
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridBorrowingHistory.DataSource = dt;
            dr.Close();
            con.Close();
        }
    }
}
