namespace Project_FLEXTrainer.Forms.SubForms
{
    partial class ApplyForOwner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplyForOwner));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            mainPanel = new Panel();
            button1 = new Button();
            exit = new Button();
            txt = new Label();
            label2 = new Label();
            label1 = new Label();
            applyBtn = new Guna.UI2.WinForms.Guna2Button();
            txtGymName = new Guna.UI2.WinForms.Guna2TextBox();
            txtGymLoc = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
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
            mainPanel.Size = new Size(568, 61);
            mainPanel.TabIndex = 3;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(1176, 0);
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
            exit.Location = new Point(1473, 0);
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
            txt.Size = new Size(237, 82);
            txt.TabIndex = 0;
            txt.Text = "Apply For Owner\r\n\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(44, 120);
            label2.Name = "label2";
            label2.Size = new Size(171, 41);
            label2.TabIndex = 6;
            label2.Text = "Gym Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(44, 198);
            label1.Name = "label1";
            label1.Size = new Size(136, 41);
            label1.TabIndex = 7;
            label1.Text = "Location";
            // 
            // applyBtn
            // 
            applyBtn.CustomizableEdges = customizableEdges1;
            applyBtn.DisabledState.BorderColor = Color.DarkGray;
            applyBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            applyBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            applyBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            applyBtn.FillColor = Color.FromArgb(126, 46, 53);
            applyBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            applyBtn.ForeColor = Color.White;
            applyBtn.Location = new Point(183, 348);
            applyBtn.Name = "applyBtn";
            applyBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            applyBtn.Size = new Size(173, 48);
            applyBtn.TabIndex = 11;
            applyBtn.Text = "Apply";
            applyBtn.Click += applyBtn_Click;
            // 
            // txtGymName
            // 
            txtGymName.CustomizableEdges = customizableEdges3;
            txtGymName.DefaultText = "";
            txtGymName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtGymName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtGymName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtGymName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtGymName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtGymName.Font = new Font("Segoe UI", 9F);
            txtGymName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtGymName.Location = new Point(244, 125);
            txtGymName.Name = "txtGymName";
            txtGymName.PasswordChar = '\0';
            txtGymName.PlaceholderText = "";
            txtGymName.SelectedText = "";
            txtGymName.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtGymName.Size = new Size(257, 36);
            txtGymName.TabIndex = 12;
            // 
            // txtGymLoc
            // 
            txtGymLoc.CustomizableEdges = customizableEdges5;
            txtGymLoc.DefaultText = "";
            txtGymLoc.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtGymLoc.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtGymLoc.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtGymLoc.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtGymLoc.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtGymLoc.Font = new Font("Segoe UI", 9F);
            txtGymLoc.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtGymLoc.Location = new Point(244, 198);
            txtGymLoc.Name = "txtGymLoc";
            txtGymLoc.PasswordChar = '\0';
            txtGymLoc.PlaceholderText = "";
            txtGymLoc.SelectedText = "";
            txtGymLoc.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtGymLoc.Size = new Size(257, 36);
            txtGymLoc.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(195, 399);
            label3.Name = "label3";
            label3.Size = new Size(139, 25);
            label3.TabIndex = 14;
            label3.Text = "(Send Request)";
            // 
            // ApplyForOwner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(568, 481);
            Controls.Add(label3);
            Controls.Add(txtGymLoc);
            Controls.Add(txtGymName);
            Controls.Add(applyBtn);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(mainPanel);
            Name = "ApplyForOwner";
            Text = "ApplyForOwner";
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
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button applyBtn;
        private Guna.UI2.WinForms.Guna2TextBox txtGymName;
        private Guna.UI2.WinForms.Guna2TextBox txtGymLoc;
        private Label label3;
    }
}