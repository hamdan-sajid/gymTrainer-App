namespace Project_FLEXTrainer.Admin.Forms
{
    partial class Requests
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Requests));
            navPanel = new Panel();
            btnPending = new Button();
            pgTitle = new Label();
            panelContainer = new Panel();
            panelTemplate = new Panel();
            hiddenID = new Label();
            btnReject = new Guna.UI2.WinForms.Guna2GradientButton();
            btnAccept = new Guna.UI2.WinForms.Guna2GradientButton();
            panel1 = new Panel();
            nameLabel = new Label();
            experienceLabel = new Label();
            genderLabel = new Label();
            imageList1 = new ImageList(components);
            navPanel.SuspendLayout();
            panelContainer.SuspendLayout();
            panelTemplate.SuspendLayout();
            SuspendLayout();
            // 
            // navPanel
            // 
            navPanel.BackColor = Color.FromArgb(25, 42, 40);
            navPanel.Controls.Add(btnPending);
            navPanel.Controls.Add(pgTitle);
            navPanel.Dock = DockStyle.Top;
            navPanel.Location = new Point(0, 0);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(1159, 52);
            navPanel.TabIndex = 3;
            // 
            // btnPending
            // 
            btnPending.BackColor = Color.FromArgb(76, 126, 122);
            btnPending.Dock = DockStyle.Right;
            btnPending.FlatAppearance.BorderSize = 0;
            btnPending.FlatStyle = FlatStyle.Flat;
            btnPending.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPending.ForeColor = Color.White;
            btnPending.Location = new Point(875, 0);
            btnPending.Name = "btnPending";
            btnPending.Size = new Size(284, 52);
            btnPending.TabIndex = 13;
            btnPending.Text = "PENDING";
            btnPending.UseVisualStyleBackColor = false;
            btnPending.Click += btnPending_Click;
            // 
            // pgTitle
            // 
            pgTitle.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pgTitle.ForeColor = Color.White;
            pgTitle.Location = new Point(0, -11);
            pgTitle.Name = "pgTitle";
            pgTitle.Padding = new Padding(10, 20, 0, 0);
            pgTitle.Size = new Size(318, 63);
            pgTitle.TabIndex = 12;
            pgTitle.Text = "Registration Requests";
            // 
            // panelContainer
            // 
            panelContainer.AutoScroll = true;
            panelContainer.BackColor = Color.WhiteSmoke;
            panelContainer.Controls.Add(panelTemplate);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 52);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1159, 574);
            panelContainer.TabIndex = 5;
            // 
            // panelTemplate
            // 
            panelTemplate.BackColor = Color.FromArgb(170, 52, 60);
            panelTemplate.Controls.Add(hiddenID);
            panelTemplate.Controls.Add(btnReject);
            panelTemplate.Controls.Add(btnAccept);
            panelTemplate.Controls.Add(panel1);
            panelTemplate.Controls.Add(nameLabel);
            panelTemplate.Controls.Add(experienceLabel);
            panelTemplate.Controls.Add(genderLabel);
            panelTemplate.Location = new Point(149, 31);
            panelTemplate.Name = "panelTemplate";
            panelTemplate.Padding = new Padding(20, 0, 0, 0);
            panelTemplate.Size = new Size(838, 78);
            panelTemplate.TabIndex = 3;
            // 
            // hiddenID
            // 
            hiddenID.AutoSize = true;
            hiddenID.Location = new Point(327, 54);
            hiddenID.Name = "hiddenID";
            hiddenID.Size = new Size(55, 15);
            hiddenID.TabIndex = 9;
            hiddenID.Text = "hiddenID";
            hiddenID.Visible = false;
            // 
            // btnReject
            // 
            btnReject.CustomizableEdges = customizableEdges1;
            btnReject.DisabledState.BorderColor = Color.DarkGray;
            btnReject.DisabledState.CustomBorderColor = Color.DarkGray;
            btnReject.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnReject.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnReject.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnReject.Dock = DockStyle.Right;
            btnReject.FillColor = Color.FromArgb(255, 128, 128);
            btnReject.FillColor2 = Color.Salmon;
            btnReject.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReject.ForeColor = Color.White;
            btnReject.ImageAlign = HorizontalAlignment.Left;
            btnReject.Location = new Point(632, 0);
            btnReject.Name = "btnReject";
            btnReject.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnReject.Size = new Size(103, 78);
            btnReject.TabIndex = 8;
            btnReject.Text = "Reject";
            // 
            // btnAccept
            // 
            btnAccept.CustomizableEdges = customizableEdges3;
            btnAccept.DisabledState.BorderColor = Color.DarkGray;
            btnAccept.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAccept.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAccept.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnAccept.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAccept.Dock = DockStyle.Right;
            btnAccept.FillColor = Color.FromArgb(42, 101, 97);
            btnAccept.FillColor2 = Color.Teal;
            btnAccept.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccept.ForeColor = Color.White;
            btnAccept.ImageAlign = HorizontalAlignment.Left;
            btnAccept.Location = new Point(735, 0);
            btnAccept.Name = "btnAccept";
            btnAccept.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAccept.Size = new Size(103, 78);
            btnAccept.TabIndex = 7;
            btnAccept.Text = "Accept";
            btnAccept.Click += btnAccept_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 101, 97);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(84, 81);
            panel1.TabIndex = 6;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(124, 11);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(53, 21);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name";
            // 
            // experienceLabel
            // 
            experienceLabel.AutoSize = true;
            experienceLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            experienceLabel.ForeColor = Color.White;
            experienceLabel.Location = new Point(365, 11);
            experienceLabel.Name = "experienceLabel";
            experienceLabel.Size = new Size(90, 21);
            experienceLabel.TabIndex = 3;
            experienceLabel.Text = "Experience";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            genderLabel.ForeColor = Color.White;
            genderLabel.Location = new Point(124, 39);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(64, 21);
            genderLabel.TabIndex = 2;
            genderLabel.Text = "Gender";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "openview.png");
            // 
            // Requests
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1159, 626);
            Controls.Add(panelContainer);
            Controls.Add(navPanel);
            Name = "Requests";
            Text = "Requests";
            navPanel.ResumeLayout(false);
            panelContainer.ResumeLayout(false);
            panelTemplate.ResumeLayout(false);
            panelTemplate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel navPanel;
        private Label pgTitle;
        private Button btnPending;
        private Panel panelContainer;
        private Panel panelTemplate;
        private Panel panel1;
        private Label nameLabel;
        private Label experienceLabel;
        private Label genderLabel;
        private ImageList imageList1;
        private Guna.UI2.WinForms.Guna2GradientButton btnReject;
        private Guna.UI2.WinForms.Guna2GradientButton btnAccept;
        private Label hiddenID;
    }
}