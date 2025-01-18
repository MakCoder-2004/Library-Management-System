namespace Library_Management_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel2 = new Panel();
            btnAbout = new Button();
            pnlNav = new Panel();
            btnExit = new Button();
            btnLibraryFlow = new Button();
            btnStaff = new Button();
            btnMembers = new Button();
            btnBooks = new Button();
            panel1 = new Panel();
            label2 = new Label();
            lblAdminPanel = new Label();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            pnlFormLoader = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(24, 30, 54);
            panel2.Controls.Add(btnAbout);
            panel2.Controls.Add(pnlNav);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnLibraryFlow);
            panel2.Controls.Add(btnStaff);
            panel2.Controls.Add(btnMembers);
            panel2.Controls.Add(btnBooks);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 577);
            panel2.TabIndex = 1;
            // 
            // btnAbout
            // 
            btnAbout.Dock = DockStyle.Top;
            btnAbout.FlatAppearance.BorderSize = 0;
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAbout.ForeColor = Color.FromArgb(0, 126, 249);
            btnAbout.Image = (Image)resources.GetObject("btnAbout.Image");
            btnAbout.Location = new Point(0, 437);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(186, 69);
            btnAbout.TabIndex = 3;
            btnAbout.Text = "About";
            btnAbout.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            btnAbout.Leave += btnAbout_Leave;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.FromArgb(0, 126, 249);
            pnlNav.Location = new Point(0, 193);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(3, 100);
            pnlNav.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(0, 126, 249);
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(0, 528);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(186, 49);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnLibraryFlow
            // 
            btnLibraryFlow.Dock = DockStyle.Top;
            btnLibraryFlow.FlatAppearance.BorderSize = 0;
            btnLibraryFlow.FlatStyle = FlatStyle.Flat;
            btnLibraryFlow.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLibraryFlow.ForeColor = Color.FromArgb(0, 126, 249);
            btnLibraryFlow.Image = (Image)resources.GetObject("btnLibraryFlow.Image");
            btnLibraryFlow.Location = new Point(0, 368);
            btnLibraryFlow.Name = "btnLibraryFlow";
            btnLibraryFlow.Size = new Size(186, 69);
            btnLibraryFlow.TabIndex = 1;
            btnLibraryFlow.Text = "Library Flow";
            btnLibraryFlow.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLibraryFlow.UseVisualStyleBackColor = true;
            btnLibraryFlow.Click += btnLibraryFlow_Click;
            btnLibraryFlow.Leave += btnLibraryFlow_Leave;
            // 
            // btnStaff
            // 
            btnStaff.Dock = DockStyle.Top;
            btnStaff.FlatAppearance.BorderSize = 0;
            btnStaff.FlatStyle = FlatStyle.Flat;
            btnStaff.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStaff.ForeColor = Color.FromArgb(0, 126, 249);
            btnStaff.Image = (Image)resources.GetObject("btnStaff.Image");
            btnStaff.Location = new Point(0, 299);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(186, 69);
            btnStaff.TabIndex = 1;
            btnStaff.Text = "Staff";
            btnStaff.TextImageRelation = TextImageRelation.ImageAboveText;
            btnStaff.UseVisualStyleBackColor = true;
            btnStaff.Click += btnStaff_Click;
            btnStaff.Leave += btnStaff_Leave;
            // 
            // btnMembers
            // 
            btnMembers.Dock = DockStyle.Top;
            btnMembers.FlatAppearance.BorderSize = 0;
            btnMembers.FlatStyle = FlatStyle.Flat;
            btnMembers.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMembers.ForeColor = Color.FromArgb(0, 126, 249);
            btnMembers.Image = (Image)resources.GetObject("btnMembers.Image");
            btnMembers.Location = new Point(0, 230);
            btnMembers.Name = "btnMembers";
            btnMembers.Size = new Size(186, 69);
            btnMembers.TabIndex = 1;
            btnMembers.Text = "Members";
            btnMembers.TextImageRelation = TextImageRelation.ImageAboveText;
            btnMembers.UseVisualStyleBackColor = true;
            btnMembers.Click += btnMembers_Click;
            btnMembers.Leave += btnMembers_Leave;
            // 
            // btnBooks
            // 
            btnBooks.Dock = DockStyle.Top;
            btnBooks.FlatAppearance.BorderSize = 0;
            btnBooks.FlatStyle = FlatStyle.Flat;
            btnBooks.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooks.ForeColor = Color.FromArgb(0, 126, 249);
            btnBooks.Image = (Image)resources.GetObject("btnBooks.Image");
            btnBooks.Location = new Point(0, 161);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(186, 69);
            btnBooks.TabIndex = 1;
            btnBooks.Text = "Books";
            btnBooks.TextImageRelation = TextImageRelation.ImageAboveText;
            btnBooks.UseVisualStyleBackColor = true;
            btnBooks.Click += btnBooks_Click;
            btnBooks.Leave += btnBooks_Leave;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblAdminPanel);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 161);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(158, 161, 176);
            label2.Location = new Point(31, 127);
            label2.Name = "label2";
            label2.Size = new Size(120, 16);
            label2.TabIndex = 2;
            label2.Text = "Library Manager";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblAdminPanel
            // 
            lblAdminPanel.AutoSize = true;
            lblAdminPanel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdminPanel.ForeColor = Color.FromArgb(0, 126, 249);
            lblAdminPanel.Location = new Point(29, 104);
            lblAdminPanel.Name = "lblAdminPanel";
            lblAdminPanel.Size = new Size(124, 20);
            lblAdminPanel.TabIndex = 1;
            lblAdminPanel.Text = "Admin Pannel";
            lblAdminPanel.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_8861530;
            pictureBox1.Location = new Point(51, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(158, 161, 176);
            lblTitle.Location = new Point(216, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(159, 54);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Books";
            // 
            // pnlFormLoader
            // 
            pnlFormLoader.Dock = DockStyle.Bottom;
            pnlFormLoader.Location = new Point(186, 100);
            pnlFormLoader.Name = "pnlFormLoader";
            pnlFormLoader.Size = new Size(765, 477);
            pnlFormLoader.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(951, 577);
            Controls.Add(pnlFormLoader);
            Controls.Add(lblTitle);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblAdminPanel;
        private Label label2;
        private Button btnBooks;
        private Button btnLibraryFlow;
        private Button btnStaff;
        private Button btnMembers;
        private Button btnExit;
        private Panel pnlNav;
        private Button btnAbout;
        private Label lblTitle;
        private Button button2;
        private Panel pnlFormLoader;
    }
}
