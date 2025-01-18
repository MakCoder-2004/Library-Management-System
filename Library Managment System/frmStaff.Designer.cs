namespace Library_Management_System
{
    partial class frmStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaff));
            btnAllStaff = new Button();
            panel3 = new Panel();
            label4 = new Label();
            SearchEmployee = new Button();
            textSearchStaff = new TextBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            btnAddEmployee = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnAllStaff
            // 
            btnAllStaff.BackColor = Color.FromArgb(37, 42, 64);
            btnAllStaff.FlatAppearance.BorderSize = 0;
            btnAllStaff.FlatStyle = FlatStyle.Flat;
            btnAllStaff.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAllStaff.ForeColor = Color.White;
            btnAllStaff.Image = (Image)resources.GetObject("btnAllStaff.Image");
            btnAllStaff.Location = new Point(86, 17);
            btnAllStaff.Name = "btnAllStaff";
            btnAllStaff.Size = new Size(560, 55);
            btnAllStaff.TabIndex = 12;
            btnAllStaff.Text = " See All Staff";
            btnAllStaff.TextAlign = ContentAlignment.MiddleRight;
            btnAllStaff.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAllStaff.UseVisualStyleBackColor = false;
            btnAllStaff.Click += btnAllStaff_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(37, 42, 64);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(SearchEmployee);
            panel3.Controls.Add(textSearchStaff);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(86, 210);
            panel3.Name = "panel3";
            panel3.Size = new Size(560, 250);
            panel3.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(158, 161, 176);
            label4.Location = new Point(217, 91);
            label4.Name = "label4";
            label4.Size = new Size(114, 25);
            label4.TabIndex = 4;
            label4.Text = "Search by ID";
            // 
            // SearchEmployee
            // 
            SearchEmployee.BackColor = Color.FromArgb(0, 126, 249);
            SearchEmployee.FlatAppearance.BorderSize = 0;
            SearchEmployee.FlatStyle = FlatStyle.Flat;
            SearchEmployee.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchEmployee.ForeColor = Color.White;
            SearchEmployee.Location = new Point(217, 183);
            SearchEmployee.Name = "SearchEmployee";
            SearchEmployee.Size = new Size(95, 38);
            SearchEmployee.TabIndex = 3;
            SearchEmployee.Text = "Search";
            SearchEmployee.UseVisualStyleBackColor = false;
            SearchEmployee.Click += SearchEmployee_Click;
            // 
            // textSearchStaff
            // 
            textSearchStaff.BackColor = Color.FromArgb(74, 79, 99);
            textSearchStaff.BorderStyle = BorderStyle.None;
            textSearchStaff.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textSearchStaff.ForeColor = SystemColors.ScrollBar;
            textSearchStaff.Location = new Point(124, 139);
            textSearchStaff.Multiline = true;
            textSearchStaff.Name = "textSearchStaff";
            textSearchStaff.PlaceholderText = "Search for Employee.....";
            textSearchStaff.Size = new Size(310, 29);
            textSearchStaff.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI Semilight", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(125, 27);
            label3.Name = "label3";
            label3.Size = new Size(370, 46);
            label3.TabIndex = 0;
            label3.Text = "Search For an Employee";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(37, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(124, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.FromArgb(37, 42, 64);
            btnAddEmployee.BackgroundImageLayout = ImageLayout.Center;
            btnAddEmployee.FlatAppearance.BorderSize = 0;
            btnAddEmployee.FlatStyle = FlatStyle.Flat;
            btnAddEmployee.Font = new Font("Nirmala UI Semilight", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddEmployee.ForeColor = Color.WhiteSmoke;
            btnAddEmployee.Image = (Image)resources.GetObject("btnAddEmployee.Image");
            btnAddEmployee.Location = new Point(86, 85);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.RightToLeft = RightToLeft.No;
            btnAddEmployee.Size = new Size(560, 113);
            btnAddEmployee.TabIndex = 10;
            btnAddEmployee.Text = "Add New Employee";
            btnAddEmployee.TextAlign = ContentAlignment.BottomCenter;
            btnAddEmployee.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAddEmployee.UseVisualStyleBackColor = false;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // frmStaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(733, 477);
            Controls.Add(btnAllStaff);
            Controls.Add(panel3);
            Controls.Add(btnAddEmployee);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmStaff";
            Text = "frmStaff";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label4;
        private Button SearchEmployee;
        private TextBox SearchTB;
        private Label label3;
        private PictureBox pictureBox2;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnAllStaff;
        private Button btnAddEmployee;
        private TextBox textSearchStaff;
    }
}