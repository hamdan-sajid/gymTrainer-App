namespace Project_FLEXTrainer.Forms.SubForms
{
    partial class ApplyForTrainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplyForTrainer));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            mainPanel = new Panel();
            button1 = new Button();
            exit = new Button();
            txt = new Label();
            label2 = new Label();
            gymCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            addGym = new Guna.UI2.WinForms.Guna2Button();
            applyBtn = new Guna.UI2.WinForms.Guna2Button();
            Exp = new Label();
            label3 = new Label();
            label4 = new Label();
            txtExp = new Guna.UI2.WinForms.Guna2TextBox();
            txtQualification = new Guna.UI2.WinForms.Guna2TextBox();
            txtSpecialization = new Guna.UI2.WinForms.Guna2TextBox();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(126, 46, 53);
            mainPanel.Controls.Add(button1);
            mainPanel.Controls.Add(exit);
            mainPanel.Controls.Add(txt);
            mainPanel.Dock = DockStyle.Top;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(548, 61);
            mainPanel.TabIndex = 2;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(775, 0);
            button1.Name = "button1";
            button1.Size = new Size(37, 43);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            exit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exit.FlatAppearance.BorderSize = 0;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Image = (Image)resources.GetObject("exit.Image");
            exit.Location = new Point(1072, 0);
            exit.Name = "exit";
            exit.Size = new Size(38, 39);
            exit.TabIndex = 1;
            exit.UseVisualStyleBackColor = true;
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.Dock = DockStyle.Left;
            txt.Font = new Font("Microsoft Sans Serif", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt.ForeColor = Color.White;
            txt.Location = new Point(0, 0);
            txt.Name = "txt";
            txt.Padding = new Padding(5, 20, 0, 0);
            txt.Size = new Size(245, 51);
            txt.TabIndex = 0;
            txt.Text = "Apply For Trainer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(140, 119);
            label2.Name = "label2";
            label2.Size = new Size(81, 41);
            label2.TabIndex = 5;
            label2.Text = "Gym";
            // 
            // gymCombo
            // 
            gymCombo.BackColor = Color.Transparent;
            gymCombo.CustomizableEdges = customizableEdges1;
            gymCombo.DrawMode = DrawMode.OwnerDrawFixed;
            gymCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            gymCombo.FocusedColor = Color.FromArgb(94, 148, 255);
            gymCombo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            gymCombo.Font = new Font("Segoe UI", 10F);
            gymCombo.ForeColor = Color.FromArgb(68, 88, 112);
            gymCombo.ItemHeight = 30;
            gymCombo.Location = new Point(256, 124);
            gymCombo.Name = "gymCombo";
            gymCombo.ShadowDecoration.CustomizableEdges = customizableEdges2;
            gymCombo.Size = new Size(179, 36);
            gymCombo.TabIndex = 8;
            // 
            // addGym
            // 
            addGym.BorderRadius = 10;
            addGym.CustomizableEdges = customizableEdges3;
            addGym.DisabledState.BorderColor = Color.DarkGray;
            addGym.DisabledState.CustomBorderColor = Color.DarkGray;
            addGym.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            addGym.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            addGym.FillColor = Color.FromArgb(126, 46, 53);
            addGym.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addGym.ForeColor = Color.White;
            addGym.Image = (Image)resources.GetObject("addGym.Image");
            addGym.Location = new Point(441, 124);
            addGym.Name = "addGym";
            addGym.ShadowDecoration.CustomizableEdges = customizableEdges4;
            addGym.Size = new Size(43, 35);
            addGym.TabIndex = 9;
            addGym.Click += addGym_Click;
            // 
            // applyBtn
            // 
            applyBtn.CustomizableEdges = customizableEdges5;
            applyBtn.DisabledState.BorderColor = Color.DarkGray;
            applyBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            applyBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            applyBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            applyBtn.FillColor = Color.FromArgb(126, 46, 53);
            applyBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            applyBtn.ForeColor = Color.White;
            applyBtn.Location = new Point(161, 398);
            applyBtn.Name = "applyBtn";
            applyBtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            applyBtn.Size = new Size(173, 48);
            applyBtn.TabIndex = 10;
            applyBtn.Text = "Apply";
            applyBtn.Click += applyBtn_Click;
            // 
            // Exp
            // 
            Exp.AutoSize = true;
            Exp.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            Exp.ForeColor = Color.DimGray;
            Exp.Location = new Point(55, 180);
            Exp.Name = "Exp";
            Exp.Size = new Size(166, 41);
            Exp.TabIndex = 11;
            Exp.Text = "Experience";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(27, 245);
            label3.Name = "label3";
            label3.Size = new Size(194, 41);
            label3.TabIndex = 13;
            label3.Text = "Qualification";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(14, 302);
            label4.Name = "label4";
            label4.Size = new Size(207, 41);
            label4.TabIndex = 14;
            label4.Text = "Specialization";
            // 
            // txtExp
            // 
            txtExp.CustomizableEdges = customizableEdges7;
            txtExp.DefaultText = "";
            txtExp.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtExp.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtExp.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtExp.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtExp.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtExp.Font = new Font("Segoe UI", 9F);
            txtExp.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtExp.Location = new Point(256, 185);
            txtExp.Name = "txtExp";
            txtExp.PasswordChar = '\0';
            txtExp.PlaceholderText = "";
            txtExp.SelectedText = "";
            txtExp.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtExp.Size = new Size(200, 36);
            txtExp.TabIndex = 15;
            // 
            // txtQualification
            // 
            txtQualification.CustomizableEdges = customizableEdges9;
            txtQualification.DefaultText = "";
            txtQualification.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtQualification.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtQualification.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtQualification.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtQualification.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtQualification.Font = new Font("Segoe UI", 9F);
            txtQualification.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtQualification.Location = new Point(256, 245);
            txtQualification.Name = "txtQualification";
            txtQualification.PasswordChar = '\0';
            txtQualification.PlaceholderText = "";
            txtQualification.SelectedText = "";
            txtQualification.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtQualification.Size = new Size(200, 36);
            txtQualification.TabIndex = 17;
            // 
            // txtSpecialization
            // 
            txtSpecialization.CustomizableEdges = customizableEdges11;
            txtSpecialization.DefaultText = "";
            txtSpecialization.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSpecialization.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSpecialization.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSpecialization.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSpecialization.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSpecialization.Font = new Font("Segoe UI", 9F);
            txtSpecialization.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSpecialization.Location = new Point(256, 302);
            txtSpecialization.Name = "txtSpecialization";
            txtSpecialization.PasswordChar = '\0';
            txtSpecialization.PlaceholderText = "";
            txtSpecialization.SelectedText = "";
            txtSpecialization.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtSpecialization.Size = new Size(200, 36);
            txtSpecialization.TabIndex = 18;
            // 
            // ApplyForTrainer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 471);
            Controls.Add(txtSpecialization);
            Controls.Add(txtQualification);
            Controls.Add(txtExp);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Exp);
            Controls.Add(applyBtn);
            Controls.Add(addGym);
            Controls.Add(gymCombo);
            Controls.Add(label2);
            Controls.Add(mainPanel);
            Name = "ApplyForTrainer";
            Text = "ApplyForTrainer";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel mainPanel;
        private Button button1;
        private Button exit;
        private Label txt;
        private Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox gymCombo;
        private Guna.UI2.WinForms.Guna2Button addGym;
        private Guna.UI2.WinForms.Guna2Button applyBtn;
        private Label Exp;
        private Label label3;
        private Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtExp;
        private Guna.UI2.WinForms.Guna2TextBox txtQualification;
        private Guna.UI2.WinForms.Guna2TextBox txtSpecialization;
    }
}