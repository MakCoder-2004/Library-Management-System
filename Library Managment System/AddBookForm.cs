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
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }


        private void AddBook_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=.;Database=Library_Management_System;integrated security=true;";

            // Validate input fields
            if (string.IsNullOrEmpty(txtBookName.Text) ||
                string.IsNullOrEmpty(txtPublisher.Text) ||
                string.IsNullOrEmpty(txtOLB.Text) ||
                string.IsNullOrEmpty(txtISBN.Text) ||
                string.IsNullOrEmpty(txtCategory.Text) ||
                string.IsNullOrEmpty(txtAuthor.Text) ||
                string.IsNullOrEmpty(txtAmount.Text) ||
                string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Step 1: Insert into Books table
                    string insertBookQuery = @"
                    INSERT INTO Books (Name, Date, OLB, Publisher, ISBN, AuthorName, Category, Location, Amount, Price)
                    VALUES (@Name, @Date, @OLB, @Publisher, @ISBN, @AuthorName, @Category, @Location, @Amount, @Price);
                    SELECT SCOPE_IDENTITY();";

                    SqlCommand bookCommand = new SqlCommand(insertBookQuery, connection);
                    bookCommand.Parameters.AddWithValue("@Name", txtBookName.Text);
                    bookCommand.Parameters.AddWithValue("@Date", DateTime.Now); // Assuming current date
                    bookCommand.Parameters.AddWithValue("@OLB", txtOLB.Text);
                    bookCommand.Parameters.AddWithValue("@Pages", 100); // Placeholder for number of pages
                    bookCommand.Parameters.AddWithValue("@Publisher", txtPublisher.Text);
                    bookCommand.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                    bookCommand.Parameters.AddWithValue("@AuthorName", txtAuthor.Text);
                    bookCommand.Parameters.AddWithValue("@Category", txtCategory.Text);
                    bookCommand.Parameters.AddWithValue("@Location", txtLocation.Text);
                    bookCommand.Parameters.AddWithValue("@Amount", int.Parse(txtAmount.Text));
                    bookCommand.Parameters.AddWithValue("@Price", float.Parse(txtPrice.Text)); // Placeholder for price

                    int bookID = Convert.ToInt32(bookCommand.ExecuteScalar()); // Get the inserted book's ID

                    MessageBox.Show("Book added successfully!");

                    connection.Close();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {

        }
    }
}
