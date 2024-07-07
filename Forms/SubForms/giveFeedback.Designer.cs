namespace Project_FLEXTrainer.Forms.SubForms
{
    partial class giveFeedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giveFeedback));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            button1 = new Button();
            comboTrainer = new Guna.UI2.WinForms.Guna2ComboBox();
            closeError = new Button();
            label1 = new Label();
            ratingCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            label2 = new Label();
            label3 = new Label();
            feedbackmsg = new TextBox();
            doneBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(126, 46, 53);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboTrainer);
            panel1.Controls.Add(closeError);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(491, 69);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(454, 0);
            button1.Name = "button1";
            button1.Size = new Size(37, 43);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboTrainer
            // 
            comboTrainer.BackColor = Color.Transparent;
            comboTrainer.CustomizableEdges = customizableEdges1;
            comboTrainer.DrawMode = DrawMode.OwnerDrawFixed;
            comboTrainer.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTrainer.FocusedColor = Color.FromArgb(94, 148, 255);
            comboTrainer.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            comboTrainer.Font = new Font("Segoe UI", 10F);
            comboTrainer.ForeColor = Color.FromArgb(68, 88, 112);
            comboTrainer.ItemHeight = 30;
            comboTrainer.Location = new Point(139, 14);
            comboTrainer.Name = "comboTrainer";
            comboTrainer.ShadowDecoration.CustomizableEdges = customizableEdges2;
            comboTrainer.Size = new Size(245, 36);
            comboTrainer.TabIndex = 3;
            // 
            // closeError
            // 
            closeError.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeError.FlatAppearance.BorderSize = 0;
            closeError.FlatStyle = FlatStyle.Flat;
            closeError.Image = (Image)resources.GetObject("closeError.Image");
            closeError.Location = new Point(1022, 0);
            closeError.Name = "closeError";
            closeError.Size = new Size(37, 43);
            closeError.TabIndex = 2;
            closeError.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(121, 41);
            label1.TabIndex = 0;
            label1.Text = "Trainer:";
            // 
            // ratingCombo
            // 
            ratingCombo.BackColor = Color.Transparent;
            ratingCombo.CustomizableEdges = customizableEdges3;
            ratingCombo.DrawMode = DrawMode.OwnerDrawFixed;
            ratingCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            ratingCombo.FocusedColor = Color.FromArgb(94, 148, 255);
            ratingCombo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            ratingCombo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ratingCombo.ForeColor = Color.FromArgb(68, 88, 112);
            ratingCombo.ItemHeight = 30;
            ratingCombo.Location = new Point(107, 125);
            ratingCombo.Name = "ratingCombo";
            ratingCombo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ratingCombo.Size = new Size(95, 36);
            ratingCombo.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(21, 120);
            label2.Name = "label2";
            label2.Size = new Size(80, 41);
            label2.TabIndex = 4;
            label2.Text = "Rate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(21, 182);
            label3.Name = "label3";
            label3.Size = new Size(147, 41);
            label3.TabIndex = 5;
            label3.Text = "Feedback";
            // 
            // feedbackmsg
            // 
            feedbackmsg.Location = new Point(21, 226);
            feedbackmsg.Multiline = true;
            feedbackmsg.Name = "feedbackmsg";
            feedbackmsg.Size = new Size(366, 125);
            feedbackmsg.TabIndex = 6;
            feedbackmsg.TextChanged += textBox1_TextChanged;
            // 
            // doneBtn
            // 
            doneBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            doneBtn.BackColor = Color.FromArgb(126, 46, 53);
            doneBtn.FlatAppearance.BorderSize = 0;
            doneBtn.FlatStyle = FlatStyle.Flat;
            doneBtn.Image = (Image)resources.GetObject("doneBtn.Image");
            doneBtn.Location = new Point(428, 374);
            doneBtn.Name = "doneBtn";
            doneBtn.Size = new Size(51, 45);
            doneBtn.TabIndex = 7;
            doneBtn.UseVisualStyleBackColor = false;
            doneBtn.Click += doneBtn_Click;
            // 
            // giveFeedback
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(491, 431);
            Controls.Add(doneBtn);
            Controls.Add(feedbackmsg);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ratingCombo);
            Controls.Add(panel1);
            Name = "giveFeedback";
            Text = "giveFeedback";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2ComboBox comboTrainer;
        private Button closeError;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox ratingCombo;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button doneBtn;
        private Button button1;
        private TextBox feedbackmsg;
    }
}