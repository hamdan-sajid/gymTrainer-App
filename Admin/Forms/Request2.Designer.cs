namespace Project_FLEXTrainer.Admin.Forms
{
    partial class Request2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Request2));
            navPanel = new Panel();
            btnArchived = new Button();
            btnPending = new Button();
            pgTitle = new Label();
            panelContainer = new Panel();
            panelTemplate = new Panel();
            panel1 = new Panel();
            button2 = new Button();
            nameLabel = new Label();
            experienceLabel = new Label();
            genderLabel = new Label();
            imageList1 = new ImageList(components);
            navPanel.SuspendLayout();
            panelContainer.SuspendLayout();
            panelTemplate.SuspendLayout();
            SuspendLayout();
            // 
            // navPanel
            // 
            navPanel.BackColor = Color.FromArgb(25, 42, 40);
            navPanel.Controls.Add(btnArchived);
            navPanel.Controls.Add(btnPending);
            navPanel.Controls.Add(pgTitle);
            navPanel.Dock = DockStyle.Top;
            navPanel.Location = new Point(0, 0);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(1167, 52);
            navPanel.TabIndex = 4;
            // 
            // btnArchived
            // 
            btnArchived.Dock = DockStyle.Right;
            btnArchived.FlatAppearance.BorderSize = 0;
            btnArchived.FlatStyle = FlatStyle.Flat;
            btnArchived.Font = new Font("Segoe UI", 14.25F);
            btnArchived.ForeColor = Color.White;
            btnArchived.Location = new Point(567, 0);
            btnArchived.Name = "btnArchived";
            btnArchived.Size = new Size(316, 52);
            btnArchived.TabIndex = 14;
            btnArchived.Text = "ARCHIVED";
            btnArchived.UseVisualStyleBackColor = true;
            btnArchived.Click += btnArchived_Click;
            // 
            // btnPending
            // 
            btnPending.BackColor = Color.FromArgb(76, 126, 122);
            btnPending.Dock = DockStyle.Right;
            btnPending.FlatAppearance.BorderSize = 0;
            btnPending.FlatStyle = FlatStyle.Flat;
            btnPending.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPending.ForeColor = Color.White;
            btnPending.Location = new Point(883, 0);
            btnPending.Name = "btnPending";
            btnPending.Size = new Size(284, 52);
            btnPending.TabIndex = 13;
            btnPending.Text = "PENDING";
            btnPending.UseVisualStyleBackColor = false;
            btnPending.Click += btnPending_Click;
            // 
            // pgTitle
            // 
            pgTitle.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pgTitle.ForeColor = Color.White;
            pgTitle.Location = new Point(0, -11);
            pgTitle.Name = "pgTitle";
            pgTitle.Padding = new Padding(10, 20, 0, 0);
            pgTitle.Size = new Size(318, 63);
            pgTitle.TabIndex = 12;
            pgTitle.Text = "Registration Requests";
            // 
            // panelContainer
            // 
            panelContainer.AutoScroll = true;
            panelContainer.BackColor = Color.WhiteSmoke;
            panelContainer.Controls.Add(panelTemplate);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 52);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1167, 544);
            panelContainer.TabIndex = 6;
            // 
            // panelTemplate
            // 
            panelTemplate.BackColor = Color.FromArgb(170, 52, 60);
            panelTemplate.Controls.Add(panel1);
            panelTemplate.Controls.Add(button2);
            panelTemplate.Controls.Add(nameLabel);
            panelTemplate.Controls.Add(experienceLabel);
            panelTemplate.Controls.Add(genderLabel);
            panelTemplate.Location = new Point(161, 20);
            panelTemplate.Name = "panelTemplate";
            panelTemplate.Padding = new Padding(20, 0, 0, 0);
            panelTemplate.Size = new Size(821, 78);
            panelTemplate.TabIndex = 4;
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
            // Request2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 596);
            Controls.Add(panelContainer);
            Controls.Add(navPanel);
            Name = "Request2";
            Text = "Request2";
            navPanel.ResumeLayout(false);
            panelContainer.ResumeLayout(false);
            panelTemplate.ResumeLayout(false);
            panelTemplate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel navPanel;
        private Button btnArchived;
        private Button btnPending;
        private Label pgTitle;
        private Panel panelContainer;
        private Panel panelTemplate;
        private Panel panel1;
        private Button button2;
        private Label nameLabel;
        private Label experienceLabel;
        private Label genderLabel;
        private ImageList imageList1;
    }
}