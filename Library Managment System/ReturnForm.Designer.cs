namespace Library_Management_System
{
    partial class ReturnForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnForm));
            txtFineAmount = new TextBox();
            label3 = new Label();
            AddBook = new Button();
            txtBorrowID = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            rbtnBoth = new RadioButton();
            radioButton2 = new RadioButton();
            label4 = new Label();
            rbtnLate = new RadioButton();
            rbtnDamage = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtFineAmount
            // 
            txtFineAmount.Location = new Point(62, 249);
            txtFineAmount.Name = "txtFineAmount";
            txtFineAmount.Size = new Size(249, 27);
            txtFineAmount.TabIndex = 47;
            txtFineAmount.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(115, 217);
            label3.Name = "label3";
            label3.Size = new Size(134, 22);
            label3.TabIndex = 46;
            label3.Text = "Fine Amount :";
            label3.UseWaitCursor = true;
            // 
            // AddBook
            // 
            AddBook.BackColor = Color.FromArgb(0, 126, 249);
            AddBook.FlatAppearance.BorderSize = 0;
            AddBook.FlatStyle = FlatStyle.Flat;
            AddBook.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBook.ForeColor = Color.White;
            AddBook.Location = new Point(223, 330);
            AddBook.Name = "AddBook";
            AddBook.Size = new Size(138, 38);
            AddBook.TabIndex = 45;
            AddBook.Text = "Return";
            AddBook.UseVisualStyleBackColor = false;
            AddBook.UseWaitCursor = true;
            AddBook.Click += AddBook_Click;
            // 
            // txtBorrowID
            // 
            txtBorrowID.Location = new Point(62, 173);
            txtBorrowID.Name = "txtBorrowID";
            txtBorrowID.Size = new Size(249, 27);
            txtBorrowID.TabIndex = 44;
            txtBorrowID.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(98, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(126, 140);
            label2.Name = "label2";
            label2.Size = new Size(104, 22);
            label2.TabIndex = 42;
            label2.Text = "Borrow ID:";
            label2.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(157, 39);
            label1.Name = "label1";
            label1.Size = new Size(288, 52);
            label1.TabIndex = 41;
            label1.Text = " Return Book";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseWaitCursor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(rbtnBoth);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(rbtnLate);
            panel1.Controls.Add(rbtnDamage);
            panel1.Location = new Point(345, 125);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 181);
            panel1.TabIndex = 48;
            // 
            // rbtnBoth
            // 
            rbtnBoth.AutoSize = true;
            rbtnBoth.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold);
            rbtnBoth.ForeColor = SystemColors.ButtonFace;
            rbtnBoth.Location = new Point(21, 139);
            rbtnBoth.Name = "rbtnBoth";
            rbtnBoth.Size = new Size(79, 29);
            rbtnBoth.TabIndex = 1;
            rbtnBoth.TabStop = true;
            rbtnBoth.Text = "None";
            rbtnBoth.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold);
            radioButton2.ForeColor = SystemColors.ButtonFace;
            radioButton2.Location = new Point(21, 111);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(74, 29);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Both";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(21, 15);
            label4.Name = "label4";
            label4.Size = new Size(148, 22);
            label4.TabIndex = 46;
            label4.Text = "- Fine Reason :";
            label4.UseWaitCursor = true;
            // 
            // rbtnLate
            // 
            rbtnLate.AutoSize = true;
            rbtnLate.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold);
            rbtnLate.ForeColor = SystemColors.ButtonFace;
            rbtnLate.Location = new Point(21, 51);
            rbtnLate.Name = "rbtnLate";
            rbtnLate.Size = new Size(69, 29);
            rbtnLate.TabIndex = 0;
            rbtnLate.TabStop = true;
            rbtnLate.Text = "Late";
            rbtnLate.UseVisualStyleBackColor = true;
            // 
            // rbtnDamage
            // 
            rbtnDamage.AutoSize = true;
            rbtnDamage.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold);
            rbtnDamage.ForeColor = SystemColors.ButtonFace;
            rbtnDamage.Location = new Point(21, 81);
            rbtnDamage.Name = "rbtnDamage";
            rbtnDamage.Size = new Size(103, 29);
            rbtnDamage.TabIndex = 0;
            rbtnDamage.TabStop = true;
            rbtnDamage.Text = "Damage";
            rbtnDamage.UseVisualStyleBackColor = true;
            // 
            // ReturnForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(575, 402);
            Controls.Add(panel1);
            Controls.Add(txtFineAmount);
            Controls.Add(label3);
            Controls.Add(AddBook);
            Controls.Add(txtBorrowID);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ReturnForm";
            Text = "ReturnForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFineAmount;
        private Label label3;
        private Button AddBook;
        private TextBox txtBorrowID;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private RadioButton rbtnBoth;
        private RadioButton radioButton2;
        private RadioButton rbtnDamage;
        private Label label4;
        private RadioButton rbtnLate;
    }
}