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
    public partial class BorrowForm : Form
    {
        public BorrowForm()
        {
            InitializeComponent();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            string memberSSN = txtMemberSSN.Text;
            string bookID = txtBookID.Text;

            if (string.IsNullOrWhiteSpace(memberSSN) || string.IsNullOrWhiteSpace(bookID))
            {
                MessageBox.Show("Please fill in both Member SSN and Book ID.");
                return;
            }

            // Call the BorrowBook function
            if (BorrowBook(memberSSN, bookID))
            {
                MessageBox.Show("Book borrowed successfully!");
            }
            else
            {
                MessageBox.Show("Failed to borrow book. Please check the details and try again.");
            }
        }


        private bool BorrowBook(string memberSSN, string bookID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Server=.;Database=Library_Management_System;Integrated Security=True;"))
                {
                    conn.Open();

                    // Check if the member exists and is eligible to borrow
                    string queryMember = "SELECT id, MembershipStatus, BorrowState FROM Members WHERE SSN = @SSN";
                    SqlCommand cmdMember = new SqlCommand(queryMember, conn);
                    cmdMember.Parameters.AddWithValue("@SSN", memberSSN);

                    SqlDataReader memberReader = cmdMember.ExecuteReader();
                    if (!memberReader.Read())
                    {
                        MessageBox.Show("Member SSN does not exist.");
                        return false;
                    }

                    int memberId = (int)memberReader["id"];
                    bool membershipStatus = (bool)memberReader["MembershipStatus"];
                    bool borrowState = (bool)memberReader["BorrowState"];
                    memberReader.Close();

                    if (!membershipStatus)
                    {
                        MessageBox.Show("Membership is not active.");
                        return false;
                    }

                    if (borrowState)
                    {
                        MessageBox.Show("Member already has an active borrowed book. Please return it first.");
                        return false;
                    }

                    // Check if the book exists and is available
                    string queryBook = "SELECT Amount FROM Books WHERE id = @BookId";
                    SqlCommand cmdBook = new SqlCommand(queryBook, conn);
                    cmdBook.Parameters.AddWithValue("@BookID", bookID);

                    object bookAmountObj = cmdBook.ExecuteScalar();
                    if (bookAmountObj == null)
                    {
                        MessageBox.Show("Book ID does not exist.");
                        return false;
                    }

                    int bookAmount = (int)bookAmountObj;
                    if (bookAmount <= 0)
                    {
                        MessageBox.Show("Book is out of stock.");
                        return false;
                    }

                    // Insert borrow record (BorrowId is auto-incremented)
                    string queryBorrow = "INSERT INTO Borrow (MemberId, BookId, BorrowDate, DueDate) VALUES (@MemberId, @BookId, @BorrowDate, @DueDate)";
                    SqlCommand cmdBorrow = new SqlCommand(queryBorrow, conn);
                    cmdBorrow.Parameters.AddWithValue("@MemberId", memberId);
                    cmdBorrow.Parameters.AddWithValue("@BookId", bookID);
                    cmdBorrow.Parameters.AddWithValue("@BorrowDate", DateTime.Now);
                    cmdBorrow.Parameters.AddWithValue("@DueDate", DateTime.Now.AddDays(7));

                    cmdBorrow.ExecuteNonQuery();

                    // Update book amount and member borrow state
                    string queryUpdate = "UPDATE Books SET Amount = Amount - 1 WHERE id = @BookId; " +
                                         "UPDATE Members SET BorrowState = 1 WHERE SSN = @SSN";
                    SqlCommand cmdUpdate = new SqlCommand(queryUpdate, conn);
                    cmdUpdate.Parameters.AddWithValue("@BookId", bookID);
                    cmdUpdate.Parameters.AddWithValue("@SSN", memberSSN);

                    cmdUpdate.ExecuteNonQuery();

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

