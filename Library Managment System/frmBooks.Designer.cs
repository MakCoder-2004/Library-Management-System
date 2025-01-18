namespace Library_Management_System
{
    partial class frmBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBooks));
            panel3 = new Panel();
            label4 = new Label();
            SearchBook = new Button();
            txtSearch = new TextBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            btnAddBook = new Button();
            btnAllBooks = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(37, 42, 64);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(SearchBook);
            panel3.Controls.Add(txtSearch);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(86, 205);
            panel3.Name = "panel3";
            panel3.Size = new Size(560, 250);
            panel3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(158, 161, 176);
            label4.Location = new Point(88, 99);
            label4.Name = "label4";
            label4.Size = new Size(376, 25);
            label4.TabIndex = 4;
            label4.Text = "Search by Book / Author / Publisher or ISBN";
            // 
            // SearchBook
            // 
            SearchBook.BackColor = Color.FromArgb(0, 126, 249);
            SearchBook.FlatAppearance.BorderSize = 0;
            SearchBook.FlatStyle = FlatStyle.Flat;
            SearchBook.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBook.ForeColor = Color.White;
            SearchBook.Location = new Point(231, 185);
            SearchBook.Name = "SearchBook";
            SearchBook.Size = new Size(95, 38);
            SearchBook.TabIndex = 3;
            SearchBook.Text = "Search";
            SearchBook.UseVisualStyleBackColor = false;
            SearchBook.Click += SearchBook_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(74, 79, 99);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = SystemColors.ScrollBar;
            txtSearch.Location = new Point(124, 139);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search For books.....";
            txtSearch.Size = new Size(310, 29);
            txtSearch.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI Semilight", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(179, 22);
            label3.Name = "label3";
            label3.Size = new Size(255, 46);
            label3.TabIndex = 0;
            label3.Text = "Search For Book";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(91, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(124, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // btnAddBook
            // 
            btnAddBook.BackColor = Color.FromArgb(37, 42, 64);
            btnAddBook.BackgroundImageLayout = ImageLayout.Center;
            btnAddBook.FlatAppearance.BorderSize = 0;
            btnAddBook.FlatStyle = FlatStyle.Flat;
            btnAddBook.Font = new Font("Nirmala UI Semilight", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddBook.ForeColor = Color.WhiteSmoke;
            btnAddBook.Image = (Image)resources.GetObject("btnAddBook.Image");
            btnAddBook.Location = new Point(86, 80);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.RightToLeft = RightToLeft.No;
            btnAddBook.Size = new Size(560, 113);
            btnAddBook.TabIndex = 6;
            btnAddBook.Text = "Add New Book";
            btnAddBook.TextAlign = ContentAlignment.BottomCenter;
            btnAddBook.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnAllBooks
            // 
            btnAllBooks.BackColor = Color.FromArgb(37, 42, 64);
            btnAllBooks.FlatAppearance.BorderSize = 0;
            btnAllBooks.FlatStyle = FlatStyle.Flat;
            btnAllBooks.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAllBooks.ForeColor = Color.White;
            btnAllBooks.Image = (Image)resources.GetObject("btnAllBooks.Image");
            btnAllBooks.Location = new Point(86, 12);
            btnAllBooks.Name = "btnAllBooks";
            btnAllBooks.Size = new Size(560, 55);
            btnAllBooks.TabIndex = 8;
            btnAllBooks.Text = " See All Books";
            btnAllBooks.TextAlign = ContentAlignment.MiddleRight;
            btnAllBooks.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAllBooks.UseVisualStyleBackColor = false;
            btnAllBooks.Click += btnAllBooks_Click;
            // 
            // frmBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(733, 477);
            Controls.Add(btnAllBooks);
            Controls.Add(panel3);
            Controls.Add(btnAddBook);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBooks";
            Text = "frmBooks";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label4;
        private Button SearchBook;
        private TextBox txtSearch;
        private Label label3;
        private PictureBox pictureBox2;
        private Button btnAddBook;
        private Button btnAllBooks;
    }
}