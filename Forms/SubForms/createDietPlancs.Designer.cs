namespace Project_FLEXTrainer.Forms.SubForms
{
    partial class createDietPlancs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createDietPlancs));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            btnClose = new Button();
            label1 = new Label();
            panel2 = new Panel();
            mealPanel = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            label6 = new Label();
            label3 = new Label();
            btnCreate = new Button();
            label4 = new Label();
            label2 = new Label();
            panel7 = new Panel();
            statusCombo = new ComboBox();
            txtPlanName = new TextBox();
            listGoals = new Guna.UI2.WinForms.Guna2ComboBox();
            ListNutrition = new Guna.UI2.WinForms.Guna2ComboBox();
            listType = new Guna.UI2.WinForms.Guna2ComboBox();
            panelExercise = new FlowLayoutPanel();
            btnAddMeal = new Button();
            label5 = new Label();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 101, 97);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(902, 60);
            panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(872, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(27, 23);
            btnClose.TabIndex = 2;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Couture", 20.2499981F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(280, 27);
            label1.TabIndex = 1;
            label1.Text = "CREATE DIET PLAN";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Azure;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(80, 458);
            panel2.TabIndex = 1;
            // 
            // mealPanel
            // 
            mealPanel.BackColor = Color.Azure;
            mealPanel.Dock = DockStyle.Right;
            mealPanel.Location = new Point(658, 60);
            mealPanel.Name = "mealPanel";
            mealPanel.Size = new Size(244, 458);
            mealPanel.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Azure;
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(80, 60);
            panel4.Name = "panel4";
            panel4.Size = new Size(578, 46);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Azure;
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(80, 457);
            panel5.Name = "panel5";
            panel5.Size = new Size(578, 61);
            panel5.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(42, 101, 97);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(btnCreate);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(panel7);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(80, 106);
            panel6.Name = "panel6";
            panel6.Size = new Size(578, 351);
            panel6.TabIndex = 5;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(22, 83);
            label6.Name = "label6";
            label6.Size = new Size(106, 25);
            label6.TabIndex = 14;
            label6.Text = "Plan Name";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(22, 125);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 12;
            label3.Text = "Goal";
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCreate.BackColor = Color.FromArgb(170, 52, 60);
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(6, 281);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(185, 42);
            btnCreate.TabIndex = 10;
            btnCreate.Text = "CREATE";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(21, 211);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 11;
            label4.Text = "Nutritions";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 166);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 9;
            label2.Text = "Type";
            // 
            // panel7
            // 
            panel7.BackColor = Color.MintCream;
            panel7.Controls.Add(statusCombo);
            panel7.Controls.Add(txtPlanName);
            panel7.Controls.Add(listGoals);
            panel7.Controls.Add(ListNutrition);
            panel7.Controls.Add(listType);
            panel7.Controls.Add(panelExercise);
            panel7.Controls.Add(btnAddMeal);
            panel7.Controls.Add(label5);
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(197, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(381, 351);
            panel7.TabIndex = 0;
            // 
            // statusCombo
            // 
            statusCombo.FormattingEnabled = true;
            statusCombo.Location = new Point(89, 262);
            statusCombo.Name = "statusCombo";
            statusCombo.Size = new Size(107, 23);
            statusCombo.TabIndex = 14;
            statusCombo.Text = "Private";
            // 
            // txtPlanName
            // 
            txtPlanName.Location = new Point(16, 88);
            txtPlanName.Name = "txtPlanName";
            txtPlanName.Size = new Size(180, 23);
            txtPlanName.TabIndex = 13;
            // 
            // listGoals
            // 
            listGoals.BackColor = Color.Transparent;
            listGoals.CustomizableEdges = customizableEdges1;
            listGoals.DrawMode = DrawMode.OwnerDrawFixed;
            listGoals.DropDownStyle = ComboBoxStyle.DropDownList;
            listGoals.FocusedColor = Color.FromArgb(94, 148, 255);
            listGoals.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            listGoals.Font = new Font("Segoe UI", 10F);
            listGoals.ForeColor = Color.FromArgb(68, 88, 112);
            listGoals.ItemHeight = 30;
            listGoals.Location = new Point(16, 124);
            listGoals.Name = "listGoals";
            listGoals.ShadowDecoration.CustomizableEdges = customizableEdges2;
            listGoals.Size = new Size(180, 36);
            listGoals.TabIndex = 11;
            // 
            // ListNutrition
            // 
            ListNutrition.BackColor = Color.Transparent;
            ListNutrition.CustomizableEdges = customizableEdges3;
            ListNutrition.DrawMode = DrawMode.OwnerDrawFixed;
            ListNutrition.DropDownStyle = ComboBoxStyle.DropDownList;
            ListNutrition.FocusedColor = Color.FromArgb(94, 148, 255);
            ListNutrition.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            ListNutrition.Font = new Font("Segoe UI", 10F);
            ListNutrition.ForeColor = Color.FromArgb(68, 88, 112);
            ListNutrition.ItemHeight = 30;
            ListNutrition.Location = new Point(16, 211);
            ListNutrition.Name = "ListNutrition";
            ListNutrition.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ListNutrition.Size = new Size(180, 36);
            ListNutrition.TabIndex = 10;
            // 
            // listType
            // 
            listType.BackColor = Color.Transparent;
            listType.CustomizableEdges = customizableEdges5;
            listType.DrawMode = DrawMode.OwnerDrawFixed;
            listType.DropDownStyle = ComboBoxStyle.DropDownList;
            listType.FocusedColor = Color.FromArgb(94, 148, 255);
            listType.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            listType.Font = new Font("Segoe UI", 10F);
            listType.ForeColor = Color.FromArgb(68, 88, 112);
            listType.ItemHeight = 30;
            listType.Location = new Point(16, 169);
            listType.Name = "listType";
            listType.ShadowDecoration.CustomizableEdges = customizableEdges6;
            listType.Size = new Size(180, 36);
            listType.TabIndex = 9;
            // 
            // panelExercise
            // 
            panelExercise.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelExercise.BackColor = Color.White;
            panelExercise.BorderStyle = BorderStyle.FixedSingle;
            panelExercise.Location = new Point(210, 43);
            panelExercise.Name = "panelExercise";
            panelExercise.Padding = new Padding(0, 5, 0, 0);
            panelExercise.Size = new Size(171, 308);
            panelExercise.TabIndex = 8;
            // 
            // btnAddMeal
            // 
            btnAddMeal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddMeal.FlatAppearance.BorderSize = 0;
            btnAddMeal.FlatStyle = FlatStyle.Flat;
            btnAddMeal.Image = (Image)resources.GetObject("btnAddMeal.Image");
            btnAddMeal.Location = new Point(348, 9);
            btnAddMeal.Name = "btnAddMeal";
            btnAddMeal.Size = new Size(27, 28);
            btnAddMeal.TabIndex = 7;
            btnAddMeal.UseVisualStyleBackColor = true;
            btnAddMeal.Click += btnAddMeal_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(210, 11);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 6;
            label5.Text = "Meals";
            // 
            // createDietPlancs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 518);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(mealPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "createDietPlancs";
            Text = "createDietPlancs";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel mealPanel;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Label label5;
        private Button btnAddMeal;
        private FlowLayoutPanel panelExercise;
        private Label label4;
        private Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox ListNutrition;
        private Guna.UI2.WinForms.Guna2ComboBox listType;
        private Label label1;
        private Button btnCreate;
        private Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox listGoals;
        private Button btnClose;
        private Label label6;
        private TextBox txtPlanName;
        private ComboBox statusCombo;
    }
}