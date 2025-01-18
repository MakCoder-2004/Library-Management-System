using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class frmLibraryFlow : Form
    {
        public frmLibraryFlow()
        {
            InitializeComponent();
        }

        private void btnBorrowingHistory_Click(object sender, EventArgs e)
        {
            BorrowingHistoryForm BorrowingHistoryForm = new BorrowingHistoryForm();
            BorrowingHistoryForm.Show();
        }

        private void btnBuyHistory_Click(object sender, EventArgs e)
        {
            BuyingHistoryForm BuyingHistoryForm = new BuyingHistoryForm();
            BuyingHistoryForm.Show();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            BorrowForm BorrowForm = new BorrowForm();
            BorrowForm.Show();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            BuyForm BuyForm = new BuyForm();
            BuyForm.Show();
        }

        private void btnReturnBorrowed_Click(object sender, EventArgs e)
        {
            ReturnForm ReturnForm = new ReturnForm();
            ReturnForm.Show();
        }

        
    }
}
