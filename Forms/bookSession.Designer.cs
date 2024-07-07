namespace Project_FLEXTrainer.Forms
{
    partial class bookSession
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookSession));
            topPanel = new Panel();
            filterPanel = new Panel();
            comboBox1 = new ComboBox();
            filterPic = new PictureBox();
            panelTxt = new Label();
            panelTemplate = new Panel();
            ID_hidden = new Label();
            panel1 = new Panel();
            button1 = new Button();
            ratingLabel = new Label();
            nameLabel = new Label();
            experienceLabel = new Label();
            genderLabel = new Label();
            panelContainer = new Panel();
            panel2 = new Panel();
            button2 = new Button();
            label2 = new Label();
            noMemberPanel = new Panel();
            closeError = new Button();
            label1 = new Label();
            imageList1 = new ImageList(components);
            topPanel.SuspendLayout();
            filterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)filterPic).BeginInit();
            panelTemplate.SuspendLayout();
            panelContainer.SuspendLayout();
            panel2.SuspendLayout();
            noMemberPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(26, 46, 53);
            topPanel.Controls.Add(filterPanel);
            topPanel.Controls.Add(panelTxt);
            topPanel.Controls.Add(panelTemplate);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1093, 54);
            topPanel.TabIndex = 2;
            // 
            // filterPanel
            // 
            filterPanel.BackColor = Color.FromArgb(42, 101, 97);
            filterPanel.Controls.Add(comboBox1);
            filterPanel.Controls.Add(filterPic);
            filterPanel.Dock = DockStyle.Right;
            filterPanel.Location = new Point(658, 0);
            filterPanel.Name = "filterPanel";
            filterPanel.Size = new Size(435, 54);
            filterPanel.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(259, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            // 
            // filterPic
            // 
            filterPic.Dock = DockStyle.Right;
            filterPic.Image = (Image)resources.GetObject("filterPic.Image");
            filterPic.InitialImage = (Image)resources.GetObject("filterPic.InitialImage");
            filterPic.Location = new Point(386, 0);
            filterPic.Name = "filterPic";
            filterPic.Padding = new Padding(5, 5, 10, 10);
            filterPic.Size = new Size(49, 54);
            filterPic.TabIndex = 0;
            filterPic.TabStop = false;
            // 
            // panelTxt
            // 
            panelTxt.AutoSize = true;
            panelTxt.Dock = DockStyle.Left;
            panelTxt.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            panelTxt.ForeColor = SystemColors.Control;
            panelTxt.Location = new Point(0, 0);
            panelTxt.Name = "panelTxt";
            panelTxt.Padding = new Padding(5, 10, 0, 0);
            panelTxt.Size = new Size(208, 35);
            panelTxt.TabIndex = 0;
            panelTxt.Text = "Book An Appointment";
            // 
            // panelTemplate
            // 
            panelTemplate.BackColor = Color.FromArgb(170, 52, 60);
            panelTemplate.Controls.Add(ID_hidden);
            panelTemplate.Controls.Add(panel1);
            panelTemplate.Controls.Add(button1);
            panelTemplate.Controls.Add(ratingLabel);
            panelTemplate.Controls.Add(nameLabel);
            panelTemplate.Controls.Add(experienceLabel);
            panelTemplate.Controls.Add(genderLabel);
            panelTemplate.Location = new Point(175, 12);
            panelTemplate.Name = "panelTemplate";
            panelTemplate.Padding = new Padding(20, 0, 0, 0);
            panelTemplate.Size = new Size(736, 78);
            panelTemplate.TabIndex = 3;
            // 
            // ID_hidden
            // 
            ID_hidden.AutoSize = true;
            ID_hidden.Location = new Point(354, 29);
            ID_hidden.Name = "ID_hidden";
            ID_hidden.Size = new Size(56, 15);
            ID_hidden.TabIndex = 7;
            ID_hidden.Text = "IdHidden";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 101, 97);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(84, 81);
            panel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(682, 20);
            button1.Name = "button1";
            button1.Size = new Size(42, 40);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            ratingLabel.ForeColor = Color.White;
            ratingLabel.Location = new Point(422, 39);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new Size(57, 21);
            ratingLabel.TabIndex = 4;
            ratingLabel.Text = "Rating";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(104, 11);
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
            experienceLabel.Location = new Point(422, 11);
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
            genderLabel.Location = new Point(104, 39);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(64, 21);
            genderLabel.TabIndex = 2;
            genderLabel.Text = "Gender";
            // 
            // panelContainer
            // 
            panelContainer.AutoScroll = true;
            panelContainer.BackColor = Color.WhiteSmoke;
            panelContainer.Controls.Add(panel2);
            panelContainer.Controls.Add(noMemberPanel);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1093, 623);
            panelContainer.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(126, 46, 53);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(1093, 43);
            panel2.TabIndex = 5;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(1056, 0);
            button2.Name = "button2";
            button2.Padding = new Padding(0, 10, 0, 0);
            button2.Size = new Size(37, 43);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(5, 14, 0, 0);
            label2.Size = new Size(1038, 43);
            label2.TabIndex = 0;
            label2.Text = "No gym Membership Yet, Apply first to book appointment";
            // 
            // noMemberPanel
            // 
            noMemberPanel.BackColor = Color.FromArgb(126, 46, 53);
            noMemberPanel.Controls.Add(closeError);
            noMemberPanel.Controls.Add(label1);
            noMemberPanel.Dock = DockStyle.Top;
            noMemberPanel.Location = new Point(0, 0);
            noMemberPanel.Name = "noMemberPanel";
            noMemberPanel.Size = new Size(1093, 43);
            noMemberPanel.TabIndex = 4;
            // 
            // closeError
            // 
            closeError.Dock = DockStyle.Right;
            closeError.FlatAppearance.BorderSize = 0;
            closeError.FlatStyle = FlatStyle.Flat;
            closeError.Image = (Image)resources.GetObject("closeError.Image");
            closeError.Location = new Point(1056, 0);
            closeError.Name = "closeError";
            closeError.Size = new Size(37, 43);
            closeError.TabIndex = 1;
            closeError.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(5, 7, 0, 0);
            label1.Size = new Size(425, 132);
            label1.TabIndex = 0;
            label1.Text = "Currently, you do not have a gym membership. \r\n\r\n\r\n\r\n\r\n";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "openview.png");
            // 
            // bookSession
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 623);
            Controls.Add(topPanel);
            Controls.Add(panelContainer);
            Name = "bookSession";
            Text = "Book Session";
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            filterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)filterPic).EndInit();
            panelTemplate.ResumeLayout(false);
            panelTemplate.PerformLayout();
            panelContainer.ResumeLayout(false);
            panel2.ResumeLayout(false);
            noMemberPanel.ResumeLayout(false);
            noMemberPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel topPanel;
        private Label panelTxt;
        private Panel filterPanel;
        private ComboBox comboBox1;
        private PictureBox filterPic;
        private Panel panelTemplate;
        private Guna.UI2.WinForms.Guna2CircleButton btnView;
        private Panel panelContainer;
        private Button button1;
        private Label ratingLabel;
        private Label nameLabel;
        private Label experienceLabel;
        private Label genderLabel;
        private Panel panel1;
        private ImageList imageList1;
        private Label ID_hidden;
        private Panel panel2;
        private Button button2;
        private Label label2;
        private Panel noMemberPanel;
        private Button closeError;
        private Label label1;
    }
}