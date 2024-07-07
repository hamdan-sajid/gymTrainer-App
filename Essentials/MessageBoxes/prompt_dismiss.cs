using System;
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
    public partial class prompt_dismiss : Form
    {
        public prompt_dismiss(string promptText)
        {
            InitializeComponent();
            label6.Text = promptText;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
