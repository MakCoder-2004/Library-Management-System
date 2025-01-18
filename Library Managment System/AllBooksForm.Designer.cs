namespace Library_Management_System
{
    partial class AllBooksForm
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
            dataGridBooks = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridBooks).BeginInit();
            SuspendLayout();
            // 
            // dataGridBooks
            // 
            dataGridBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridBooks.Location = new Point(0, 1);
            dataGridBooks.Name = "dataGridBooks";
            dataGridBooks.RowHeadersWidth = 51;
            dataGridBooks.Size = new Size(800, 449);
            dataGridBooks.TabIndex = 0;
            // 
            // AllBooksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridBooks);
            Name = "AllBooksForm";
            Text = "AllBooksForm";
            ((System.ComponentModel.ISupportInitialize)dataGridBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridBooks;
    }
}