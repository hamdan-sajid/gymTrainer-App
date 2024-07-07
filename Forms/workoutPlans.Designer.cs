namespace Project_FLEXTrainer.Forms
{
    partial class workoutPlans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(workoutPlans));
            btnCreateWP = new Button();
            topPanel = new Panel();
            comboBox5 = new ComboBox();
            comboBox4 = new ComboBox();
            btnrefresh = new Button();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            panelTemplate = new Panel();
            hiddenID = new Label();
            panel1 = new Panel();
            button2 = new Button();
            nameLabel = new Label();
            experienceLabel = new Label();
            genderLabel = new Label();
            panelContainer = new Panel();
            imageList1 = new ImageList(components);
            topPanel.SuspendLayout();
            panelTemplate.SuspendLayout();
            SuspendLayout();
            // 
            // btnCreateWP
            // 
            btnCreateWP.BackColor = Color.FromArgb(42, 101, 97);
            btnCreateWP.Dock = DockStyle.Right;
            btnCreateWP.FlatAppearance.BorderSize = 0;
            btnCreateWP.FlatStyle = FlatStyle.Flat;
            btnCreateWP.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateWP.ForeColor = Color.White;
            btnCreateWP.Location = new Point(1050, 0);
            btnCreateWP.Name = "btnCreateWP";
            btnCreateWP.Size = new Size(168, 58);
            btnCreateWP.TabIndex = 1;
            btnCreateWP.Text = "CREATE";
            btnCreateWP.UseVisualStyleBackColor = false;
            btnCreateWP.Click += btnCreateWP_Click;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(26, 46, 53);
            topPanel.Controls.Add(panelTemplate);
            topPanel.Controls.Add(comboBox5);
            topPanel.Controls.Add(comboBox4);
            topPanel.Controls.Add(btnrefresh);
            topPanel.Controls.Add(comboBox3);
            topPanel.Controls.Add(comboBox2);
            topPanel.Controls.Add(comboBox1);
            topPanel.Controls.Add(button1);
            topPanel.Controls.Add(btnCreateWP);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1218, 58);
            topPanel.TabIndex = 0;
            // 
            // comboBox5
            // 
            comboBox5.Anchor = AnchorStyles.Right;
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(375, 18);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(121, 23);
            comboBox5.TabIndex = 18;
            comboBox5.Text = "Not Machine";
            comboBox5.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // comboBox4
            // 
            comboBox4.Anchor = AnchorStyles.Right;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(502, 18);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 17;
            comboBox4.Text = "Machine";
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // btnrefresh
            // 
            btnrefresh.FlatAppearance.BorderSize = 0;
            btnrefresh.FlatStyle = FlatStyle.Flat;
            btnrefresh.Image = (Image)resources.GetObject("btnrefresh.Image");
            btnrefresh.Location = new Point(3, 3);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(53, 46);
            btnrefresh.TabIndex = 16;
            btnrefresh.UseVisualStyleBackColor = true;
            btnrefresh.Click += btnrefresh_Click;
            // 
            // comboBox3
            // 
            comboBox3.Anchor = AnchorStyles.Right;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(631, 18);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 14;
            comboBox3.Text = "Goal";
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Right;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(758, 18);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 13;
            comboBox2.Text = "Schedule";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(884, 19);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 12;
            comboBox1.Text = "Experience Level";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(1020, 0);
            button1.Name = "button1";
            button1.Size = new Size(30, 58);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = false;
            // 
            // panelTemplate
            // 
            panelTemplate.BackColor = Color.FromArgb(170, 52, 60);
            panelTemplate.Controls.Add(hiddenID);
            panelTemplate.Controls.Add(panel1);
            panelTemplate.Controls.Add(button2);
            panelTemplate.Controls.Add(nameLabel);
            panelTemplate.Controls.Add(experienceLabel);
            panelTemplate.Controls.Add(genderLabel);
            panelTemplate.Location = new Point(131, 19);
            panelTemplate.Name = "panelTemplate";
            panelTemplate.Padding = new Padding(20, 0, 0, 0);
            panelTemplate.Size = new Size(821, 78);
            panelTemplate.TabIndex = 3;
            // 
            // hiddenID
            // 
            hiddenID.AutoSize = true;
            hiddenID.Location = new Point(344, 45);
            hiddenID.Name = "hiddenID";
            hiddenID.Size = new Size(55, 15);
            hiddenID.TabIndex = 7;
            hiddenID.Text = "hiddenID";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 101, 97);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(84, 81);
            panel1.TabIndex = 6;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(757, 20);
            button2.Name = "button2";
            button2.Size = new Size(64, 40);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(124, 11);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(53, 21);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name";
            // 
            // experienceLabel
            // 
            experienceLabel.AutoSize = true;
            experienceLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            experienceLabel.ForeColor = Color.White;
            experienceLabel.Location = new Point(442, 11);
            experienceLabel.Name = "experienceLabel";
            experienceLabel.Size = new Size(90, 21);
            experienceLabel.TabIndex = 3;
            experienceLabel.Text = "Experience";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            genderLabel.ForeColor = Color.White;
            genderLabel.Location = new Point(124, 39);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(64, 21);
            genderLabel.TabIndex = 2;
            genderLabel.Text = "Gender";
            // 
            // panelContainer
            // 
            panelContainer.AutoScroll = true;
            panelContainer.BackColor = Color.WhiteSmoke;
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 58);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1218, 598);
            panelContainer.TabIndex = 5;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "add4.png");
            // 
            // workoutPlans
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(196, 210, 245);
            ClientSize = new Size(1218, 656);
            Controls.Add(panelContainer);
            Controls.Add(topPanel);
            Name = "workoutPlans";
            Text = "Workout Plans";
            topPanel.ResumeLayout(false);
            panelTemplate.ResumeLayout(false);
            panelTemplate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnCreateWP;
        private Panel topPanel;
        private Button button1;
        private ComboBox comboBox1;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private Guna.UI2.WinForms.Guna2TextBox searchBar;
        private Panel panelContainer;
        private Panel panelTemplate;
        private Panel panel1;
        private Button button2;
        private Label nameLabel;
        private Label experienceLabel;
        private Label genderLabel;
        private ImageList imageList1;
        private Button btnrefresh;
        private Label hiddenID;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
    }
}