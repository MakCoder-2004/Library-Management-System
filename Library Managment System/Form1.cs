using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Library_Management_System
{
    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public Form1(string staffName)
        {
            InitializeComponent();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnAbout.Height;
            pnlNav.Top = btnAbout.Top;
            pnlNav.Left = btnAbout.Left;
            btnAbout.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "About";
            this.pnlFormLoader.Controls.Clear();
            frmAbout frmAbout_Vrb = new frmAbout() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAbout_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmAbout_Vrb);
            frmAbout_Vrb.Show();

            lblAdminPanel.Text = $"{staffName}'s Panel";
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnBooks.Height;
            pnlNav.Top = btnBooks.Top;
            pnlNav.Left = btnBooks.Left;
            btnBooks.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Books";
            this.pnlFormLoader.Controls.Clear();
            frmBooks frmBooks_Vrb = new frmBooks() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmBooks_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmBooks_Vrb);
            frmBooks_Vrb.Show();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnMembers.Height;
            pnlNav.Top = btnMembers.Top;
            pnlNav.Left = btnMembers.Left;
            btnMembers.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Members";
            this.pnlFormLoader.Controls.Clear();
            frmMembers frmMembers_Vrb = new frmMembers() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmMembers_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmMembers_Vrb);
            frmMembers_Vrb.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnStaff.Height;
            pnlNav.Top = btnStaff.Top;
            pnlNav.Left = btnStaff.Left;
            btnStaff.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Staff";
            this.pnlFormLoader.Controls.Clear();
            frmStaff frmStaff_Vrb = new frmStaff() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmStaff_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmStaff_Vrb);
            frmStaff_Vrb.Show();
        }

        private void btnLibraryFlow_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnLibraryFlow.Height;
            pnlNav.Top = btnLibraryFlow.Top;
            pnlNav.Left = btnLibraryFlow.Left;
            btnLibraryFlow.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Library Flow";
            this.pnlFormLoader.Controls.Clear();
            frmLibraryFlow frmLibraryFlow_Vrb = new frmLibraryFlow() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmLibraryFlow_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmLibraryFlow_Vrb);
            frmLibraryFlow_Vrb.Show();


        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAbout.Height;
            pnlNav.Top = btnAbout.Top;
            pnlNav.Left = btnAbout.Left;
            btnAbout.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "About";
            this.pnlFormLoader.Controls.Clear();
            frmAbout frmAbout_Vrb = new frmAbout() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAbout_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmAbout_Vrb);
            frmAbout_Vrb.Show();
        }

        private void btnBooks_Leave(object sender, EventArgs e)
        {
            btnBooks.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnMembers_Leave(object sender, EventArgs e)
        {
            btnMembers.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnStaff_Leave(object sender, EventArgs e)
        {
            btnStaff.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnLibraryFlow_Leave(object sender, EventArgs e)
        {
            btnLibraryFlow.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAbout_Leave(object sender, EventArgs e)
        {
            btnAbout.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
