namespace Library_Management_System
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnGitHub = new Button();
            btnLinkedin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(106, 22);
            label1.Name = "label1";
            label1.Size = new Size(476, 46);
            label1.TabIndex = 0;
            label1.Text = "Library Management System";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ScrollBar;
            label2.Location = new Point(43, 145);
            label2.Name = "label2";
            label2.Size = new Size(641, 125);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ScrollBar;
            label3.Location = new Point(43, 96);
            label3.Name = "label3";
            label3.Size = new Size(196, 36);
            label3.TabIndex = 2;
            label3.Text = "Description:-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ScrollBar;
            label4.Location = new Point(152, 296);
            label4.Name = "label4";
            label4.Size = new Size(180, 28);
            label4.TabIndex = 3;
            label4.Text = "For More Projects";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ScrollBar;
            label5.Location = new Point(387, 296);
            label5.Name = "label5";
            label5.Size = new Size(106, 28);
            label5.TabIndex = 4;
            label5.Text = "About Me";
            // 
            // btnGitHub
            // 
            btnGitHub.BackColor = Color.FromArgb(0, 126, 249);
            btnGitHub.FlatAppearance.BorderSize = 0;
            btnGitHub.FlatStyle = FlatStyle.Flat;
            btnGitHub.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGitHub.ForeColor = Color.White;
            btnGitHub.Image = (Image)resources.GetObject("btnGitHub.Image");
            btnGitHub.Location = new Point(172, 332);
            btnGitHub.Name = "btnGitHub";
            btnGitHub.Size = new Size(130, 63);
            btnGitHub.TabIndex = 5;
            btnGitHub.TextImageRelation = TextImageRelation.ImageAboveText;
            btnGitHub.UseVisualStyleBackColor = false;
            btnGitHub.Click += btnGitHub_Click;
            // 
            // btnLinkedin
            // 
            btnLinkedin.BackColor = Color.FromArgb(0, 126, 249);
            btnLinkedin.FlatAppearance.BorderSize = 0;
            btnLinkedin.FlatStyle = FlatStyle.Flat;
            btnLinkedin.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLinkedin.ForeColor = Color.White;
            btnLinkedin.Image = (Image)resources.GetObject("btnLinkedin.Image");
            btnLinkedin.Location = new Point(376, 332);
            btnLinkedin.Name = "btnLinkedin";
            btnLinkedin.Size = new Size(130, 63);
            btnLinkedin.TabIndex = 6;
            btnLinkedin.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLinkedin.UseVisualStyleBackColor = false;
            btnLinkedin.Click += btnLinkedin_Click;
            // 
            // frmAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(715, 430);
            Controls.Add(btnLinkedin);
            Controls.Add(btnGitHub);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAbout";
            Text = "frmAbout";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnGitHub;
        private Button btnLinkedin;
    }
}