namespace Library_Management_System
{
    partial class frmViewStaff
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
            dataGridStaff = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridStaff).BeginInit();
            SuspendLayout();
            // 
            // dataGridStaff
            // 
            dataGridStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridStaff.Location = new Point(7, 9);
            dataGridStaff.Name = "dataGridStaff";
            dataGridStaff.RowHeadersWidth = 51;
            dataGridStaff.Size = new Size(786, 433);
            dataGridStaff.TabIndex = 1;
            // 
            // frmViewStaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridStaff);
            Name = "frmViewStaff";
            Text = "frmViewStaff";
            ((System.ComponentModel.ISupportInitialize)dataGridStaff).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridStaff;
    }
}