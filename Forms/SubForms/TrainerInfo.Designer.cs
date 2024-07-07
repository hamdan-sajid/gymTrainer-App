namespace Project_FLEXTrainer.Forms.SubForms
{
    partial class TrainerInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainerInfo));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            closeError = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            gymName = new Label();
            btnBook = new Guna.UI2.WinForms.Guna2Button();
            label5 = new Label();
            label4 = new Label();
            txtTiming = new Guna.UI2.WinForms.Guna2TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(126, 46, 53);
            panel1.Controls.Add(closeError);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(366, 69);
            panel1.TabIndex = 0;
            // 
            // closeError
            // 
            closeError.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeError.FlatAppearance.BorderSize = 0;
            closeError.FlatStyle = FlatStyle.Flat;
            closeError.Image = (Image)resources.GetObject("closeError.Image");
            closeError.Location = new Point(329, 0);
            closeError.Name = "closeError";
            closeError.Size = new Size(37, 43);
            closeError.TabIndex = 2;
            closeError.UseVisualStyleBackColor = true;
            closeError.Click += closeError_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(191, 41);
            label1.TabIndex = 0;
            label1.Text = "trainerName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 110);
            label2.Name = "label2";
            label2.Size = new Size(204, 32);
            label2.TabIndex = 1;
            label2.Text = "trainerExperience";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 156);
            label3.Name = "label3";
            label3.Size = new Size(158, 32);
            label3.TabIndex = 2;
            label3.Text = "trainerRating";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(76, 126, 122);
            panel2.Controls.Add(txtTiming);
            panel2.Controls.Add(gymName);
            panel2.Controls.Add(btnBook);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 225);
            panel2.Name = "panel2";
            panel2.Size = new Size(366, 216);
            panel2.TabIndex = 3;
            // 
            // gymName
            // 
            gymName.AutoSize = true;
            gymName.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            gymName.ForeColor = Color.White;
            gymName.Location = new Point(122, 41);
            gymName.Name = "gymName";
            gymName.Size = new Size(126, 32);
            gymName.TabIndex = 4;
            gymName.Text = "gymName";
            // 
            // btnBook
            // 
            btnBook.BackColor = Color.FromArgb(76, 126, 122);
            btnBook.BorderRadius = 10;
            btnBook.CustomizableEdges = customizableEdges3;
            btnBook.DisabledState.BorderColor = Color.DarkGray;
            btnBook.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBook.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBook.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBook.FillColor = Color.FromArgb(126, 46, 53);
            btnBook.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBook.ForeColor = Color.White;
            btnBook.Location = new Point(88, 159);
            btnBook.Name = "btnBook";
            btnBook.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnBook.Size = new Size(180, 45);
            btnBook.TabIndex = 4;
            btnBook.Text = "BOOK APPOINTMENT";
            btnBook.Click += btnBook_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(28, 98);
            label5.Name = "label5";
            label5.Size = new Size(88, 32);
            label5.TabIndex = 3;
            label5.Text = "Timing";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(52, 41);
            label4.Name = "label4";
            label4.Size = new Size(70, 32);
            label4.TabIndex = 2;
            label4.Text = "Gym:";
            // 
            // txtTiming
            // 
            txtTiming.CustomizableEdges = customizableEdges1;
            txtTiming.DefaultText = "";
            txtTiming.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTiming.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTiming.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTiming.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTiming.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTiming.Font = new Font("Segoe UI", 9F);
            txtTiming.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTiming.Location = new Point(122, 98);
            txtTiming.Name = "txtTiming";
            txtTiming.PasswordChar = '\0';
            txtTiming.PlaceholderText = "";
            txtTiming.SelectedText = "";
            txtTiming.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtTiming.Size = new Size(172, 36);
            txtTiming.TabIndex = 5;
            // 
            // TrainerInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(140, 147, 148);
            ClientSize = new Size(366, 441);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "TrainerInfo";
            Text = "TrainerInfo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnBook;
        private Label label5;
        private Label label4;
        private Button closeError;
        public Label gymName;
        private Guna.UI2.WinForms.Guna2TextBox txtTiming;
    }
}