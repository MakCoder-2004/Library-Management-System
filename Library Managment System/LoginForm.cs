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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            string user = txtUserName.Text;
            string password = txtPassword.Text;

            try
            {
                using (SqlConnection conn = new SqlConnection("Server=.;Database=Library_Management_System;integrated security=true;"))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SP_authenticate", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@User", user);
                        cmd.Parameters.AddWithValue("@Pass", password);

                        int matches = (int)cmd.ExecuteScalar();

                        if (matches > 0)
                        {
                            // Successful login
                            Form1 Form1 = new Form1(user); // Use email or retrieve name
                            Form1.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username or password.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

