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
using static System.Net.Mime.MediaTypeNames;

namespace Library_Management_System
{
    public partial class frmSearchStaff : Form
    {
        String s = "Data Source=.;initial catalog =Library_Management_System;integrated security=true;";

        static int id;
        public frmSearchStaff(string text)
        {
            InitializeComponent();
            id = int.Parse(text);

            using (SqlConnection con = new SqlConnection(s))
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("SP_searchStaff", con);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.Add("id", SqlDbType.Int).Value = id;
                SqlDataReader dr = cmd1.ExecuteReader();
                dr.Read();

                textName.Text = dr["name"].ToString();
                textSSN.Text = dr["SSN"].ToString();
                textAddress.Text = dr["Address"].ToString();
                textPhone1.Text = dr["Phone1"].ToString();
                textPhone2.Text = dr["Phone2"].ToString();
                textBirth.Text = dr["BirthDate"].ToString();
                textWork.Text = dr["WorkType"].ToString();
                textHire.Text = dr["HireDate"].ToString();
                textEmail.Text = dr["Email"].ToString();
                con.Close();
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            textName.ReadOnly = false;
            textSSN.ReadOnly = false;
            textPhone1.ReadOnly = false;
            textPhone2.ReadOnly = false;
            textAddress.ReadOnly = false;
            textEmail.ReadOnly = false;
            textHire.ReadOnly = false;
            textBirth.ReadOnly = false;
            textWork.ReadOnly = false;
            buttonDone.Visible = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
        }
        
        private void buttonDone_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(s))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_editStaff", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@name", SqlDbType.VarChar, 100).Value = textName.Text;
                cmd.Parameters.Add("@ssn", SqlDbType.VarChar, 14).Value = textSSN.Text;
                cmd.Parameters.Add("@address", SqlDbType.VarChar, 200).Value = textAddress.Text;
                cmd.Parameters.Add("@hire", SqlDbType.Date).Value = textHire.Text;
                cmd.Parameters.Add("@phone1", SqlDbType.VarChar, 20).Value = textPhone1.Text;
                cmd.Parameters.Add("@phone2", SqlDbType.VarChar, 20).Value = textPhone2.Text;
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 30).Value = textEmail.Text;
                cmd.Parameters.Add("@birth", SqlDbType.Date).Value = textBirth.Text;
                cmd.Parameters.Add("@work", SqlDbType.VarChar, 30).Value = textWork.Text;

                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                MessageBox.Show("Staff Updated Successfully!");
                this.Close();
            }
        }

    }
}

