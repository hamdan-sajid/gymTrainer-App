namespace Project_FLEXTrainer.Admin.Forms
{
    partial class gymPerformances
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            navPanel = new Panel();
            pgTitle = new Label();
            panel1 = new Panel();
            gunaCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            label2 = new Label();
            label1 = new Label();
            panelTemplate = new Panel();
            txtLoc = new Label();
            name = new Label();
            totalMember = new Label();
            panelContainer = new Panel();
            navPanel.SuspendLayout();
            panel1.SuspendLayout();
            panelTemplate.SuspendLayout();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // navPanel
            // 
            navPanel.BackColor = Color.FromArgb(25, 42, 40);
            navPanel.Controls.Add(pgTitle);
            navPanel.Dock = DockStyle.Top;
            navPanel.Location = new Point(0, 0);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(1312, 52);
            navPanel.TabIndex = 2;
            // 
            // pgTitle
            // 
            pgTitle.Font = new Font("Microsoft Sans Serif", 20.75F);
            pgTitle.ForeColor = Color.White;
            pgTitle.Location = new Point(0, -9);
            pgTitle.Name = "pgTitle";
            pgTitle.Padding = new Padding(10, 20, 0, 0);
            pgTitle.Size = new Size(389, 61);
            pgTitle.TabIndex = 13;
            pgTitle.Text = "Gyms Performance Metrics";
            pgTitle.Click += pgTitle_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(42, 101, 97);
            panel1.Controls.Add(gunaCombo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(1106, 111);
            panel1.TabIndex = 6;
            // 
            // gunaCombo
            // 
            gunaCombo.BackColor = Color.Transparent;
            gunaCombo.CustomizableEdges = customizableEdges1;
            gunaCombo.DrawMode = DrawMode.OwnerDrawFixed;
            gunaCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            gunaCombo.FocusedColor = Color.FromArgb(94, 148, 255);
            gunaCombo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            gunaCombo.Font = new Font("Segoe UI", 10F);
            gunaCombo.ForeColor = Color.FromArgb(68, 88, 112);
            gunaCombo.ItemHeight = 30;
            gunaCombo.Location = new Point(13, 20);
            gunaCombo.Name = "gunaCombo";
            gunaCombo.ShadowDecoration.CustomizableEdges = customizableEdges2;
            gunaCombo.Size = new Size(285, 36);
            gunaCombo.TabIndex = 16;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(146, 57);
            label2.Name = "label2";
            label2.Padding = new Padding(10, 20, 0, 0);
            label2.Size = new Size(53, 43);
            label2.TabIndex = 15;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 59);
            label1.Name = "label1";
            label1.Padding = new Padding(10, 20, 0, 0);
            label1.Size = new Size(143, 61);
            label1.TabIndex = 14;
            label1.Text = "Total Count: ";
            // 
            // panelTemplate
            // 
            panelTemplate.BackColor = Color.FromArgb(25, 42, 40);
            panelTemplate.Controls.Add(txtLoc);
            panelTemplate.Controls.Add(name);
            panelTemplate.Controls.Add(totalMember);
            panelTemplate.Location = new Point(3, 47);
            panelTemplate.Name = "panelTemplate";
            panelTemplate.Padding = new Padding(20, 0, 0, 0);
            panelTemplate.Size = new Size(1106, 126);
            panelTemplate.TabIndex = 9;
            // 
            // txtLoc
            // 
            txtLoc.AutoSize = true;
            txtLoc.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            txtLoc.ForeColor = Color.White;
            txtLoc.Location = new Point(120, 67);
            txtLoc.Name = "txtLoc";
            txtLoc.Size = new Size(107, 32);
            txtLoc.TabIndex = 7;
            txtLoc.Text = "Location";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            name.ForeColor = Color.White;
            name.Location = new Point(120, 26);
            name.Name = "name";
            name.Size = new Size(79, 32);
            name.TabIndex = 1;
            name.Text = "Name";
            // 
            // totalMember
            // 
            totalMember.AutoSize = true;
            totalMember.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            totalMember.ForeColor = Color.White;
            totalMember.Location = new Point(615, 43);
            totalMember.Name = "totalMember";
            totalMember.Size = new Size(176, 32);
            totalMember.TabIndex = 2;
            totalMember.Text = "Total Members";
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(panel1);
            panelContainer.Controls.Add(panelTemplate);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 52);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1312, 609);
            panelContainer.TabIndex = 3;
            // 
            // gymPerformances
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1312, 661);
            Controls.Add(panelContainer);
            Controls.Add(navPanel);
            Name = "gymPerformances";
            Text = "Gym Perfomances";
            navPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panelTemplate.ResumeLayout(false);
            panelTemplate.PerformLayout();
            panelContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel navPanel;
        private Label pgTitle;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox gunaCombo;
        private Panel panelContainer;
        private Panel panelTemplate;
       // private Label label1;
        private Label totalTrainers;
        private Label txtLoc;
       // private Panel panel1;
        private Label name;
        private Label totalMember;
    }
}