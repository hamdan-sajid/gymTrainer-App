﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_FLEXTrainer.Essentials.MessageBoxes
{
    public partial class prompt : Form
    {
        public event EventHandler OKButtonClick;
        public prompt(string promptText)
        {
            InitializeComponent();
            label6.Text = promptText;
        }

        public void promptShow()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OKButtonClick?.Invoke(this, EventArgs.Empty);
            this.Close();
        }
    }
}
