using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_FLEXTrainer.Trainer
{
    public partial class home_trainer : Form
    {
        private bool pfpShow = false;
        private Button activeButton;
        private Form activeForm;
        User currentuser;
        public home_trainer(User user)
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
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!pfpShow)
            {
                if (SubForm == null || SubForm.IsDisposed)
                {
                    SubForm = new Project_FLEXTrainer.Forms.SubForms.Profile(home_trainer.ActiveForm, currentuser, this.desktopPanel);
                    SubForm.FormBorderStyle = FormBorderStyle.None;
                    SubForm.StartPosition = FormStartPosition.Manual;

                    // Calculate the position of the sub form relative to the button
                    Point p = guna2Button1.PointToScreen(Point.Empty);
                    SubForm.Location = new Point(p.X, p.Y + guna2Button1.Height);
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

        private void bntAppointments_Click(object sender, EventArgs e)
        {
            if ((Button)sender != (Button)activeButton)
                OpenChildForm(new Forms.manageAppointments(currentuser, this.desktopPanel), sender);
        }

        private void btnCreateWP_Click(object sender, EventArgs e)
        {
            if ((Button)sender != (Button)activeButton)
                OpenChildForm(new Forms.createWorkoutPlan(currentuser), sender);
        }

        private void btnCreateDP_Click(object sender, EventArgs e)
        {
            if ((Button)sender != (Button)activeButton)
                OpenChildForm(new Forms.createDietPlan(currentuser), sender);
        }

        private void btnViewPlans_Click(object sender, EventArgs e)
        {
            if ((Button)sender != (Button)activeButton)
                OpenChildForm(new Forms.ViewPlans(currentuser, this.desktopPanel), sender);
        }

        private void btnFeedbacks_Click(object sender, EventArgs e)
        {
            if ((Button)sender != (Button)activeButton)
                OpenChildForm(new Forms.Feedbacks(currentuser), sender);
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            activeForm.Close();
            Form childForm = new Project_FLEXTrainer.Forms.mainHomecs(currentuser);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.desktopPanel.Controls.Add(childForm);
            this.desktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnViewMem_Click(object sender, EventArgs e)
        {
            if ((Button)sender != (Button)activeButton)
                OpenChildForm(new Forms.viewMembers(currentuser), sender);

        }
    }
}
