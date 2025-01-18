namespace Library_Management_System
{
    partial class BorrowingHistoryForm
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
            dataGridBorrowingHistory = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridBorrowingHistory).BeginInit();
            SuspendLayout();
            // 
            // dataGridBorrowingHistory
            // 
            dataGridBorrowingHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridBorrowingHistory.Location = new Point(0, 0);
            dataGridBorrowingHistory.Name = "dataGridBorrowingHistory";
            dataGridBorrowingHistory.RowHeadersWidth = 51;
            dataGridBorrowingHistory.Size = new Size(803, 451);
            dataGridBorrowingHistory.TabIndex = 0;
            // 
            // BorrowingHistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridBorrowingHistory);
            Name = "BorrowingHistoryForm";
            Text = "BorrowingHistoryForm";
            ((System.ComponentModel.ISupportInitialize)dataGridBorrowingHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridBorrowingHistory;
    }
}