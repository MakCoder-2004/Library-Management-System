namespace Library_Management_System
{
    partial class frmViewMember
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
            dataGridMember = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridMember).BeginInit();
            SuspendLayout();
            // 
            // dataGridMember
            // 
            dataGridMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMember.Location = new Point(2, 5);
            dataGridMember.Name = "dataGridMember";
            dataGridMember.RowHeadersWidth = 51;
            dataGridMember.Size = new Size(786, 433);
            dataGridMember.TabIndex = 0;
            // 
            // frmViewMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridMember);
            Name = "frmViewMember";
            Text = "frmViewMember";
            ((System.ComponentModel.ISupportInitialize)dataGridMember).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridMember;
    }
}