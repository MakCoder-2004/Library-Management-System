namespace Library_Management_System
{
    partial class frmLibraryFlow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLibraryFlow));
            btnReturnBorrowed = new Button();
            btnBorrow = new Button();
            btnBorrowingHistory = new Button();
            btnInLibraryUse = new Button();
            btnBuy = new Button();
            btnBuyHistory = new Button();
            SuspendLayout();
            // 
            // btnReturnBorrowed
            // 
            btnReturnBorrowed.BackColor = Color.FromArgb(37, 42, 64);
            btnReturnBorrowed.BackgroundImageLayout = ImageLayout.Center;
            btnReturnBorrowed.FlatAppearance.BorderSize = 0;
            btnReturnBorrowed.FlatStyle = FlatStyle.Flat;
            btnReturnBorrowed.Font = new Font("Nirmala UI Semilight", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReturnBorrowed.ForeColor = Color.WhiteSmoke;
            btnReturnBorrowed.Image = (Image)resources.GetObject("btnReturnBorrowed.Image");
            btnReturnBorrowed.Location = new Point(388, 91);
            btnReturnBorrowed.Name = "btnReturnBorrowed";
            btnReturnBorrowed.RightToLeft = RightToLeft.No;
            btnReturnBorrowed.Size = new Size(271, 113);
            btnReturnBorrowed.TabIndex = 7;
            btnReturnBorrowed.Text = "Return Borrowed";
            btnReturnBorrowed.TextAlign = ContentAlignment.BottomCenter;
            btnReturnBorrowed.TextImageRelation = TextImageRelation.ImageAboveText;
            btnReturnBorrowed.UseVisualStyleBackColor = false;
            btnReturnBorrowed.Click += btnReturnBorrowed_Click;
            // 
            // btnBorrow
            // 
            btnBorrow.BackColor = Color.FromArgb(37, 42, 64);
            btnBorrow.BackgroundImageLayout = ImageLayout.Center;
            btnBorrow.FlatAppearance.BorderSize = 0;
            btnBorrow.FlatStyle = FlatStyle.Flat;
            btnBorrow.Font = new Font("Nirmala UI Semilight", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBorrow.ForeColor = Color.WhiteSmoke;
            btnBorrow.Image = (Image)resources.GetObject("btnBorrow.Image");
            btnBorrow.Location = new Point(99, 91);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.RightToLeft = RightToLeft.No;
            btnBorrow.Size = new Size(273, 113);
            btnBorrow.TabIndex = 8;
            btnBorrow.Text = "Borrow Book";
            btnBorrow.TextAlign = ContentAlignment.BottomCenter;
            btnBorrow.TextImageRelation = TextImageRelation.ImageAboveText;
            btnBorrow.UseVisualStyleBackColor = false;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // btnBorrowingHistory
            // 
            btnBorrowingHistory.BackColor = Color.FromArgb(37, 42, 64);
            btnBorrowingHistory.FlatAppearance.BorderSize = 0;
            btnBorrowingHistory.FlatStyle = FlatStyle.Flat;
            btnBorrowingHistory.Font = new Font("Nirmala UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBorrowingHistory.ForeColor = Color.White;
            btnBorrowingHistory.Image = (Image)resources.GetObject("btnBorrowingHistory.Image");
            btnBorrowingHistory.Location = new Point(99, 22);
            btnBorrowingHistory.Name = "btnBorrowingHistory";
            btnBorrowingHistory.Size = new Size(560, 55);
            btnBorrowingHistory.TabIndex = 9;
            btnBorrowingHistory.Text = "  Borrowing History";
            btnBorrowingHistory.TextAlign = ContentAlignment.MiddleRight;
            btnBorrowingHistory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBorrowingHistory.UseVisualStyleBackColor = false;
            btnBorrowingHistory.Click += btnBorrowingHistory_Click;
            // 
            // btnInLibraryUse
            // 
            btnInLibraryUse.BackColor = Color.FromArgb(37, 42, 64);
            btnInLibraryUse.FlatAppearance.BorderSize = 0;
            btnInLibraryUse.FlatStyle = FlatStyle.Flat;
            btnInLibraryUse.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInLibraryUse.ForeColor = Color.White;
            btnInLibraryUse.Image = (Image)resources.GetObject("btnInLibraryUse.Image");
            btnInLibraryUse.Location = new Point(99, 219);
            btnInLibraryUse.Name = "btnInLibraryUse";
            btnInLibraryUse.Size = new Size(560, 55);
            btnInLibraryUse.TabIndex = 10;
            btnInLibraryUse.Text = "  Books In Library Use ";
            btnInLibraryUse.TextAlign = ContentAlignment.MiddleRight;
            btnInLibraryUse.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInLibraryUse.UseVisualStyleBackColor = false;
            // 
            // btnBuy
            // 
            btnBuy.BackColor = Color.FromArgb(37, 42, 64);
            btnBuy.BackgroundImageLayout = ImageLayout.Center;
            btnBuy.FlatAppearance.BorderSize = 0;
            btnBuy.FlatStyle = FlatStyle.Flat;
            btnBuy.Font = new Font("Nirmala UI Semilight", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuy.ForeColor = Color.WhiteSmoke;
            btnBuy.Image = (Image)resources.GetObject("btnBuy.Image");
            btnBuy.Location = new Point(99, 290);
            btnBuy.Name = "btnBuy";
            btnBuy.RightToLeft = RightToLeft.No;
            btnBuy.Size = new Size(560, 112);
            btnBuy.TabIndex = 13;
            btnBuy.Text = "Buy Book";
            btnBuy.TextAlign = ContentAlignment.BottomCenter;
            btnBuy.TextImageRelation = TextImageRelation.ImageAboveText;
            btnBuy.UseVisualStyleBackColor = false;
            btnBuy.Click += btnBuy_Click;
            // 
            // btnBuyHistory
            // 
            btnBuyHistory.BackColor = Color.FromArgb(37, 42, 64);
            btnBuyHistory.BackgroundImageLayout = ImageLayout.Center;
            btnBuyHistory.FlatAppearance.BorderSize = 0;
            btnBuyHistory.FlatStyle = FlatStyle.Flat;
            btnBuyHistory.Font = new Font("Nirmala UI Semilight", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuyHistory.ForeColor = Color.WhiteSmoke;
            btnBuyHistory.Image = (Image)resources.GetObject("btnBuyHistory.Image");
            btnBuyHistory.ImageAlign = ContentAlignment.MiddleRight;
            btnBuyHistory.Location = new Point(99, 219);
            btnBuyHistory.Name = "btnBuyHistory";
            btnBuyHistory.RightToLeft = RightToLeft.No;
            btnBuyHistory.Size = new Size(560, 55);
            btnBuyHistory.TabIndex = 14;
            btnBuyHistory.Text = " Buying History";
            btnBuyHistory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuyHistory.UseVisualStyleBackColor = false;
            btnBuyHistory.Click += btnBuyHistory_Click;
            // 
            // frmLibraryFlow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(748, 430);
            Controls.Add(btnBuyHistory);
            Controls.Add(btnBuy);
            Controls.Add(btnInLibraryUse);
            Controls.Add(btnBorrowingHistory);
            Controls.Add(btnReturnBorrowed);
            Controls.Add(btnBorrow);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLibraryFlow";
            Text = "frmLibraryFlow";
            ResumeLayout(false);
        }

        #endregion

        private Button btnReturnBorrowed;
        private Button btnBorrow;
        private Button btnBorrowingHistory;
        private Button btnInLibraryUse;
        private Button btnBuy;
        private Button btnBuyHistory;
    }
}