namespace Library_Management_System
{
    partial class BookDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookDetailsForm));
            buttonDone = new Button();
            buttonDelete = new Button();
            buttonEdit = new Button();
            txtPrice = new TextBox();
            txtCategory = new TextBox();
            txtISBN = new TextBox();
            txtAuthor = new TextBox();
            txtAmount = new TextBox();
            txtLocation = new TextBox();
            txtPublisher = new TextBox();
            txtName = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.FromArgb(0, 126, 249);
            buttonDone.FlatAppearance.BorderSize = 0;
            buttonDone.FlatStyle = FlatStyle.Flat;
            buttonDone.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            buttonDone.ForeColor = Color.White;
            buttonDone.Location = new Point(358, 342);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(94, 29);
            buttonDone.TabIndex = 85;
            buttonDone.Text = "Done";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Visible = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(0, 126, 249);
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            buttonDelete.ForeColor = SystemColors.ButtonFace;
            buttonDelete.Location = new Point(673, 381);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 84;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.FromArgb(0, 126, 249);
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            buttonEdit.ForeColor = SystemColors.ButtonFace;
            buttonEdit.Location = new Point(561, 381);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(94, 29);
            buttonEdit.TabIndex = 83;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click_1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(525, 287);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(238, 27);
            txtPrice.TabIndex = 81;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(525, 228);
            txtCategory.Name = "txtCategory";
            txtCategory.ReadOnly = true;
            txtCategory.Size = new Size(238, 27);
            txtCategory.TabIndex = 80;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(525, 176);
            txtISBN.Name = "txtISBN";
            txtISBN.ReadOnly = true;
            txtISBN.Size = new Size(238, 27);
            txtISBN.TabIndex = 79;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(525, 126);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.ReadOnly = true;
            txtAuthor.Size = new Size(238, 27);
            txtAuthor.TabIndex = 78;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(159, 280);
            txtAmount.Name = "txtAmount";
            txtAmount.ReadOnly = true;
            txtAmount.Size = new Size(218, 27);
            txtAmount.TabIndex = 77;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(159, 225);
            txtLocation.Name = "txtLocation";
            txtLocation.ReadOnly = true;
            txtLocation.Size = new Size(218, 27);
            txtLocation.TabIndex = 76;
            // 
            // txtPublisher
            // 
            txtPublisher.Location = new Point(159, 173);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.ReadOnly = true;
            txtPublisher.Size = new Size(218, 27);
            txtPublisher.TabIndex = 75;
            // 
            // txtName
            // 
            txtName.Location = new Point(159, 123);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(218, 27);
            txtName.TabIndex = 74;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(421, 280);
            label9.Name = "label9";
            label9.Size = new Size(59, 28);
            label9.TabIndex = 72;
            label9.Text = "Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(421, 228);
            label8.Name = "label8";
            label8.Size = new Size(98, 28);
            label8.TabIndex = 71;
            label8.Text = "Category";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(422, 173);
            label7.Name = "label7";
            label7.Size = new Size(58, 28);
            label7.TabIndex = 70;
            label7.Text = "ISBN";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(422, 123);
            label6.Name = "label6";
            label6.Size = new Size(78, 28);
            label6.TabIndex = 69;
            label6.Text = "Author";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(36, 276);
            label5.Name = "label5";
            label5.Size = new Size(88, 28);
            label5.TabIndex = 68;
            label5.Text = "Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(36, 224);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 67;
            label3.Text = "Location";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(31, 169);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 66;
            label2.Text = "Publisher";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(31, 122);
            label1.Name = "label1";
            label1.Size = new Size(122, 28);
            label1.TabIndex = 65;
            label1.Text = "Book Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(277, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 87;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(336, 29);
            label4.Name = "label4";
            label4.Size = new Size(214, 52);
            label4.TabIndex = 86;
            label4.Text = "Book Info";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.UseWaitCursor = true;
            // 
            // BookDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(800, 433);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(buttonDone);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(txtPrice);
            Controls.Add(txtCategory);
            Controls.Add(txtISBN);
            Controls.Add(txtAuthor);
            Controls.Add(txtAmount);
            Controls.Add(txtLocation);
            Controls.Add(txtPublisher);
            Controls.Add(txtName);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BookDetailsForm";
            Text = "`";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDone;
        private Button buttonDelete;
        private Button buttonEdit;
        private TextBox txtPrice;
        private TextBox txtCategory;
        private TextBox txtISBN;
        private TextBox txtAuthor;
        private TextBox txtAmount;
        private TextBox txtLocation;
        private TextBox txtPublisher;
        private TextBox txtName;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label4;
    }
}