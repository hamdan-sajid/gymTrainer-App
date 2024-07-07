using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_FLEXTrainer.Forms
{
    public partial class mainHomecs : Form
    {
        public mainHomecs(User user)
        {
            InitializeComponent();
            CenterPictureBoxInPanel(pictureBox1, panel1);

            //label3.Text = user.Username + " to";
        }

        private void CenterPictureBoxInPanel(PictureBox pictureBox, Panel panel)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            int x = (panel.Width - pictureBox.Width) / 2;
            int y = (panel.Height - pictureBox.Height) / 2;
            pictureBox.Location = new Point(x, y);
        }
    }
}
