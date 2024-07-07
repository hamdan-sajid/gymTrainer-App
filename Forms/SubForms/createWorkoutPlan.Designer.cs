namespace Project_FLEXTrainer.Forms.SubForms
{
    partial class createWorkoutPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createWorkoutPlan));
            panel1 = new Panel();
            panelMain = new Panel();
            label6 = new Label();
            btnCreate = new Button();
            label4 = new Label();
            devidePanel = new Panel();
            statusCombo = new ComboBox();
            txtPlanName = new TextBox();
            panel6 = new Panel();
            btnAddExercise = new Button();
            label5 = new Label();
            panelExercise = new FlowLayoutPanel();
            ExpCombo = new ComboBox();
            ScheduleCombo = new ComboBox();
            goalCombo = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            panel5 = new Panel();
            panel4 = new Panel();
            exPanel = new Panel();
            panel2 = new Panel();
            txtPanel = new Panel();
            btnClose = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            panelMain.SuspendLayout();
            devidePanel.SuspendLayout();
            panel6.SuspendLayout();
            txtPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Azure;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(panelMain);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(exPanel);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(911, 549);
            panel1.TabIndex = 0;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(42, 101, 97);
            panelMain.Controls.Add(label6);
            panelMain.Controls.Add(btnCreate);
            panelMain.Controls.Add(label4);
            panelMain.Controls.Add(devidePanel);
            panelMain.Controls.Add(label3);
            panelMain.Controls.Add(label2);
            panelMain.Location = new Point(27, 106);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(621, 378);
            panelMain.TabIndex = 5;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(27, 67);
            label6.Name = "label6";
            label6.Size = new Size(106, 25);
            label6.TabIndex = 10;
            label6.Text = "Plan Name";
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCreate.BackColor = Color.FromArgb(170, 52, 60);
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(27, 307);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(133, 42);
            btnCreate.TabIndex = 9;
            btnCreate.Text = "CREATE";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(27, 215);
            label4.Name = "label4";
            label4.Size = new Size(154, 25);
            label4.TabIndex = 8;
            label4.Text = "Experience Level";
            // 
            // devidePanel
            // 
            devidePanel.BackColor = Color.MintCream;
            devidePanel.BorderStyle = BorderStyle.FixedSingle;
            devidePanel.Controls.Add(statusCombo);
            devidePanel.Controls.Add(txtPlanName);
            devidePanel.Controls.Add(panel6);
            devidePanel.Controls.Add(panelExercise);
            devidePanel.Controls.Add(ExpCombo);
            devidePanel.Controls.Add(ScheduleCombo);
            devidePanel.Controls.Add(goalCombo);
            devidePanel.Dock = DockStyle.Right;
            devidePanel.Location = new Point(182, 0);
            devidePanel.Name = "devidePanel";
            devidePanel.Size = new Size(439, 378);
            devidePanel.TabIndex = 0;
            // 
            // statusCombo
            // 
            statusCombo.FormattingEnabled = true;
            statusCombo.Location = new Point(23, 261);
            statusCombo.Name = "statusCombo";
            statusCombo.Size = new Size(107, 23);
            statusCombo.TabIndex = 5;
            statusCombo.Text = "Private";
            // 
            // txtPlanName
            // 
            txtPlanName.Location = new Point(23, 71);
            txtPlanName.Name = "txtPlanName";
            txtPlanName.Size = new Size(160, 23);
            txtPlanName.TabIndex = 4;
            txtPlanName.TextChanged += txtPlanName_TextChanged;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel6.BackColor = Color.MintCream;
            panel6.Controls.Add(btnAddExercise);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(266, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(171, 31);
            panel6.TabIndex = 0;
            // 
            // btnAddExercise
            // 
            btnAddExercise.FlatAppearance.BorderSize = 0;
            btnAddExercise.FlatStyle = FlatStyle.Flat;
            btnAddExercise.Image = (Image)resources.GetObject("btnAddExercise.Image");
            btnAddExercise.Location = new Point(138, 3);
            btnAddExercise.Name = "btnAddExercise";
            btnAddExercise.Size = new Size(27, 28);
            btnAddExercise.TabIndex = 1;
            btnAddExercise.UseVisualStyleBackColor = true;
            btnAddExercise.Click += btnAddExercise_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(3, 3);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 0;
            label5.Text = "Exercises";
            // 
            // panelExercise
            // 
            panelExercise.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelExercise.BackColor = Color.White;
            panelExercise.BorderStyle = BorderStyle.FixedSingle;
            panelExercise.Location = new Point(266, 37);
            panelExercise.Name = "panelExercise";
            panelExercise.Padding = new Padding(0, 5, 0, 0);
            panelExercise.Size = new Size(171, 360);
            panelExercise.TabIndex = 3;
            // 
            // ExpCombo
            // 
            ExpCombo.FormattingEnabled = true;
            ExpCombo.Location = new Point(23, 214);
            ExpCombo.Name = "ExpCombo";
            ExpCombo.Size = new Size(160, 23);
            ExpCombo.TabIndex = 2;
            // 
            // ScheduleCombo
            // 
            ScheduleCombo.FormattingEnabled = true;
            ScheduleCombo.Location = new Point(23, 167);
            ScheduleCombo.Name = "ScheduleCombo";
            ScheduleCombo.Size = new Size(160, 23);
            ScheduleCombo.TabIndex = 1;
            // 
            // goalCombo
            // 
            goalCombo.FormattingEnabled = true;
            goalCombo.Location = new Point(23, 116);
            goalCombo.Name = "goalCombo";
            goalCombo.Size = new Size(160, 23);
            goalCombo.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(27, 163);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 7;
            label3.Text = "Schedule";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 112);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 6;
            label2.Text = "Goal";
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(27, 484);
            panel5.Name = "panel5";
            panel5.Size = new Size(621, 61);
            panel5.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(27, 60);
            panel4.Name = "panel4";
            panel4.Size = new Size(621, 46);
            panel4.TabIndex = 3;
            // 
            // exPanel
            // 
            exPanel.Dock = DockStyle.Right;
            exPanel.Location = new Point(648, 60);
            exPanel.Name = "exPanel";
            exPanel.Size = new Size(259, 485);
            exPanel.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Azure;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(27, 485);
            panel2.TabIndex = 1;
            // 
            // txtPanel
            // 
            txtPanel.BackColor = Color.FromArgb(42, 101, 97);
            txtPanel.Controls.Add(btnClose);
            txtPanel.Controls.Add(label1);
            txtPanel.Dock = DockStyle.Top;
            txtPanel.Location = new Point(0, 0);
            txtPanel.Name = "txtPanel";
            txtPanel.Size = new Size(907, 60);
            txtPanel.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(877, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(27, 23);
            btnClose.TabIndex = 1;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.2499981F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 16);
            label1.Name = "label1";
            label1.Size = new Size(371, 31);
            label1.TabIndex = 0;
            label1.Text = "CREATE WORKOUT PLAN";
            // 
            // createWorkoutPlan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(911, 549);
            Controls.Add(panel1);
            Name = "createWorkoutPlan";
            Text = "createWorkoutPlan";
            panel1.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            devidePanel.ResumeLayout(false);
            devidePanel.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            txtPanel.ResumeLayout(false);
            txtPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel txtPanel;
        private Label label1;
        private Panel exPanel;
        private Panel panel2;
        private Button btnClose;
        private Panel panelMain;
        private Panel panel5;
        private Panel panel4;
        private Label label4;
        private Panel devidePanel;
        private Label label3;
        private Label label2;
        private ComboBox ExpCombo;
        private ComboBox ScheduleCombo;
        private ComboBox goalCombo;
        private Button btnCreate;
        private FlowLayoutPanel panelExercise;
        private Panel panel6;
        private Label label5;
        private Button btnAddExercise;
        private Label label6;
        private TextBox txtPlanName;
        private ComboBox statusCombo;
    }
}