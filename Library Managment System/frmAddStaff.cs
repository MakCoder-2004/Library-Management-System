using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class frmAddStaff : Form
    {
        string connectionString = "Data Source=.;initial catalog=Library_Management_System;integrated security=true;";

        public frmAddStaff()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate user inputs
                if (string.IsNullOrWhiteSpace(textName.Text) ||
                    string.IsNullOrWhiteSpace(textSSN.Text) ||
                    string.IsNullOrWhiteSpace(textEmail.Text) ||
                    string.IsNullOrWhiteSpace(textPhone1.Text))
                {
                    MessageBox.Show("Please fill in all required fields (Name, SSN, Email, Phone1).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate SSN length
                if (textSSN.Text.Length != 14)
                {
                    MessageBox.Show("SSN must be 14 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate email format
                if (!IsValidEmail(textEmail.Text))
                {
                    MessageBox.Show("Invalid email format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SP_addStaff", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                        cmd.Parameters.Add("@name", SqlDbType.VarChar, 100).Value = textName.Text;
                        cmd.Parameters.Add("@ssn", SqlDbType.VarChar, 14).Value = textSSN.Text;
                        cmd.Parameters.Add("@address", SqlDbType.VarChar, 200).Value = textAddress.Text ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@hire", SqlDbType.Date).Value = DateTime.Now; // Automatically set to the current date
                        cmd.Parameters.Add("@phone1", SqlDbType.VarChar, 20).Value = textPhone1.Text;
                        cmd.Parameters.Add("@phone2", SqlDbType.VarChar, 20).Value = string.IsNullOrWhiteSpace(textPhone2.Text) ? (object)DBNull.Value : textPhone2.Text;
                        cmd.Parameters.Add("@email", SqlDbType.VarChar, 30).Value = textEmail.Text;
                        cmd.Parameters.Add("@birth", SqlDbType.Date).Value = DateTime.TryParse(textBirth.Text, out DateTime birthDate) ? birthDate : (object)DBNull.Value;
                        cmd.Parameters.Add("@work", SqlDbType.VarChar, 30).Value = textWork.Text ?? (object)DBNull.Value;

                        // Execute the stored procedure
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Staff saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Invalid date format: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper method to validate email format
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
