using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class BookDetailsForm : Form
    {
        private int bookId;
        private string connectionString = "Server=.;Database=Library_Management_System;Integrated Security=True;";

        public BookDetailsForm(SqlDataReader reader)
        {
            InitializeComponent();

            bookId = Convert.ToInt32(reader["id"]);
            txtName.Text = reader["Name"].ToString();
            txtAuthor.Text = reader["AuthorName"].ToString();
            txtPublisher.Text = reader["Publisher"].ToString();
            txtISBN.Text = reader["ISBN"].ToString();
            txtCategory.Text = reader["Category"].ToString();
            txtLocation.Text = reader["Location"].ToString();
            txtAmount.Text = reader["Amount"].ToString();
            txtPrice.Text = reader["Price"].ToString();

            buttonDone.Visible = false;
        }

        private void buttonEdit_Click_1(object sender, EventArgs e)
        {
            txtName.ReadOnly = false;
            txtAuthor.ReadOnly = false;
            txtPublisher.ReadOnly = false;
            txtISBN.ReadOnly = false;
            txtCategory.ReadOnly = false;
            txtLocation.ReadOnly = false;
            txtAmount.ReadOnly = false;
            txtPrice.ReadOnly = false;

            buttonDone.Visible = true;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Books SET Name = @Name, AuthorName = @AuthorName, Publisher = @Publisher, ISBN = @ISBN, Category = @Category, Location = @Location, Amount = @Amount, Price = @Price WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", bookId);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@AuthorName", txtAuthor.Text);
                    cmd.Parameters.AddWithValue("@Publisher", txtPublisher.Text);
                    cmd.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                    cmd.Parameters.AddWithValue("@Category", txtCategory.Text);
                    cmd.Parameters.AddWithValue("@Location", txtLocation.Text);
                    cmd.Parameters.AddWithValue("@Amount", Convert.ToInt32(txtAmount.Text));
                    cmd.Parameters.AddWithValue("@Price", Convert.ToDouble(txtPrice.Text));

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book updated successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating book: {ex.Message}");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Books WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", bookId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book deleted successfully.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting book: {ex.Message}");
            }
        }
    }
}
