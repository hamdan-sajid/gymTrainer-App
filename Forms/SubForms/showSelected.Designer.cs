namespace Project_FLEXTrainer.Forms.SubForms
{
    partial class showSelected
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(showSelected));
            panel1 = new Panel();
            gunaCombo = new ComboBox();
            closeError = new Button();
            panelTxt = new Label();
            panelTemplate = new Panel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            panelContainer = new Panel();
            panel1.SuspendLayout();
            panelTemplate.SuspendLayout();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 46, 53);
            panel1.Controls.Add(gunaCombo);
            panel1.Controls.Add(closeError);
            panel1.Controls.Add(panelTxt);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 44);
            panel1.TabIndex = 0;
            // 
            // gunaCombo
            // 
            gunaCombo.FormattingEnabled = true;
            gunaCombo.Location = new Point(375, 12);
            gunaCombo.Name = "gunaCombo";
            gunaCombo.Size = new Size(121, 23);
            gunaCombo.TabIndex = 4;
            gunaCombo.Text = "Gym";
            // 
            // closeError
            // 
            closeError.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeError.FlatAppearance.BorderSize = 0;
            closeError.FlatStyle = FlatStyle.Flat;
            closeError.Image = (Image)resources.GetObject("closeError.Image");
            closeError.Location = new Point(513, 1);
            closeError.Name = "closeError";
            closeError.Size = new Size(37, 43);
            closeError.TabIndex = 3;
            closeError.UseVisualStyleBackColor = true;
            closeError.Click += closeError_Click;
            // 
            // panelTxt
            // 
            panelTxt.AutoSize = true;
            panelTxt.Dock = DockStyle.Left;
            panelTxt.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            panelTxt.ForeColor = SystemColors.Control;
            panelTxt.Location = new Point(0, 0);
            panelTxt.Name = "panelTxt";
            panelTxt.Padding = new Padding(5, 10, 0, 0);
            panelTxt.Size = new Size(360, 35);
            panelTxt.TabIndex = 1;
            panelTxt.Text = "Details of Members (Subscribed to Plan)";
            // 
            // panelTemplate
            // 
            panelTemplate.BackColor = Color.FromArgb(170, 52, 60);
            panelTemplate.Controls.Add(label2);
            panelTemplate.Controls.Add(label1);
            panelTemplate.Controls.Add(label3);
            panelTemplate.Location = new Point(0, 6);
            panelTemplate.Name = "panelTemplate";
            panelTemplate.Padding = new Padding(20, 0, 0, 0);
            panelTemplate.Size = new Size(550, 78);
            panelTemplate.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(43, 46);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 3;
            label2.Text = "Lastname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(43, 13);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 1;
            label1.Text = "Firstname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(304, 28);
            label3.Name = "label3";
            label3.Size = new Size(64, 21);
            label3.TabIndex = 2;
            label3.Text = "Gender";
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.Gainsboro;
            panelContainer.Controls.Add(panelTemplate);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 44);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(550, 539);
            panelContainer.TabIndex = 1;
            // 
            // showSelected
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 583);
            Controls.Add(panelContainer);
            Controls.Add(panel1);
            Name = "showSelected";
            Text = "showSelected";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelTemplate.ResumeLayout(false);
            panelTemplate.PerformLayout();
            panelContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label panelTxt;
        private Panel panelTemplate;
        private Label label2;
        private Label label1;
        private Label label3;
        private Panel panelContainer;
        private Button closeError;
        private ComboBox gunaCombo;
    }
}