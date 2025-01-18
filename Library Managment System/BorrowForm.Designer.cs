namespace Library_Management_System
{
    partial class BorrowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowForm));
            btnBorrow = new Button();
            txtMemberSSN = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            txtBookID = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnBorrow
            // 
            btnBorrow.BackColor = Color.FromArgb(0, 126, 249);
            btnBorrow.FlatAppearance.BorderSize = 0;
            btnBorrow.FlatStyle = FlatStyle.Flat;
            btnBorrow.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrow.ForeColor = Color.White;
            btnBorrow.Location = new Point(207, 301);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(138, 38);
            btnBorrow.TabIndex = 38;
            btnBorrow.Text = "Borrow";
            btnBorrow.UseVisualStyleBackColor = false;
            btnBorrow.UseWaitCursor = true;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // txtMemberSSN
            // 
            txtMemberSSN.Location = new Point(158, 157);
            txtMemberSSN.Name = "txtMemberSSN";
            txtMemberSSN.Size = new Size(249, 27);
            txtMemberSSN.TabIndex = 29;
            txtMemberSSN.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(99, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(207, 119);
            label2.Name = "label2";
            label2.Size = new Size(138, 22);
            label2.TabIndex = 21;
            label2.Text = "Member SSN :";
            label2.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(158, 29);
            label1.Name = "label1";
            label1.Size = new Size(296, 52);
            label1.TabIndex = 20;
            label1.Text = " Borrow Book";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseWaitCursor = true;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(158, 245);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(249, 27);
            txtBookID.TabIndex = 40;
            txtBookID.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(235, 210);
            label3.Name = "label3";
            label3.Size = new Size(92, 22);
            label3.TabIndex = 39;
            label3.Text = "Book ID :";
            label3.UseWaitCursor = true;
            // 
            // BorrowForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(560, 381);
            Controls.Add(txtBookID);
            Controls.Add(label3);
            Controls.Add(btnBorrow);
            Controls.Add(txtMemberSSN);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BorrowForm";
            Text = "BorrowForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBorrow;
        private TextBox txtMemberSSN;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private TextBox txtBookID;
        private Label label3;
    }
}