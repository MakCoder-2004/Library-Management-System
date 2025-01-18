using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class ReturnForm : Form
    {
        public ReturnForm()
        {
            InitializeComponent();
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            string borrowID = txtBorrowID.Text;
            string fineAmountText = txtFineAmount.Text;
            string fineReason = GetSelectedFineReason();

            if (string.IsNullOrWhiteSpace(borrowID))
            {
                MessageBox.Show("Please enter Borrow ID.");
                return;
            }

            if (fineReason == "None")
            {
                txtFineAmount.Text = "0";
            }
            else if (string.IsNullOrWhiteSpace(fineAmountText) && fineReason != "Late")
            {
                MessageBox.Show("Please enter the fine amount.");
                return;
            }

            // Call the ReturnBook function
            decimal fineAmount = string.IsNullOrWhiteSpace(fineAmountText) ? 0 : Convert.ToDecimal(fineAmountText);

            if (ReturnBook(borrowID, fineAmount, fineReason))
            {
                MessageBox.Show("Book returned successfully!");
            }
            else
            {
                MessageBox.Show("Failed to return book. Please check the details and try again.");
            }
        }

        private string GetSelectedFineReason()
        {
            if (rbtnLate.Checked) return "Late";
            if (rbtnDamage.Checked) return "Damage";
            if (rbtnBoth.Checked) return "Both";
            return "None";
        }

        private bool ReturnBook(string borrowID, decimal fineAmount, string fineReason)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Server=.;Database=Library_Management_System;Integrated Security=True;"))
                {
                    conn.Open();

                    // Check if Borrow ID exists
                    string queryBorrowCheck = "SELECT MemberId, BorrowId, BookId, DueDate FROM Borrow WHERE BorrowId = @BorrowId";
                    SqlCommand cmdBorrowCheck = new SqlCommand(queryBorrowCheck, conn);
                    cmdBorrowCheck.Parameters.AddWithValue("@BorrowId", borrowID);

                    SqlDataReader reader = cmdBorrowCheck.ExecuteReader();
                    if (!reader.Read())
                    {
                        MessageBox.Show("Invalid Borrow ID.");
                        return false;
                    }

                    int memberId = (int)reader["MemberId"];
                    string bookId = reader["BookId"].ToString();
                    DateTime dueDate = (DateTime)reader["DueDate"];
                    int borrowId = (int)reader["BorrowId"]; // Retrieve BorrowId from the database
                    reader.Close();

                    // Determine if the return is late
                    bool isLate = DateTime.Now > dueDate;
                    if (isLate && fineReason == "None")
                    {
                        fineReason = "Late";
                        fineAmount += 50; // Automatically add 50 pounds for late
                    }

                    // Insert into Returning table
                    string queryReturn = "INSERT INTO Returning (StaffId, MemberId, BookId, BorrowId, ReturnDate) " +
                                         "OUTPUT INSERTED.ReturnId " + // Retrieve the generated ReturnId
                                         "VALUES (@StaffId, @MemberId, @BookId, @BorrowId, @ReturnDate)";
                    SqlCommand cmdReturn = new SqlCommand(queryReturn, conn);
                    cmdReturn.Parameters.AddWithValue("@StaffId", DBNull.Value); // Replace with actual StaffId or leave as NULL
                    cmdReturn.Parameters.AddWithValue("@MemberId", memberId);
                    cmdReturn.Parameters.AddWithValue("@BookId", bookId);
                    cmdReturn.Parameters.AddWithValue("@BorrowId", borrowId); // Use the retrieved BorrowId
                    cmdReturn.Parameters.AddWithValue("@ReturnDate", DateTime.Now);

                    // Execute the query and retrieve the generated ReturnId
                    int returnId = (int)cmdReturn.ExecuteScalar();

                    // Insert into Fines table if applicable
                    if (fineReason != "None")
                    {
                        string queryFine = "INSERT INTO Fines (MemberId, BookId, FineAmount, FineType, ReturnDate, ReturnId) " +
                                           "VALUES (@MemberId, @BookId, @FineAmount, @FineType, @ReturnDate, @ReturnId)";
                        SqlCommand cmdFine = new SqlCommand(queryFine, conn);
                        cmdFine.Parameters.AddWithValue("@MemberId", memberId);
                        cmdFine.Parameters.AddWithValue("@BookId", bookId);
                        cmdFine.Parameters.AddWithValue("@FineAmount", fineAmount);
                        cmdFine.Parameters.AddWithValue("@FineType", fineReason);
                        cmdFine.Parameters.AddWithValue("@ReturnDate", DateTime.Now);
                        cmdFine.Parameters.AddWithValue("@ReturnId", returnId); // Use the generated ReturnId
                        cmdFine.ExecuteNonQuery();
                    }

                    // Update Book Amount
                    string queryUpdateBook = "UPDATE Books SET Amount = Amount + 1 WHERE ISBN = @ISBN";
                    SqlCommand cmdUpdateBook = new SqlCommand(queryUpdateBook, conn);
                    cmdUpdateBook.Parameters.AddWithValue("@ISBN", bookId);
                    cmdUpdateBook.ExecuteNonQuery();

                    // Update Member Borrow State
                    string queryUpdateMember = "UPDATE Members SET BorrowState = 0 WHERE id = @MemberId";
                    SqlCommand cmdUpdateMember = new SqlCommand(queryUpdateMember, conn);
                    cmdUpdateMember.Parameters.AddWithValue("@MemberId", memberId);
                    cmdUpdateMember.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
    }
}
