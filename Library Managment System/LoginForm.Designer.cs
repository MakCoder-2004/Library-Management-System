namespace Library_Management_System
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label11 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            label7 = new Label();
            label2 = new Label();
            AddBook = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ButtonFace;
            label11.Location = new Point(250, 48);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(259, 52);
            label11.TabIndex = 110;
            label11.Text = "Login Menu";
            label11.TextAlign = ContentAlignment.TopCenter;
            label11.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(162, 40);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 111;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ScrollBar;
            label4.Location = new Point(200, 107);
            label4.Name = "label4";
            label4.Size = new Size(284, 28);
            label4.TabIndex = 112;
            label4.Text = "Library Management System";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(398, 216);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(249, 27);
            txtPassword.TabIndex = 116;
            txtPassword.UseWaitCursor = true;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(100, 216);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(249, 27);
            txtUserName.TabIndex = 115;
            txtUserName.UseWaitCursor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Snow;
            label7.Location = new Point(398, 182);
            label7.Name = "label7";
            label7.Size = new Size(109, 22);
            label7.TabIndex = 114;
            label7.Text = "Password :";
            label7.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(100, 182);
            label2.Name = "label2";
            label2.Size = new Size(115, 22);
            label2.TabIndex = 113;
            label2.Text = "UserName :";
            label2.UseWaitCursor = true;
            // 
            // AddBook
            // 
            AddBook.BackColor = Color.FromArgb(0, 126, 249);
            AddBook.FlatAppearance.BorderSize = 0;
            AddBook.FlatStyle = FlatStyle.Flat;
            AddBook.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBook.ForeColor = Color.White;
            AddBook.Location = new Point(287, 283);
            AddBook.Name = "AddBook";
            AddBook.Size = new Size(145, 38);
            AddBook.TabIndex = 117;
            AddBook.Text = "Log In";
            AddBook.UseVisualStyleBackColor = false;
            AddBook.UseWaitCursor = true;
            AddBook.Click += AddBook_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(729, 368);
            Controls.Add(AddBook);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label11);
            Controls.Add(pictureBox1);
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private PictureBox pictureBox1;
        private Label label4;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label label7;
        private Label label2;
        private Button AddBook;
    }
}