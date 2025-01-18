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
    public partial class frmBooks : Form
    {

        public frmBooks()
        {
            InitializeComponent();
        }

        public class Book
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime? Date { get; set; }
            public string OLB { get; set; }
            public string Publisher { get; set; }
            public string ISBN { get; set; }
            public string AuthorName { get; set; }
            public string Category { get; set; }
            public string Location { get; set; }
            public int Amount { get; set; }
            public float Price { get; set; }
        }


        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.Show();
        }

        private void btnAllBooks_Click(object sender, EventArgs e)
        {
            AllBooksForm AllBooksForm = new AllBooksForm();
            AllBooksForm.Show();
        }

        private void SearchBook_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=.;Database=Library_Management_System;integrated security=true;";
            string searchQuery = txtSearch.Text;
            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                MessageBox.Show("Please enter a search term.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Books WHERE Name LIKE @search OR AuthorName LIKE @search OR Publisher LIKE @search OR ISBN LIKE @search";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@search", "%" + searchQuery + "%");

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    BookDetailsForm BookdetailsForm = new BookDetailsForm(reader);
                    BookdetailsForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No books found.");
                }
            }
        }
    }
}
