namespace Library_Management_System
{
    partial class BuyingHistoryForm
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
            dataGridBuyingHistory = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridBuyingHistory).BeginInit();
            SuspendLayout();
            // 
            // dataGridBuyingHistory
            // 
            dataGridBuyingHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridBuyingHistory.Location = new Point(-2, -4);
            dataGridBuyingHistory.Name = "dataGridBuyingHistory";
            dataGridBuyingHistory.RowHeadersWidth = 51;
            dataGridBuyingHistory.Size = new Size(804, 457);
            dataGridBuyingHistory.TabIndex = 0;
            // 
            // BuyingHistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridBuyingHistory);
            Name = "BuyingHistoryForm";
            Text = "BuyingHistoryForm";
            ((System.ComponentModel.ISupportInitialize)dataGridBuyingHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridBuyingHistory;
    }
}