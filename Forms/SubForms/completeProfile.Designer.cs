namespace Project_FLEXTrainer.Forms.SubForms
{
    partial class completeProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(completeProfile));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            mainPanel = new Panel();
            button1 = new Button();
            exit = new Button();
            txt = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtFname = new TextBox();
            txtLname = new TextBox();
            genderCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            doneBtn = new Button();
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
            mainPanel.Size = new Size(464, 61);
            mainPanel.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(427, 0);
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
            exit.Location = new Point(724, 0);
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
            txt.Size = new Size(162, 51);
            txt.TabIndex = 0;
            txt.Text = "Edit Profile";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 108);
            label1.Name = "label1";
            label1.Size = new Size(117, 30);
            label1.TabIndex = 2;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 182);
            label2.Name = "label2";
            label2.Size = new Size(114, 30);
            label2.TabIndex = 3;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 248);
            label3.Name = "label3";
            label3.Size = new Size(83, 30);
            label3.TabIndex = 4;
            label3.Text = "Gender";
            // 
            // txtFname
            // 
            txtFname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFname.Location = new Point(196, 109);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(140, 33);
            txtFname.TabIndex = 5;
            // 
            // txtLname
            // 
            txtLname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLname.Location = new Point(196, 179);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(140, 33);
            txtLname.TabIndex = 6;
            // 
            // genderCombo
            // 
            genderCombo.BackColor = Color.Transparent;
            genderCombo.CustomizableEdges = customizableEdges1;
            genderCombo.DrawMode = DrawMode.OwnerDrawFixed;
            genderCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            genderCombo.FocusedColor = Color.FromArgb(94, 148, 255);
            genderCombo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            genderCombo.Font = new Font("Segoe UI", 10F);
            genderCombo.ForeColor = Color.FromArgb(68, 88, 112);
            genderCombo.ItemHeight = 30;
            genderCombo.Location = new Point(196, 248);
            genderCombo.Name = "genderCombo";
            genderCombo.ShadowDecoration.CustomizableEdges = customizableEdges2;
            genderCombo.Size = new Size(140, 36);
            genderCombo.TabIndex = 7;
            // 
            // doneBtn
            // 
            doneBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            doneBtn.BackColor = Color.FromArgb(126, 46, 53);
            doneBtn.FlatAppearance.BorderSize = 0;
            doneBtn.FlatStyle = FlatStyle.Flat;
            doneBtn.Image = (Image)resources.GetObject("doneBtn.Image");
            doneBtn.Location = new Point(410, 350);
            doneBtn.Name = "doneBtn";
            doneBtn.Size = new Size(42, 42);
            doneBtn.TabIndex = 8;
            doneBtn.UseVisualStyleBackColor = false;
            doneBtn.Click += doneBtn_Click;
            // 
            // completeProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 404);
            Controls.Add(doneBtn);
            Controls.Add(genderCombo);
            Controls.Add(txtLname);
            Controls.Add(txtFname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mainPanel);
            Name = "completeProfile";
            Text = "completeProfile";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel mainPanel;
        private Button exit;
        private Label txt;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox txtFname;
        private TextBox txtLname;
        private Guna.UI2.WinForms.Guna2ComboBox genderCombo;
        private Button doneBtn;
    }
}