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
using System.Xml.Linq;

namespace Library_Management_System
{
    public partial class frm_addMember : Form
    {
        String connectionString = "Data Source=.;initial catalog =Library_Management_System;integrated security=true;";
        public frm_addMember()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrEmpty(textName.Text) ||
                string.IsNullOrEmpty(textSSN.Text) ||
                string.IsNullOrEmpty(textAddress.Text) ||
                string.IsNullOrEmpty(textPhone1.Text) ||
                string.IsNullOrEmpty(textEmail.Text) ||
                string.IsNullOrEmpty(textBirth.Text) ||
                string.IsNullOrEmpty(textMembership.Text) ||
                string.IsNullOrEmpty(textBorrow.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL command to insert member details
                    string insertMemberQuery = @"
                    INSERT INTO Members (Name, SSN, Address, Phone1, Phone2, Email, BirthDate, MembershipStatus, BorrowState)
                    VALUES (@Name, @SSN, @Address, @Phone1, @Phone2, @Email, @BirthDate, @MembershipStatus, @BorrowState);";

                    using (SqlCommand cmd = new SqlCommand(insertMemberQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", textName.Text);
                        cmd.Parameters.AddWithValue("@SSN", textSSN.Text);
                        cmd.Parameters.AddWithValue("@Address", textAddress.Text);
                        cmd.Parameters.AddWithValue("@Phone1", textPhone1.Text);
                        cmd.Parameters.AddWithValue("@Phone2", string.IsNullOrEmpty(textPhone2.Text) ? (object)DBNull.Value : textPhone2.Text);
                        cmd.Parameters.AddWithValue("@Email", textEmail.Text);
                        cmd.Parameters.AddWithValue("@BirthDate", DateTime.Parse(textBirth.Text));
                        cmd.Parameters.AddWithValue("@MembershipStatus", bool.Parse(textMembership.Text));
                        cmd.Parameters.AddWithValue("@BorrowState", bool.Parse(textBorrow.Text));


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Member added successfully!");
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void frm_addMember_Load(object sender, EventArgs e)
        {

        }
    }
}
