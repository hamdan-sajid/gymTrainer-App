using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_FLEXTrainer.Admin
{
    public partial class home_admin : Form
    {

        private bool pfpShow = false;
        private Button activeButton;
        private static home_admin instance;
        private Form activeForm;
        User currentuser;
        public home_admin(User user)
        {
            InitializeComponent();
            currentuser = user;
            label3.Text = user.Username;
            label2.Text = user.Type;
        }

        private void activateBtn(object sender)
        {
            if (sender != null)
            {
                if (activeButton != (Button)sender)
                {
                    disableBtn();
                    Color color = ColorTranslator.FromHtml("#FF4F5A");
                    activeButton = (Button)sender;
                    activeButton.BackColor = color;
                    activeButton.ForeColor = Color.White;
                    activeButton.Font = new Font("Ebrima", 13.25F, FontStyle.Bold);


                }
            }
        }

        private void disableBtn()
        {
            foreach (Control prevbtn in panelMenu.Controls)
            {
                if (prevbtn.GetType() == typeof(Button))
                {
                    prevbtn.BackColor = Color.FromArgb(50, 72, 76);
                    prevbtn.ForeColor = Color.Gainsboro;
                    prevbtn.Font = new Font("Ebrima", 12.25F);
                }
            }
        }

        public static void CloseSelf()
        {
            if (instance != null)
            {
                instance.Close();
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activateBtn(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.desktopPanel.Controls.Add(childForm);
            this.desktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            pgTitle.Text = childForm.Text;
            //tabPic.Image. = ;
        }
        private void SubForm_Deactivate(object sender, EventArgs e)
        {
            if (!SubForm.ClientRectangle.Contains(SubForm.PointToClient(Control.MousePosition)))
            {
                // If the mouse is not within the bounds of the sub form, close it
                SubForm.Close();
                pfpShow = false;
            }
        }
        Project_FLEXTrainer.Forms.SubForms.Profile SubForm;


        private void pfpBtn_Click(object sender, EventArgs e)
        {
            if (!pfpShow)
            {
                if (SubForm == null || SubForm.IsDisposed)
                {
                    SubForm = new Project_FLEXTrainer.Forms.SubForms.Profile(this, currentuser,this.desktopPanel);
                    SubForm.FormBorderStyle = FormBorderStyle.None;
                    SubForm.StartPosition = FormStartPosition.Manual;
                    //SubForm.BringToFront();
                    // Calculate the position of the sub form relative to the button
                    Point p = pfpBtn.PointToScreen(Point.Empty);
                    SubForm.Location = new Point(p.X, p.Y + pfpBtn.Height);
                    //SubForm.Deactivate += SubForm_Deactivate;
                    /// SubForm.MouseDown.
                    SubForm.Show();
                }
                else
                {
                    SubForm.BringToFront();
                }
                pfpShow = true;
            }
            else
            {
                SubForm.Close();
                pfpShow = false;
            }
        }

        private void btnGymPerf_Click(object sender, EventArgs e)
        {
            if ((Button)sender != (Button)activeButton)
                OpenChildForm(new Forms.gymPerformances(currentuser), sender);
        }

        private void btnReq_Click(object sender, EventArgs e)
        {
            if ((Button)sender != (Button)activeButton)
                OpenChildForm(new Forms.Requests(this.desktopPanel, currentuser), sender);
        }

        private void btnRevoke_Click(object sender, EventArgs e)
        {
            if ((Button)sender != (Button)activeButton)
                OpenChildForm(new Forms.revokeGym(this.desktopPanel), sender);
        }
    }
}
