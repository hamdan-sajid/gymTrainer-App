namespace Project_FLEXTrainer.Owner
{
    partial class home_owner
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home_owner));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel2 = new Panel();
            panel1 = new Panel();
            label2 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            label3 = new Label();
            label4 = new Label();
            UserNamePanel = new Panel();
            btnpfp = new Guna.UI2.WinForms.Guna2Button();
            usr_type = new Label();
            lblUsername = new Label();
            pgTitle = new Label();
            label1 = new Label();
            panelMenu = new Panel();
            btnManage = new Button();
            btnAddTrainer = new Button();
            btnTrainerReports = new Button();
            btnMemberReports = new Button();
            btnGymReports = new Button();
            desktopPanel = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            UserNamePanel.SuspendLayout();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(170, 52, 60);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(UserNamePanel);
            panel2.Controls.Add(pgTitle);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1407, 78);
            panel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 72, 76);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(guna2Button1);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1005, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 78);
            panel1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(85, 45);
            label2.Name = "label2";
            label2.Size = new Size(167, 15);
            label2.TabIndex = 2;
            label2.Text = "usr_type (member/admin/etc)";
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(50, 72, 76);
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Image = (Image)resources.GetObject("guna2Button1.Image");
            guna2Button1.ImageSize = new Size(50, 50);
            guna2Button1.Location = new Point(3, -5);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Padding = new Padding(5, 0, 5, 5);
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(76, 80);
            guna2Button1.TabIndex = 3;
            guna2Button1.Click += guna2Button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(85, -2);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 15, 0, 0);
            label3.Size = new Size(123, 45);
            label3.TabIndex = 1;
            label3.Text = "USERNAME";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(50, 72, 76);
            label4.Dock = DockStyle.Right;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(1284, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(10, 15, 10, 0);
            label4.Size = new Size(123, 90);
            label4.TabIndex = 10;
            label4.Text = "FLEX \r\nTRAINER\r\n\r\n";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserNamePanel
            // 
            UserNamePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            UserNamePanel.BackColor = Color.FromArgb(50, 72, 76);
            UserNamePanel.Controls.Add(btnpfp);
            UserNamePanel.Controls.Add(usr_type);
            UserNamePanel.Controls.Add(lblUsername);
            UserNamePanel.Location = new Point(1967, 0);
            UserNamePanel.Name = "UserNamePanel";
            UserNamePanel.Size = new Size(279, 67);
            UserNamePanel.TabIndex = 9;
            // 
            // btnpfp
            // 
            btnpfp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnpfp.CustomizableEdges = customizableEdges3;
            btnpfp.DisabledState.BorderColor = Color.DarkGray;
            btnpfp.DisabledState.CustomBorderColor = Color.DarkGray;
            btnpfp.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnpfp.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnpfp.FillColor = Color.FromArgb(50, 72, 76);
            btnpfp.Font = new Font("Segoe UI", 9F);
            btnpfp.ForeColor = Color.White;
            btnpfp.Image = (Image)resources.GetObject("btnpfp.Image");
            btnpfp.ImageSize = new Size(50, 50);
            btnpfp.Location = new Point(79, 0);
            btnpfp.Name = "btnpfp";
            btnpfp.Padding = new Padding(5, 0, 5, 5);
            btnpfp.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnpfp.Size = new Size(76, 80);
            btnpfp.TabIndex = 3;
            // 
            // usr_type
            // 
            usr_type.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            usr_type.AutoSize = true;
            usr_type.ForeColor = Color.White;
            usr_type.Location = new Point(161, 45);
            usr_type.Name = "usr_type";
            usr_type.Size = new Size(167, 15);
            usr_type.TabIndex = 2;
            usr_type.Text = "usr_type (member/admin/etc)";
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(155, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Padding = new Padding(0, 15, 0, 0);
            lblUsername.Size = new Size(123, 45);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "USERNAME";
            // 
            // pgTitle
            // 
            pgTitle.AutoSize = true;
            pgTitle.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pgTitle.ForeColor = Color.White;
            pgTitle.Location = new Point(0, -2);
            pgTitle.Name = "pgTitle";
            pgTitle.Padding = new Padding(10, 20, 0, 0);
            pgTitle.Size = new Size(140, 62);
            pgTitle.TabIndex = 8;
            pgTitle.Text = "HOME";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(50, 72, 76);
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(2243, -16);
            label1.Name = "label1";
            label1.Padding = new Padding(10, 30, 10, 0);
            label1.Size = new Size(123, 105);
            label1.TabIndex = 7;
            label1.Text = "FLEX \r\nTRAINER\r\n\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(50, 72, 76);
            panelMenu.Controls.Add(btnManage);
            panelMenu.Controls.Add(btnAddTrainer);
            panelMenu.Controls.Add(btnTrainerReports);
            panelMenu.Controls.Add(btnMemberReports);
            panelMenu.Controls.Add(btnGymReports);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 78);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(253, 697);
            panelMenu.TabIndex = 2;
            // 
            // btnManage
            // 
            btnManage.BackColor = Color.FromArgb(50, 72, 76);
            btnManage.Dock = DockStyle.Top;
            btnManage.FlatAppearance.BorderSize = 0;
            btnManage.FlatStyle = FlatStyle.Flat;
            btnManage.Font = new Font("Ebrima", 12.25F);
            btnManage.ForeColor = Color.Gainsboro;
            btnManage.Image = (Image)resources.GetObject("btnManage.Image");
            btnManage.ImageAlign = ContentAlignment.MiddleLeft;
            btnManage.Location = new Point(0, 280);
            btnManage.Name = "btnManage";
            btnManage.Padding = new Padding(15, 0, 0, 0);
            btnManage.Size = new Size(253, 70);
            btnManage.TabIndex = 13;
            btnManage.Text = "  Manage Accounts";
            btnManage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnManage.UseVisualStyleBackColor = false;
            btnManage.Click += btnManage_Click;
            // 
            // btnAddTrainer
            // 
            btnAddTrainer.BackColor = Color.FromArgb(50, 72, 76);
            btnAddTrainer.Dock = DockStyle.Top;
            btnAddTrainer.FlatAppearance.BorderSize = 0;
            btnAddTrainer.FlatStyle = FlatStyle.Flat;
            btnAddTrainer.Font = new Font("Ebrima", 12.25F);
            btnAddTrainer.ForeColor = Color.Gainsboro;
            btnAddTrainer.Image = (Image)resources.GetObject("btnAddTrainer.Image");
            btnAddTrainer.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddTrainer.Location = new Point(0, 210);
            btnAddTrainer.Name = "btnAddTrainer";
            btnAddTrainer.Padding = new Padding(15, 0, 0, 0);
            btnAddTrainer.Size = new Size(253, 70);
            btnAddTrainer.TabIndex = 11;
            btnAddTrainer.Text = "  Add Trainer";
            btnAddTrainer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddTrainer.UseVisualStyleBackColor = false;
            btnAddTrainer.Click += btnAddTrainer_Click;
            // 
            // btnTrainerReports
            // 
            btnTrainerReports.BackColor = Color.FromArgb(50, 72, 76);
            btnTrainerReports.Dock = DockStyle.Top;
            btnTrainerReports.FlatAppearance.BorderSize = 0;
            btnTrainerReports.FlatStyle = FlatStyle.Flat;
            btnTrainerReports.Font = new Font("Ebrima", 12.25F);
            btnTrainerReports.ForeColor = Color.Gainsboro;
            btnTrainerReports.Image = (Image)resources.GetObject("btnTrainerReports.Image");
            btnTrainerReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrainerReports.Location = new Point(0, 140);
            btnTrainerReports.Name = "btnTrainerReports";
            btnTrainerReports.Padding = new Padding(12, 0, 0, 0);
            btnTrainerReports.Size = new Size(253, 70);
            btnTrainerReports.TabIndex = 10;
            btnTrainerReports.Text = "  Trainer Reports";
            btnTrainerReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTrainerReports.UseVisualStyleBackColor = false;
            btnTrainerReports.Click += btnTrainerReports_Click;
            // 
            // btnMemberReports
            // 
            btnMemberReports.BackColor = Color.FromArgb(50, 72, 76);
            btnMemberReports.Dock = DockStyle.Top;
            btnMemberReports.FlatAppearance.BorderSize = 0;
            btnMemberReports.FlatStyle = FlatStyle.Flat;
            btnMemberReports.Font = new Font("Ebrima", 12.25F);
            btnMemberReports.ForeColor = Color.Gainsboro;
            btnMemberReports.Image = (Image)resources.GetObject("btnMemberReports.Image");
            btnMemberReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnMemberReports.Location = new Point(0, 70);
            btnMemberReports.Name = "btnMemberReports";
            btnMemberReports.Padding = new Padding(15, 0, 0, 0);
            btnMemberReports.Size = new Size(253, 70);
            btnMemberReports.TabIndex = 9;
            btnMemberReports.Text = "  Member Reports";
            btnMemberReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMemberReports.UseVisualStyleBackColor = false;
            btnMemberReports.Click += btnMemberReports_Click;
            // 
            // btnGymReports
            // 
            btnGymReports.BackColor = Color.FromArgb(50, 72, 76);
            btnGymReports.Dock = DockStyle.Top;
            btnGymReports.FlatAppearance.BorderSize = 0;
            btnGymReports.FlatStyle = FlatStyle.Flat;
            btnGymReports.Font = new Font("Ebrima", 12.25F);
            btnGymReports.ForeColor = Color.Gainsboro;
            btnGymReports.Image = (Image)resources.GetObject("btnGymReports.Image");
            btnGymReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnGymReports.Location = new Point(0, 0);
            btnGymReports.Name = "btnGymReports";
            btnGymReports.Padding = new Padding(15, 0, 0, 0);
            btnGymReports.Size = new Size(253, 70);
            btnGymReports.TabIndex = 8;
            btnGymReports.Text = "  Gym Report";
            btnGymReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGymReports.UseVisualStyleBackColor = false;
            btnGymReports.Click += btnGymReports_Click;
            // 
            // desktopPanel
            // 
            desktopPanel.BackColor = Color.Gainsboro;
            desktopPanel.Dock = DockStyle.Fill;
            desktopPanel.Location = new Point(253, 78);
            desktopPanel.Name = "desktopPanel";
            desktopPanel.Size = new Size(1154, 697);
            desktopPanel.TabIndex = 3;
            // 
            // home_owner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1407, 775);
            Controls.Add(desktopPanel);
            Controls.Add(panelMenu);
            Controls.Add(panel2);
            Name = "home_owner";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            UserNamePanel.ResumeLayout(false);
            UserNamePanel.PerformLayout();
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel UserNamePanel;
        private Guna.UI2.WinForms.Guna2Button btnpfp;
        private Label usr_type;
        private Label lblUsername;
        private Label pgTitle;
        private Label label1;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panelMenu;
        private Button btnAddTrainer;
        private Button btnTrainerReports;
        private Button btnMemberReports;
        private Button btnGymReports;
        private Panel desktopPanel;
        private Button btnManage;
    }
}