namespace Project_FLEXTrainer.Owner.Forms
{
    partial class Manage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage));
            navPanel = new Panel();
            label4 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            btnRemove = new Button();
            label1 = new Label();
            name = new Label();
            panelContainer = new Panel();
            btnRequests = new Button();
            imageList1 = new ImageList(components);
            navPanel.SuspendLayout();
            panel1.SuspendLayout();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // navPanel
            // 
            navPanel.BackColor = Color.FromArgb(25, 42, 40);
            navPanel.Controls.Add(label4);
            navPanel.Controls.Add(panel1);
            navPanel.Dock = DockStyle.Top;
            navPanel.Location = new Point(0, 0);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(1270, 52);
            navPanel.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 15);
            label4.Name = "label4";
            label4.Size = new Size(284, 25);
            label4.TabIndex = 12;
            label4.Text = "MANAGE MEMBERS/TRAINERS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(126, 46, 53);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnRemove);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(name);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 119);
            panel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(35, 80);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 4;
            label2.Text = "Type";
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
            btnRemove.Location = new Point(592, 30);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(141, 65);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "REMOVE";
            btnRemove.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRemove.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(35, 50);
            label1.Name = "label1";
            label1.Size = new Size(234, 25);
            label1.TabIndex = 2;
            label1.Text = "Membership Type/ Rating";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            name.ForeColor = Color.White;
            name.Location = new Point(35, 18);
            name.Name = "name";
            name.Size = new Size(64, 25);
            name.TabIndex = 1;
            name.Text = "Name";
            // 
            // panelContainer
            // 
            panelContainer.AutoScroll = true;
            panelContainer.Controls.Add(btnRequests);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 52);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1270, 623);
            panelContainer.TabIndex = 3;
            // 
            // btnRequests
            // 
            btnRequests.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRequests.BackColor = Color.FromArgb(126, 46, 53);
            btnRequests.FlatAppearance.BorderSize = 0;
            btnRequests.FlatStyle = FlatStyle.Flat;
            btnRequests.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRequests.ForeColor = Color.White;
            btnRequests.Image = (Image)resources.GetObject("btnRequests.Image");
            btnRequests.ImageAlign = ContentAlignment.MiddleLeft;
            btnRequests.Location = new Point(970, 19);
            btnRequests.Name = "btnRequests";
            btnRequests.Padding = new Padding(10, 0, 0, 0);
            btnRequests.Size = new Size(288, 70);
            btnRequests.TabIndex = 8;
            btnRequests.Text = "   REQUESTS";
            btnRequests.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRequests.UseVisualStyleBackColor = false;
            btnRequests.Click += btnRequests_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "removeUser.png");
            // 
            // Manage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1270, 675);
            Controls.Add(panelContainer);
            Controls.Add(navPanel);
            Name = "Manage";
            Text = "Gym Management";
            navPanel.ResumeLayout(false);
            navPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel navPanel;
        private Panel panelContainer;
        private Button btnRequests;
        private Panel panel1;
        private Button btnRemove;
        private Label label1;
        private Label name;
        private ImageList imageList1;
        private Label label4;
        private Label label2;
    }
}