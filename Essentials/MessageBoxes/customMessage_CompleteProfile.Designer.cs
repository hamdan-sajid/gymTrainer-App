namespace Project_FLEXTrainer.Essentials.MessageBoxes
{
    partial class customMessage_CompleteProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customMessage_CompleteProfile));
            panel1 = new Panel();
            label6 = new Label();
            label1 = new Label();
            btnComplete = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 46, 53);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 172);
            panel1.Name = "panel1";
            panel1.Size = new Size(373, 25);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(170, 52, 60);
            label6.Location = new Point(67, 34);
            label6.Name = "label6";
            label6.Size = new Size(219, 32);
            label6.TabIndex = 11;
            label6.Text = "Incomplete Profile.";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(14, 66);
            label1.Name = "label1";
            label1.Size = new Size(359, 25);
            label1.TabIndex = 12;
            label1.Text = "complete your profile before proceeding";
            // 
            // btnComplete
            // 
            btnComplete.BackColor = Color.FromArgb(170, 52, 60);
            btnComplete.FlatAppearance.BorderSize = 0;
            btnComplete.FlatStyle = FlatStyle.Flat;
            btnComplete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComplete.ForeColor = Color.White;
            btnComplete.Location = new Point(103, 123);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(145, 34);
            btnComplete.TabIndex = 13;
            btnComplete.Text = "Complete";
            btnComplete.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Silver;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(346, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(27, 23);
            btnClose.TabIndex = 14;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // customMessage_CompleteProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(373, 197);
            Controls.Add(btnClose);
            Controls.Add(btnComplete);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(panel1);
            Name = "customMessage_CompleteProfile";
            Text = "customMessage_CompleteProfile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label1;
        private Button btnComplete;
        private Button btnClose;
    }
}