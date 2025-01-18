namespace Library_Management_System
{
    partial class BuyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyForm));
            txtCustomerName = new TextBox();
            label3 = new Label();
            AddBook = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtBookID = new TextBox();
            label2 = new Label();
            txtCustomerContact = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(44, 144);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(249, 27);
            txtCustomerName.TabIndex = 47;
            txtCustomerName.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(81, 109);
            label3.Name = "label3";
            label3.Size = new Size(164, 22);
            label3.TabIndex = 46;
            label3.Text = "Customer Name :";
            label3.UseWaitCursor = true;
            // 
            // AddBook
            // 
            AddBook.BackColor = Color.FromArgb(0, 126, 249);
            AddBook.FlatAppearance.BorderSize = 0;
            AddBook.FlatStyle = FlatStyle.Flat;
            AddBook.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBook.ForeColor = Color.White;
            AddBook.Location = new Point(239, 289);
            AddBook.Name = "AddBook";
            AddBook.Size = new Size(138, 38);
            AddBook.TabIndex = 45;
            AddBook.Text = "Buy";
            AddBook.UseVisualStyleBackColor = false;
            AddBook.UseWaitCursor = true;
            AddBook.Click += AddBook_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(165, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(224, 36);
            label1.Name = "label1";
            label1.Size = new Size(216, 52);
            label1.TabIndex = 41;
            label1.Text = "Buy Book";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseWaitCursor = true;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(178, 233);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(249, 27);
            txtBookID.TabIndex = 49;
            txtBookID.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(257, 199);
            label2.Name = "label2";
            label2.Size = new Size(92, 22);
            label2.TabIndex = 48;
            label2.Text = "Book ID :";
            label2.UseWaitCursor = true;
            // 
            // txtCustomerContact
            // 
            txtCustomerContact.Location = new Point(322, 146);
            txtCustomerContact.Name = "txtCustomerContact";
            txtCustomerContact.Size = new Size(249, 27);
            txtCustomerContact.TabIndex = 51;
            txtCustomerContact.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(359, 109);
            label4.Name = "label4";
            label4.Size = new Size(182, 22);
            label4.TabIndex = 50;
            label4.Text = "Customer Contact :";
            label4.UseWaitCursor = true;
            // 
            // BuyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(621, 358);
            Controls.Add(txtCustomerContact);
            Controls.Add(label4);
            Controls.Add(txtBookID);
            Controls.Add(label2);
            Controls.Add(txtCustomerName);
            Controls.Add(label3);
            Controls.Add(AddBook);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "BuyForm";
            Text = "BuyForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCustomerName;
        private Label label3;
        private Button AddBook;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtBookID;
        private Label label2;
        private TextBox txtCustomerContact;
        private Label label4;
    }
}