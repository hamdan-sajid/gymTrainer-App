namespace Project_FLEXTrainer.Trainer.Forms
{
    partial class viewMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewMembers));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            navPanel = new Panel();
            planCombo = new ComboBox();
            nameLabel = new Label();
            searchBar = new Guna.UI2.WinForms.Guna2TextBox();
            panelTemplate = new Panel();
            panel1 = new Panel();
            name = new Label();
            gender = new Label();
            panelContainer = new Panel();
            gunaAreaDataset1 = new Guna.Charts.WinForms.GunaAreaDataset();
            navPanel.SuspendLayout();
            panelTemplate.SuspendLayout();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // navPanel
            // 
            navPanel.BackColor = Color.FromArgb(125, 42, 40);
            navPanel.Controls.Add(planCombo);
            navPanel.Controls.Add(nameLabel);
            navPanel.Controls.Add(searchBar);
            navPanel.Dock = DockStyle.Top;
            navPanel.Location = new Point(0, 0);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(1270, 52);
            navPanel.TabIndex = 5;
            // 
            // planCombo
            // 
            planCombo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            planCombo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            planCombo.FormattingEnabled = true;
            planCombo.Location = new Point(1034, 12);
            planCombo.Name = "planCombo";
            planCombo.Size = new Size(224, 29);
            planCombo.TabIndex = 15;
            planCombo.Text = "PLAN NAME";
            planCombo.SelectedIndexChanged += planCombo_SelectedIndexChanged;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(12, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(215, 37);
            nameLabel.TabIndex = 14;
            nameLabel.Text = "VIEW MEMBERS";
            // 
            // searchBar
            // 
            searchBar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchBar.BorderColor = Color.White;
            searchBar.BorderRadius = 12;
            searchBar.BorderThickness = 2;
            searchBar.CustomizableEdges = customizableEdges1;
            searchBar.DefaultText = "";
            searchBar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            searchBar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            searchBar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            searchBar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            searchBar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            searchBar.Font = new Font("Segoe UI", 9F);
            searchBar.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            searchBar.IconRight = (Image)resources.GetObject("searchBar.IconRight");
            searchBar.Location = new Point(2069, 12);
            searchBar.Name = "searchBar";
            searchBar.Padding = new Padding(0, 20, 0, 0);
            searchBar.PasswordChar = '\0';
            searchBar.PlaceholderText = "Search Member";
            searchBar.SelectedText = "";
            searchBar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            searchBar.Size = new Size(259, 28);
            searchBar.TabIndex = 11;
            // 
            // panelTemplate
            // 
            panelTemplate.BackColor = Color.FromArgb(25, 42, 40);
            panelTemplate.Controls.Add(panel1);
            panelTemplate.Controls.Add(name);
            panelTemplate.Controls.Add(gender);
            panelTemplate.Location = new Point(53, 6);
            panelTemplate.Name = "panelTemplate";
            panelTemplate.Padding = new Padding(20, 0, 0, 0);
            panelTemplate.Size = new Size(1106, 78);
            panelTemplate.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 101, 97);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(84, 78);
            panel1.TabIndex = 6;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            name.ForeColor = Color.White;
            name.Location = new Point(132, 17);
            name.Name = "name";
            name.Size = new Size(90, 37);
            name.TabIndex = 1;
            name.Text = "Name";
            // 
            // gender
            // 
            gender.AutoSize = true;
            gender.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            gender.ForeColor = Color.White;
            gender.Location = new Point(578, 17);
            gender.Name = "gender";
            gender.Size = new Size(106, 37);
            gender.TabIndex = 2;
            gender.Text = "Gender";
            // 
            // panelContainer
            // 
            panelContainer.BackColor = SystemColors.ControlLight;
            panelContainer.Controls.Add(panelTemplate);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 52);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1270, 617);
            panelContainer.TabIndex = 6;
            // 
            // gunaAreaDataset1
            // 
            gunaAreaDataset1.BorderColor = Color.Empty;
            gunaAreaDataset1.FillColor = Color.Empty;
            gunaAreaDataset1.Label = "Area1";
            // 
            // viewMembers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 669);
            Controls.Add(panelContainer);
            Controls.Add(navPanel);
            Name = "viewMembers";
            Text = "viewMembers";
            navPanel.ResumeLayout(false);
            navPanel.PerformLayout();
            panelTemplate.ResumeLayout(false);
            panelTemplate.PerformLayout();
            panelContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel navPanel;
        private Guna.UI2.WinForms.Guna2TextBox searchBar;
        private Label nameLabel;
        private Panel panelTemplate;
        private Panel panel1;
        private Label name;
        private Label gender;
        private Panel panelContainer;
        private ComboBox planCombo;
        private Guna.Charts.WinForms.GunaAreaDataset gunaAreaDataset1;
    }
}