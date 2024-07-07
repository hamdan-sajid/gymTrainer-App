namespace Project_FLEXTrainer
{
    partial class register
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            panel1 = new Panel();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            linkLabel1 = new LinkLabel();
            Pass = new TextBox();
            label3 = new Label();
            button2 = new Button();
            label2 = new Label();
            bindingSource1 = new BindingSource(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel2 = new Panel();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            back = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 72, 76);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(Pass);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(788, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(396, 532);
            panel1.TabIndex = 19;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(61, 199);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(239, 29);
            textBox3.TabIndex = 19;
            textBox3.Text = "Email";
            textBox3.Enter += textBox3_Enter;
            textBox3.Leave += textBox3_Leave;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(61, 294);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(239, 29);
            textBox2.TabIndex = 18;
            textBox2.Text = "Re-Enter Password";
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(61, 152);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 29);
            textBox1.TabIndex = 17;
            textBox1.Text = "Username";
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(81, 445);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(204, 15);
            linkLabel1.TabIndex = 16;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Already have an account? Login here.";
            linkLabel1.Click += linkLabel_click;
            // 
            // Pass
            // 
            Pass.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pass.Location = new Point(61, 248);
            Pass.Name = "Pass";
            Pass.Size = new Size(239, 29);
            Pass.TabIndex = 15;
            Pass.Text = "Password";
            Pass.Enter += pass_Enter;
            Pass.Leave += pass_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Honeydew;
            label3.Location = new Point(57, 113);
            label3.Name = "label3";
            label3.Size = new Size(81, 24);
            label3.TabIndex = 1;
            label3.Text = "Member";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(170, 52, 60);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(61, 368);
            button2.Name = "button2";
            button2.Size = new Size(239, 46);
            button2.TabIndex = 14;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 36F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(47, 58);
            label2.Name = "label2";
            label2.Size = new Size(269, 55);
            label2.TabIndex = 0;
            label2.Text = "REGISTER";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 72, 76);
            panel2.Location = new Point(-4, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(72, 534);
            panel2.TabIndex = 20;
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(170, 52, 60);
            back.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            back.ForeColor = SystemColors.ButtonFace;
            back.Location = new Point(348, 460);
            back.Name = "back";
            back.Size = new Size(131, 39);
            back.TabIndex = 19;
            back.Text = "Back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gainsboro;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(81, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(711, 672);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 532);
            Controls.Add(back);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Name = "register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "register";
            Load += register_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TextBox textBox1;
        private LinkLabel linkLabel1;
        private TextBox Pass;
        private Label label3;
        private Button button2;
        private Label label2;
        private BindingSource bindingSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private TextBox textBox2;
        private Button back;
        private TextBox textBox3;
        private PictureBox pictureBox1;
    }
}