namespace Project_FLEXTrainer.Essentials.MessageBoxes
{
    partial class prompt
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
            label6 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(170, 52, 60);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(361, 85);
            label6.TabIndex = 13;
            label6.Text = "Prompt Text";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 46, 53);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 129);
            panel1.Name = "panel1";
            panel1.Size = new Size(361, 18);
            panel1.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(170, 52, 60);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(136, 88);
            button1.Name = "button1";
            button1.Size = new Size(77, 24);
            button1.TabIndex = 15;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // prompt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 147);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label6);
            Name = "prompt";
            Text = "prompt";
            ResumeLayout(false);
        }

        #endregion

        private Label label6;
        private Panel panel1;
        private Button button1;
    }
}