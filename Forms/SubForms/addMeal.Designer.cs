namespace Project_FLEXTrainer.Forms.SubForms
{
    partial class addMeal
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
            panel1 = new Panel();
            txt = new Label();
            panel2 = new Panel();
            btnCreate = new Button();
            txtProts = new TextBox();
            txtAllergens = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtCarbs = new TextBox();
            label4 = new Label();
            txtFats = new TextBox();
            ss = new Label();
            txtCals = new TextBox();
            sss = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 101, 97);
            panel1.Controls.Add(txt);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 61);
            panel1.TabIndex = 0;
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.Dock = DockStyle.Left;
            txt.Font = new Font("Couture", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt.ForeColor = Color.White;
            txt.Location = new Point(0, 0);
            txt.Name = "txt";
            txt.Padding = new Padding(5, 20, 0, 0);
            txt.Size = new Size(96, 47);
            txt.TabIndex = 1;
            txt.Text = "MEAL";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(btnCreate);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 437);
            panel2.Name = "panel2";
            panel2.Size = new Size(252, 39);
            panel2.TabIndex = 8;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(170, 52, 60);
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(80, 3);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(79, 31);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "ADD";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtProts
            // 
            txtProts.Location = new Point(43, 221);
            txtProts.Name = "txtProts";
            txtProts.Size = new Size(162, 23);
            txtProts.TabIndex = 4;
            // 
            // txtAllergens
            // 
            txtAllergens.Location = new Point(43, 160);
            txtAllergens.Name = "txtAllergens";
            txtAllergens.Size = new Size(162, 23);
            txtAllergens.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(43, 100);
            txtName.Name = "txtName";
            txtName.Size = new Size(162, 23);
            txtName.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(43, 197);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 9;
            label3.Text = "Proteins";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 136);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 8;
            label2.Text = "Allergens";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 76);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 7;
            label1.Text = "Name";
            // 
            // txtCarbs
            // 
            txtCarbs.Location = new Point(43, 280);
            txtCarbs.Name = "txtCarbs";
            txtCarbs.Size = new Size(162, 23);
            txtCarbs.TabIndex = 10;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(43, 256);
            label4.Name = "label4";
            label4.Size = new Size(51, 21);
            label4.TabIndex = 11;
            label4.Text = "Carbs";
            // 
            // txtFats
            // 
            txtFats.Location = new Point(43, 330);
            txtFats.Name = "txtFats";
            txtFats.Size = new Size(162, 23);
            txtFats.TabIndex = 12;
            // 
            // ss
            // 
            ss.Anchor = AnchorStyles.Right;
            ss.AutoSize = true;
            ss.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ss.Location = new Point(43, 306);
            ss.Name = "ss";
            ss.Size = new Size(38, 21);
            ss.TabIndex = 13;
            ss.Text = "Fats";
            // 
            // txtCals
            // 
            txtCals.Location = new Point(43, 381);
            txtCals.Name = "txtCals";
            txtCals.Size = new Size(162, 23);
            txtCals.TabIndex = 14;
            // 
            // sss
            // 
            sss.Anchor = AnchorStyles.Right;
            sss.AutoSize = true;
            sss.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sss.Location = new Point(43, 357);
            sss.Name = "sss";
            sss.Size = new Size(68, 21);
            sss.TabIndex = 15;
            sss.Text = "Calories";
            // 
            // addMeal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(252, 476);
            Controls.Add(txtCals);
            Controls.Add(sss);
            Controls.Add(txtFats);
            Controls.Add(ss);
            Controls.Add(txtCarbs);
            Controls.Add(label4);
            Controls.Add(txtProts);
            Controls.Add(txtAllergens);
            Controls.Add(panel2);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "addMeal";
            Text = "addMeal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnCreate;
        private TextBox txtProts;
        private TextBox txtAllergens;
        private TextBox txtName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label txt;
        private TextBox txtCarbs;
        private Label label4;
        private TextBox txtFats;
        private Label ss;
        private TextBox txtCals;
        private Label sss;
    }
}