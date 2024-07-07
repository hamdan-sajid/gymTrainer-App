namespace Project_FLEXTrainer.Owner.Forms.SubForm
{
    partial class Requests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Requests));
            panel1 = new Panel();
            panelTemplate = new Panel();
            rejectBtn = new Button();
            acceptBtn = new Button();
            btnReject = new Button();
            btnAccept = new Button();
            txtSpecs = new Label();
            txtQual = new Label();
            btnRemove = new Button();
            txtExp = new Label();
            txtName = new Label();
            button1 = new Button();
            name = new Label();
            imageList1 = new ImageList(components);
            panelContainer = new Panel();
            panel1.SuspendLayout();
            panelTemplate.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 46, 53);
            panel1.Controls.Add(panelTemplate);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(name);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(625, 62);
            panel1.TabIndex = 0;
            // 
            // panelTemplate
            // 
            panelTemplate.BackColor = Color.FromArgb(126, 46, 53);
            panelTemplate.Controls.Add(rejectBtn);
            panelTemplate.Controls.Add(acceptBtn);
            panelTemplate.Controls.Add(btnReject);
            panelTemplate.Controls.Add(btnAccept);
            panelTemplate.Controls.Add(txtSpecs);
            panelTemplate.Controls.Add(txtQual);
            panelTemplate.Controls.Add(btnRemove);
            panelTemplate.Controls.Add(txtExp);
            panelTemplate.Controls.Add(txtName);
            panelTemplate.Location = new Point(0, 12);
            panelTemplate.Name = "panelTemplate";
            panelTemplate.Size = new Size(625, 162);
            panelTemplate.TabIndex = 5;
            // 
            // rejectBtn
            // 
            rejectBtn.BackColor = Color.FromArgb(25, 42, 40);
            rejectBtn.FlatAppearance.BorderSize = 0;
            rejectBtn.FlatStyle = FlatStyle.Flat;
            rejectBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rejectBtn.ForeColor = Color.White;
            rejectBtn.Location = new Point(476, 124);
            rejectBtn.Name = "rejectBtn";
            rejectBtn.Size = new Size(76, 35);
            rejectBtn.TabIndex = 9;
            rejectBtn.Text = "REJECT";
            rejectBtn.UseVisualStyleBackColor = false;
            // 
            // acceptBtn
            // 
            acceptBtn.BackColor = Color.FromArgb(25, 42, 40);
            acceptBtn.FlatAppearance.BorderSize = 0;
            acceptBtn.FlatStyle = FlatStyle.Flat;
            acceptBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            acceptBtn.ForeColor = Color.White;
            acceptBtn.Location = new Point(476, 83);
            acceptBtn.Name = "acceptBtn";
            acceptBtn.Size = new Size(76, 35);
            acceptBtn.TabIndex = 8;
            acceptBtn.Text = "ACCEPT";
            acceptBtn.UseVisualStyleBackColor = false;
            // 
            // btnReject
            // 
            btnReject.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReject.FlatAppearance.BorderSize = 0;
            btnReject.FlatStyle = FlatStyle.Flat;
            btnReject.ForeColor = SystemColors.ControlLight;
            btnReject.Image = (Image)resources.GetObject("btnReject.Image");
            btnReject.Location = new Point(829, 45);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(51, 36);
            btnReject.TabIndex = 7;
            btnReject.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            btnAccept.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAccept.FlatAppearance.BorderSize = 0;
            btnAccept.FlatStyle = FlatStyle.Flat;
            btnAccept.ForeColor = SystemColors.ControlLight;
            btnAccept.Image = (Image)resources.GetObject("btnAccept.Image");
            btnAccept.Location = new Point(832, 9);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(48, 36);
            btnAccept.TabIndex = 6;
            btnAccept.UseVisualStyleBackColor = true;
            // 
            // txtSpecs
            // 
            txtSpecs.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            txtSpecs.ForeColor = Color.White;
            txtSpecs.Location = new Point(22, 96);
            txtSpecs.Name = "txtSpecs";
            txtSpecs.Size = new Size(480, 25);
            txtSpecs.TabIndex = 5;
            txtSpecs.Text = "Specialization:";
            // 
            // txtQual
            // 
            txtQual.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            txtQual.ForeColor = Color.White;
            txtQual.Location = new Point(22, 45);
            txtQual.Name = "txtQual";
            txtQual.Size = new Size(518, 25);
            txtQual.TabIndex = 4;
            txtQual.Text = "Qualification:";
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnRemove.BackColor = Color.FromArgb(76, 126, 122);
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = Color.WhiteSmoke;
            btnRemove.Image = (Image)resources.GetObject("btnRemove.Image");
            btnRemove.Location = new Point(1251, 45);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(141, 141);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "REMOVE";
            btnRemove.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRemove.UseVisualStyleBackColor = false;
            // 
            // txtExp
            // 
            txtExp.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            txtExp.ForeColor = Color.White;
            txtExp.Location = new Point(22, 69);
            txtExp.Name = "txtExp";
            txtExp.Size = new Size(510, 25);
            txtExp.TabIndex = 2;
            txtExp.Text = "Experience:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(22, 20);
            txtName.Name = "txtName";
            txtName.Size = new Size(518, 25);
            txtName.TabIndex = 1;
            txtName.Text = "Name: ";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(588, 0);
            button1.Name = "button1";
            button1.Size = new Size(37, 43);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            name.ForeColor = Color.White;
            name.Location = new Point(12, 9);
            name.Name = "name";
            name.Size = new Size(146, 37);
            name.TabIndex = 2;
            name.Text = "REQUESTS";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "add4.png");
            imageList1.Images.SetKeyName(1, "close.png");
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.WhiteSmoke;
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 62);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(625, 536);
            panelContainer.TabIndex = 1;
            // 
            // Requests
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(625, 598);
            Controls.Add(panelContainer);
            Controls.Add(panel1);
            Name = "Requests";
            Text = "Requests";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelTemplate.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label name;
        private ImageList imageList1;
        private Panel panelContainer;
        private Panel panelTemplate;
        private Button btnReject;
        private Button btnAccept;
        private Label txtSpecs;
        private Label txtQual;
        private Button btnRemove;
        private Label txtExp;
        private Label txtName;
        private Button acceptBtn;
        private Button rejectBtn;
        private Button button1;
    }
}