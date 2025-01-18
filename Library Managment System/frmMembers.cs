using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class frmMembers : Form
    {
        private string connectionString = "Data Source=.;initial catalog =LibrarySystem;integrated security=true";
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public frmMembers()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            frm_addMember addMember = new frm_addMember();
            addMember.Show();
        }

        private void btnAllMembers_Click(object sender, EventArgs e)
        {
            // Open a new form to view the members
            frmViewMember viewMembers = new frmViewMember();
            viewMembers.Show();
        }

        private void SearchMember_Click(object sender, EventArgs e)
        {
            frmSearchMember searchMember = new frmSearchMember(textSearch.Text);
            searchMember.Show();
        }
    }
}
