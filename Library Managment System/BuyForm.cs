using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class BuyForm : Form
    {
        public BuyForm()
        {
            InitializeComponent();
        }

        private bool BuyBook(string bookID, string customerName, string customerContact)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Server=.;Database=Library_Management_System;Integrated Security=True;"))
                {
                    conn.Open();

                    // Check Book Availability
                    string queryBook = "SELECT id, Amount, Price FROM Books WHERE id = @BookID AND Amount > 0";
                    SqlCommand cmdBook = new SqlCommand(queryBook, conn);
                    cmdBook.Parameters.AddWithValue("@BookID", bookID);

                    SqlDataReader reader = cmdBook.ExecuteReader();
                    if (!reader.Read())
                    {
                        MessageBox.Show("Book is not available for purchase.");
                        return false;
                    }

                    int bookAmount = (int)reader["Amount"];
                    float bookPrice = Convert.ToSingle(reader["Price"]); // Fixed casting issue
                    reader.Close();

                    // Insert Buy Record
                    string queryBuy = "INSERT INTO Buy (BookId, CustomerName, CustomerContact, PurchaseDate, TotalPrice) " +
                                      "VALUES (@BookId, @CustomerName, @CustomerContact, @PurchaseDate, @TotalPrice)";
                    SqlCommand cmdBuy = new SqlCommand(queryBuy, conn);
                    cmdBuy.Parameters.AddWithValue("@BookId", bookID);
                    cmdBuy.Parameters.AddWithValue("@CustomerName", customerName);
                    cmdBuy.Parameters.AddWithValue("@CustomerContact", customerContact);
                    cmdBuy.Parameters.AddWithValue("@PurchaseDate", DateTime.Now);
                    cmdBuy.Parameters.AddWithValue("@TotalPrice", bookPrice);

                    cmdBuy.ExecuteNonQuery();

                    // Update Book Availability
                    string queryUpdateBook = "UPDATE Books SET Amount = Amount - 1 WHERE id = @BookID";
                    SqlCommand cmdUpdateBook = new SqlCommand(queryUpdateBook, conn);
                    cmdUpdateBook.Parameters.AddWithValue("@BookID", bookID);

                    cmdUpdateBook.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
        
        

        private void AddBook_Click(object sender, EventArgs e)
        {
            string bookID = txtBookID.Text;
            string customerName = txtCustomerName.Text;
            string customerContact = txtCustomerContact.Text;

            if (string.IsNullOrWhiteSpace(bookID) || string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(customerContact))
            {
                MessageBox.Show("Please fill in all the required fields: Book ID, Customer Name, and Customer Contact.");
                return;
            }

            // Call the BuyBook function
            if (BuyBook(bookID, customerName, customerContact))
            {
                MessageBox.Show("Book purchased successfully!");
            }
            else
            {
                MessageBox.Show("Failed to purchase book. Please check the details and try again.");
            }
        }
    }
}
