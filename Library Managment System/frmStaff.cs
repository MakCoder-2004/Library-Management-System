using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_Management_System
{
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
            
        }

        private void btnAllStaff_Click(object sender, EventArgs e)
        {
            frmViewStaff viewStaff = new frmViewStaff();
            viewStaff.Show();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            frmAddStaff addStaff = new frmAddStaff();
            addStaff.Show();
        }

        private void SearchEmployee_Click(object sender, EventArgs e)
        {
            frmSearchStaff searchStaff = new frmSearchStaff(textSearchStaff.Text);
            searchStaff.Show();
        }
    }
}