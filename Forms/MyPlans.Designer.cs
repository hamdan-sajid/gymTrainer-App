namespace Project_FLEXTrainer.Forms
{
    partial class MyPlans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPlans));
            navPanel = new Panel();
            createdbyme = new Button();
            allplans = new Button();
            panelContainer = new Panel();
            panelTemplate = new Panel();
            hiddenID = new Label();
            panel1 = new Panel();
            button2 = new Button();
            nameLabel = new Label();
            experienceLabel = new Label();
            genderLabel = new Label();
            imageList1 = new ImageList(components);
            navPanel.SuspendLayout();
            panelTemplate.SuspendLayout();
            SuspendLayout();
            // 
            // navPanel
            // 
            navPanel.BackColor = Color.FromArgb(25, 42, 40);
            navPanel.Controls.Add(panelTemplate);
            navPanel.Controls.Add(createdbyme);
            navPanel.Controls.Add(allplans);
            navPanel.Dock = DockStyle.Top;
            navPanel.Location = new Point(0, 0);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(1093, 52);
            navPanel.TabIndex = 0;
            // 
            // createdbyme
            // 
            createdbyme.Dock = DockStyle.Left;
            createdbyme.FlatAppearance.BorderSize = 0;
            createdbyme.FlatStyle = FlatStyle.Flat;
            createdbyme.Font = new Font("Segoe UI", 14.25F);
            createdbyme.ForeColor = Color.White;
            createdbyme.Location = new Point(217, 0);
            createdbyme.Name = "createdbyme";
            createdbyme.Size = new Size(217, 52);
            createdbyme.TabIndex = 1;
            createdbyme.Text = "Diet Plan";
            createdbyme.UseVisualStyleBackColor = true;
            createdbyme.Click += createdbyme_Click;
            // 
            // allplans
            // 
            allplans.BackColor = Color.FromArgb(76, 126, 122);
            allplans.Dock = DockStyle.Left;
            allplans.FlatAppearance.BorderSize = 0;
            allplans.FlatStyle = FlatStyle.Flat;
            allplans.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            allplans.ForeColor = Color.White;
            allplans.Location = new Point(0, 0);
            allplans.Name = "allplans";
            allplans.Size = new Size(217, 52);
            allplans.TabIndex = 0;
            allplans.Text = "Workout Plan";
            allplans.UseVisualStyleBackColor = false;
            allplans.Click += allplans_Click;
            // 
            // panelContainer
            // 
            panelContainer.AutoScroll = true;
            panelContainer.BackColor = Color.WhiteSmoke;
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 52);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1093, 571);
            panelContainer.TabIndex = 6;
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
            panelTemplate.Location = new Point(131, 52);
            panelTemplate.Name = "panelTemplate";
            panelTemplate.Padding = new Padding(20, 0, 0, 0);
            panelTemplate.Size = new Size(821, 78);
            panelTemplate.TabIndex = 3;
            // 
            // hiddenID
            // 
            hiddenID.AutoSize = true;
            hiddenID.Location = new Point(364, 45);
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
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(144, 11);
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
            experienceLabel.Location = new Point(462, 11);
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
            genderLabel.Location = new Point(144, 39);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(64, 21);
            genderLabel.TabIndex = 2;
            genderLabel.Text = "Gender";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "close.png");
            // 
            // MyPlans
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1093, 623);
            Controls.Add(panelContainer);
            Controls.Add(navPanel);
            Name = "MyPlans";
            Text = "MyPlans";
            navPanel.ResumeLayout(false);
            panelTemplate.ResumeLayout(false);
            panelTemplate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel navPanel;
        private Button allplans;
        private Button createdbyme;
        private Panel panelContainer;
        private Panel panelTemplate;
        private Label hiddenID;
        private Panel panel1;
        private Button button2;
        private Label nameLabel;
        private Label experienceLabel;
        private Label genderLabel;
        private ImageList imageList1;
    }
}