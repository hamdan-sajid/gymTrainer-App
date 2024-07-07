namespace Project_FLEXTrainer.Forms.SubForms
{
    partial class addExercise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addExercise));
            mainPanel = new Panel();
            exit = new Button();
            txt = new Label();
            panel1 = new Panel();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            btnCreate = new Button();
            panel2 = new Panel();
            mainPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(42, 101, 97);
            mainPanel.Controls.Add(exit);
            mainPanel.Controls.Add(txt);
            mainPanel.Dock = DockStyle.Top;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(252, 61);
            mainPanel.TabIndex = 0;
            // 
            // exit
            // 
            exit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exit.FlatAppearance.BorderSize = 0;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Image = (Image)resources.GetObject("exit.Image");
            exit.Location = new Point(466, 0);
            exit.Name = "exit";
            exit.Size = new Size(38, 39);
            exit.TabIndex = 1;
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
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
            txt.Size = new Size(165, 51);
            txt.TabIndex = 0;
            txt.Text = "EXERCISE";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(-123, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 415);
            panel1.TabIndex = 1;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(155, 277);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(162, 23);
            textBox5.TabIndex = 13;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(156, 253);
            label5.Name = "label5";
            label5.Size = new Size(46, 21);
            label5.TabIndex = 16;
            label5.Text = "Reps";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(155, 219);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(162, 23);
            textBox4.TabIndex = 11;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(153, 195);
            label4.Name = "label4";
            label4.Size = new Size(41, 21);
            label4.TabIndex = 15;
            label4.Text = "Sets";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(155, 160);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(162, 23);
            textBox3.TabIndex = 9;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(153, 136);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 14;
            label3.Text = "Machine";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(155, 101);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 23);
            textBox2.TabIndex = 8;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(153, 77);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 12;
            label2.Text = "Routine";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(156, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 23);
            textBox1.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(156, 17);
            label1.Name = "label1";
            label1.Size = new Size(112, 21);
            label1.TabIndex = 10;
            label1.Text = "Target Muscle";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(170, 52, 60);
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(45, 5);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(133, 42);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "ADD";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCreate);
            panel2.Location = new Point(0, 417);
            panel2.Name = "panel2";
            panel2.Size = new Size(498, 139);
            panel2.TabIndex = 7;
            // 
            // addExercise
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(252, 476);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "addExercise";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Label txt;
        private Panel panel1;
        private Button btnCreate;
        private Panel panel2;
        private Button exit;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
    }
}