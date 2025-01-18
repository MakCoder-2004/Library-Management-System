namespace Library_Management_System
{
    partial class frmMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMembers));
            btnAllMembers = new Button();
            panel3 = new Panel();
            label4 = new Label();
            SearchMember = new Button();
            textSearch = new TextBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            btnAddMember = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnAllMembers
            // 
            btnAllMembers.BackColor = Color.FromArgb(37, 42, 64);
            btnAllMembers.FlatAppearance.BorderSize = 0;
            btnAllMembers.FlatStyle = FlatStyle.Flat;
            btnAllMembers.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAllMembers.ForeColor = Color.White;
            btnAllMembers.Image = (Image)resources.GetObject("btnAllMembers.Image");
            btnAllMembers.Location = new Point(86, 17);
            btnAllMembers.Name = "btnAllMembers";
            btnAllMembers.Size = new Size(560, 55);
            btnAllMembers.TabIndex = 16;
            btnAllMembers.Text = " See All Members";
            btnAllMembers.TextAlign = ContentAlignment.MiddleRight;
            btnAllMembers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAllMembers.UseVisualStyleBackColor = false;
            btnAllMembers.Click += btnAllMembers_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(37, 42, 64);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(SearchMember);
            panel3.Controls.Add(textSearch);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(86, 210);
            panel3.Name = "panel3";
            panel3.Size = new Size(560, 250);
            panel3.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(158, 161, 176);
            label4.Location = new Point(217, 93);
            label4.Name = "label4";
            label4.Size = new Size(114, 25);
            label4.TabIndex = 4;
            label4.Text = "Search by ID";
            // 
            // SearchMember
            // 
            SearchMember.BackColor = Color.FromArgb(0, 126, 249);
            SearchMember.FlatAppearance.BorderSize = 0;
            SearchMember.FlatStyle = FlatStyle.Flat;
            SearchMember.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchMember.ForeColor = Color.White;
            SearchMember.Location = new Point(217, 182);
            SearchMember.Name = "SearchMember";
            SearchMember.Size = new Size(95, 38);
            SearchMember.TabIndex = 3;
            SearchMember.Text = "Search";
            SearchMember.UseVisualStyleBackColor = false;
            SearchMember.Click += SearchMember_Click;
            // 
            // textSearch
            // 
            textSearch.BackColor = Color.FromArgb(74, 79, 99);
            textSearch.BorderStyle = BorderStyle.None;
            textSearch.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textSearch.ForeColor = SystemColors.ScrollBar;
            textSearch.Location = new Point(124, 136);
            textSearch.Multiline = true;
            textSearch.Name = "textSearch";
            textSearch.PlaceholderText = "Search For Member.....";
            textSearch.Size = new Size(310, 29);
            textSearch.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI Semilight", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(147, 27);
            label3.Name = "label3";
            label3.Size = new Size(332, 46);
            label3.TabIndex = 0;
            label3.Text = "Search For a Member";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(59, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(124, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // btnAddMember
            // 
            btnAddMember.BackColor = Color.FromArgb(37, 42, 64);
            btnAddMember.BackgroundImageLayout = ImageLayout.Center;
            btnAddMember.FlatAppearance.BorderSize = 0;
            btnAddMember.FlatStyle = FlatStyle.Flat;
            btnAddMember.Font = new Font("Nirmala UI Semilight", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddMember.ForeColor = Color.WhiteSmoke;
            btnAddMember.Image = (Image)resources.GetObject("btnAddMember.Image");
            btnAddMember.Location = new Point(86, 85);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.RightToLeft = RightToLeft.No;
            btnAddMember.Size = new Size(560, 113);
            btnAddMember.TabIndex = 14;
            btnAddMember.Text = "Add New Member";
            btnAddMember.TextAlign = ContentAlignment.BottomCenter;
            btnAddMember.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAddMember.UseVisualStyleBackColor = false;
            btnAddMember.Click += btnAddMember_Click;
            // 
            // frmMembers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(733, 477);
            Controls.Add(btnAllMembers);
            Controls.Add(panel3);
            Controls.Add(btnAddMember);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMembers";
            Text = "frmMembers";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAllMembers;
        private Panel panel3;
        private Label label4;
        private Button SearchMember;
        private TextBox textSearch;
        private Label label3;
        private PictureBox pictureBox2;
        private Button btnAddMember;
    }
}