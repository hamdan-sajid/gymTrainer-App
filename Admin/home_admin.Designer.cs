namespace Project_FLEXTrainer.Admin
{
    partial class home_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home_admin));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel2 = new Panel();
            panel1 = new Panel();
            label2 = new Label();
            pfpBtn = new Guna.UI2.WinForms.Guna2Button();
            label3 = new Label();
            label4 = new Label();
            UserNamePanel = new Panel();
            btnpfp = new Guna.UI2.WinForms.Guna2Button();
            usr_type = new Label();
            lblUsername = new Label();
            pgTitle = new Label();
            label1 = new Label();
            panelMenu = new Panel();
            btnRevoke = new Button();
            btnReq = new Button();
            btnGymPerf = new Button();
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
            panel2.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 72, 76);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pfpBtn);
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
            // pfpBtn
            // 
            pfpBtn.CustomizableEdges = customizableEdges1;
            pfpBtn.DisabledState.BorderColor = Color.DarkGray;
            pfpBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            pfpBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            pfpBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            pfpBtn.FillColor = Color.FromArgb(50, 72, 76);
            pfpBtn.Font = new Font("Segoe UI", 9F);
            pfpBtn.ForeColor = Color.White;
            pfpBtn.Image = (Image)resources.GetObject("pfpBtn.Image");
            pfpBtn.ImageSize = new Size(50, 50);
            pfpBtn.Location = new Point(3, -5);
            pfpBtn.Name = "pfpBtn";
            pfpBtn.Padding = new Padding(5, 0, 5, 5);
            pfpBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pfpBtn.Size = new Size(76, 80);
            pfpBtn.TabIndex = 3;
            pfpBtn.Click += pfpBtn_Click;
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
            UserNamePanel.Location = new Point(2926, 0);
            UserNamePanel.Name = "UserNamePanel";
            UserNamePanel.Size = new Size(279, 45);
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
            btnpfp.Location = new Point(158, 0);
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
            usr_type.Location = new Point(240, 45);
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
            lblUsername.Location = new Point(234, 0);
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
            label1.Location = new Point(3202, -16);
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
            panelMenu.Controls.Add(btnRevoke);
            panelMenu.Controls.Add(btnReq);
            panelMenu.Controls.Add(btnGymPerf);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 78);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(253, 697);
            panelMenu.TabIndex = 3;
            // 
            // btnRevoke
            // 
            btnRevoke.BackColor = Color.FromArgb(50, 72, 76);
            btnRevoke.Dock = DockStyle.Top;
            btnRevoke.FlatAppearance.BorderSize = 0;
            btnRevoke.FlatStyle = FlatStyle.Flat;
            btnRevoke.Font = new Font("Ebrima", 12.25F);
            btnRevoke.ForeColor = Color.Gainsboro;
            btnRevoke.Image = (Image)resources.GetObject("btnRevoke.Image");
            btnRevoke.ImageAlign = ContentAlignment.MiddleLeft;
            btnRevoke.Location = new Point(0, 140);
            btnRevoke.Name = "btnRevoke";
            btnRevoke.Padding = new Padding(15, 0, 0, 0);
            btnRevoke.Size = new Size(253, 70);
            btnRevoke.TabIndex = 13;
            btnRevoke.Text = "    Revoke Gym";
            btnRevoke.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRevoke.UseVisualStyleBackColor = false;
            btnRevoke.Click += btnRevoke_Click;
            // 
            // btnReq
            // 
            btnReq.BackColor = Color.FromArgb(50, 72, 76);
            btnReq.Dock = DockStyle.Top;
            btnReq.FlatAppearance.BorderSize = 0;
            btnReq.FlatStyle = FlatStyle.Flat;
            btnReq.Font = new Font("Ebrima", 12.25F);
            btnReq.ForeColor = Color.Gainsboro;
            btnReq.Image = (Image)resources.GetObject("btnReq.Image");
            btnReq.ImageAlign = ContentAlignment.MiddleLeft;
            btnReq.Location = new Point(0, 70);
            btnReq.Name = "btnReq";
            btnReq.Padding = new Padding(15, 0, 0, 0);
            btnReq.Size = new Size(253, 70);
            btnReq.TabIndex = 11;
            btnReq.Text = "  Requests";
            btnReq.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReq.UseVisualStyleBackColor = false;
            btnReq.Click += btnReq_Click;
            // 
            // btnGymPerf
            // 
            btnGymPerf.BackColor = Color.FromArgb(50, 72, 76);
            btnGymPerf.Dock = DockStyle.Top;
            btnGymPerf.FlatAppearance.BorderSize = 0;
            btnGymPerf.FlatStyle = FlatStyle.Flat;
            btnGymPerf.Font = new Font("Ebrima", 12.25F);
            btnGymPerf.ForeColor = Color.Gainsboro;
            btnGymPerf.Image = (Image)resources.GetObject("btnGymPerf.Image");
            btnGymPerf.ImageAlign = ContentAlignment.MiddleLeft;
            btnGymPerf.Location = new Point(0, 0);
            btnGymPerf.Name = "btnGymPerf";
            btnGymPerf.Padding = new Padding(15, 0, 0, 0);
            btnGymPerf.Size = new Size(253, 70);
            btnGymPerf.TabIndex = 8;
            btnGymPerf.Text = "  Gym Performances";
            btnGymPerf.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGymPerf.UseVisualStyleBackColor = false;
            btnGymPerf.Click += btnGymPerf_Click;
            // 
            // desktopPanel
            // 
            desktopPanel.BackColor = Color.Gainsboro;
            desktopPanel.Dock = DockStyle.Fill;
            desktopPanel.Location = new Point(253, 78);
            desktopPanel.Name = "desktopPanel";
            desktopPanel.Size = new Size(1154, 697);
            desktopPanel.TabIndex = 4;
            // 
            // home_admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1407, 775);
            Controls.Add(desktopPanel);
            Controls.Add(panelMenu);
            Controls.Add(panel2);
            Name = "home_admin";
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
        private Panel panel1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button pfpBtn;
        private Label label3;
        private Label label4;
        private Panel UserNamePanel;
        private Guna.UI2.WinForms.Guna2Button btnpfp;
        private Label usr_type;
        private Label lblUsername;
        private Label pgTitle;
        private Label label1;
        private Panel panelMenu;
        private Button btnRevoke;
        private Button btnReq;
        private Button btnGymPerf;
        private Panel desktopPanel;
    }
}