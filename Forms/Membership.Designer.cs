namespace Project_FLEXTrainer.Forms
{
    partial class Membership
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Membership));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            noMemberPanel = new Panel();
            closeError = new Button();
            label1 = new Label();
            applyMembership = new Panel();
            panel2 = new Panel();
            lblPremium = new Label();
            button2 = new Button();
            label6 = new Label();
            panel1 = new Panel();
            lblBasic = new Label();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            gunaCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            label3 = new Label();
            label2 = new Label();
            panelActiveMS = new Panel();
            txtPlan = new Label();
            txtGym = new Label();
            lblActiveMS = new Label();
            noMemberPanel.SuspendLayout();
            applyMembership.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panelActiveMS.SuspendLayout();
            SuspendLayout();
            // 
            // noMemberPanel
            // 
            noMemberPanel.BackColor = Color.FromArgb(126, 46, 53);
            noMemberPanel.Controls.Add(closeError);
            noMemberPanel.Controls.Add(label1);
            noMemberPanel.Dock = DockStyle.Top;
            noMemberPanel.Location = new Point(0, 0);
            noMemberPanel.Name = "noMemberPanel";
            noMemberPanel.Size = new Size(1155, 43);
            noMemberPanel.TabIndex = 0;
            // 
            // closeError
            // 
            closeError.Dock = DockStyle.Right;
            closeError.FlatAppearance.BorderSize = 0;
            closeError.FlatStyle = FlatStyle.Flat;
            closeError.Image = (Image)resources.GetObject("closeError.Image");
            closeError.Location = new Point(1118, 0);
            closeError.Name = "closeError";
            closeError.Size = new Size(37, 43);
            closeError.TabIndex = 1;
            closeError.UseVisualStyleBackColor = true;
            closeError.Click += closeError_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(5, 7, 0, 0);
            label1.Size = new Size(425, 132);
            label1.TabIndex = 0;
            label1.Text = "Currently, you do not have a gym membership. \r\n\r\n\r\n\r\n\r\n";
            // 
            // applyMembership
            // 
            applyMembership.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            applyMembership.BackColor = Color.FromArgb(25, 42, 40);
            applyMembership.Controls.Add(panel2);
            applyMembership.Controls.Add(panel1);
            applyMembership.Controls.Add(label4);
            applyMembership.Controls.Add(gunaCombo);
            applyMembership.Controls.Add(label3);
            applyMembership.Controls.Add(label2);
            applyMembership.Location = new Point(12, 58);
            applyMembership.Name = "applyMembership";
            applyMembership.Size = new Size(703, 565);
            applyMembership.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(76, 126, 122);
            panel2.Controls.Add(lblPremium);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(382, 218);
            panel2.Name = "panel2";
            panel2.Size = new Size(294, 304);
            panel2.TabIndex = 6;
            // 
            // lblPremium
            // 
            lblPremium.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPremium.ForeColor = Color.White;
            lblPremium.Location = new Point(3, 131);
            lblPremium.Name = "lblPremium";
            lblPremium.Padding = new Padding(5, 7, 0, 0);
            lblPremium.Size = new Size(288, 55);
            lblPremium.TabIndex = 7;
            lblPremium.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(126, 46, 53);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(88, 246);
            button2.Name = "button2";
            button2.Size = new Size(120, 37);
            button2.TabIndex = 6;
            button2.Text = "APPLY";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(72, 0);
            label6.Name = "label6";
            label6.Padding = new Padding(5, 7, 0, 0);
            label6.Size = new Size(162, 55);
            label6.TabIndex = 4;
            label6.Text = "PREMIUM";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(76, 126, 122);
            panel1.Controls.Add(lblBasic);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(72, 218);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 304);
            panel1.TabIndex = 5;
            // 
            // lblBasic
            // 
            lblBasic.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBasic.ForeColor = Color.White;
            lblBasic.Location = new Point(3, 121);
            lblBasic.Name = "lblBasic";
            lblBasic.Padding = new Padding(5, 7, 0, 0);
            lblBasic.Size = new Size(282, 55);
            lblBasic.TabIndex = 6;
            lblBasic.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(126, 46, 53);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(79, 246);
            button1.Name = "button1";
            button1.Size = new Size(120, 37);
            button1.TabIndex = 5;
            button1.Text = "APPLY";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(98, 0);
            label5.Name = "label5";
            label5.Padding = new Padding(5, 7, 0, 0);
            label5.Size = new Size(132, 55);
            label5.TabIndex = 3;
            label5.Text = "BASIC";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(72, 171);
            label4.Name = "label4";
            label4.Padding = new Padding(5, 7, 0, 0);
            label4.Size = new Size(154, 55);
            label4.TabIndex = 4;
            label4.Text = "Select Plan";
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
            gunaCombo.Location = new Point(72, 132);
            gunaCombo.Name = "gunaCombo";
            gunaCombo.ShadowDecoration.CustomizableEdges = customizableEdges2;
            gunaCombo.Size = new Size(285, 36);
            gunaCombo.TabIndex = 3;
            gunaCombo.SelectedIndexChanged += gunaCombo_SelectedIndexChanged_1;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(61, 87);
            label3.Name = "label3";
            label3.Padding = new Padding(5, 7, 0, 0);
            label3.Size = new Size(154, 55);
            label3.TabIndex = 2;
            label3.Text = "Select Gym";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(61, 19);
            label2.Name = "label2";
            label2.Padding = new Padding(5, 7, 0, 0);
            label2.Size = new Size(443, 55);
            label2.TabIndex = 1;
            label2.Text = "APPLY FOR MEMBERSHIP";
            // 
            // panelActiveMS
            // 
            panelActiveMS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelActiveMS.BackColor = Color.FromArgb(76, 126, 122);
            panelActiveMS.Controls.Add(txtPlan);
            panelActiveMS.Controls.Add(txtGym);
            panelActiveMS.Location = new Point(721, 124);
            panelActiveMS.Name = "panelActiveMS";
            panelActiveMS.Size = new Size(422, 499);
            panelActiveMS.TabIndex = 2;
            // 
            // txtPlan
            // 
            txtPlan.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPlan.ForeColor = Color.White;
            txtPlan.Location = new Point(22, 222);
            txtPlan.Name = "txtPlan";
            txtPlan.Padding = new Padding(5, 7, 0, 0);
            txtPlan.Size = new Size(368, 55);
            txtPlan.TabIndex = 4;
            txtPlan.Text = "Plan:";
            // 
            // txtGym
            // 
            txtGym.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGym.ForeColor = Color.White;
            txtGym.Location = new Point(22, 139);
            txtGym.Name = "txtGym";
            txtGym.Padding = new Padding(5, 7, 0, 0);
            txtGym.Size = new Size(368, 55);
            txtGym.TabIndex = 3;
            txtGym.Text = "Gym:";
            // 
            // lblActiveMS
            // 
            lblActiveMS.Font = new Font("Microsoft Sans Serif", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActiveMS.ForeColor = Color.FromArgb(126, 46, 53);
            lblActiveMS.Location = new Point(721, 66);
            lblActiveMS.Name = "lblActiveMS";
            lblActiveMS.Padding = new Padding(5, 7, 0, 0);
            lblActiveMS.Size = new Size(373, 55);
            lblActiveMS.TabIndex = 3;
            lblActiveMS.Text = "ACTIVE MEMBERSHIP";
            // 
            // Membership
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1155, 635);
            Controls.Add(lblActiveMS);
            Controls.Add(panelActiveMS);
            Controls.Add(applyMembership);
            Controls.Add(noMemberPanel);
            Name = "Membership";
            Text = "Membership";
            noMemberPanel.ResumeLayout(false);
            noMemberPanel.PerformLayout();
            applyMembership.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panelActiveMS.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel noMemberPanel;
        private Label label1;
        private Panel applyMembership;
        private Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox gunaCombo;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Panel panel1;
        private Label label5;
        private Label label6;
        private Button button2;
        private Button button1;
        private Panel panelActiveMS;
        private Label lblActiveMS;
        private Button closeError;
        private Label lblBasic;
        private Label lblPremium;
        private Label txtGym;
        private Label txtPlan;
    }
}