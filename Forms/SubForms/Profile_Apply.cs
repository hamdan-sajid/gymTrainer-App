using Guna.Charts.WinForms;
using Project_FLEXTrainer.Essentials.MessageBoxes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_FLEXTrainer.Forms.SubForms
{
    public partial class Profile_Apply : Form
    {
        Form activeForm;
        User currUser;
        public Profile_Apply(User user)
        {
            InitializeComponent();
            currUser = user;
            if (currUser.isProfileComplete == true)
            {
                profileoptionLabel.Text = "Edit Profle";
                guna2Button3.Text = "Edit";
            }
            else
            {
                profileoptionLabel.Text = "Complete Profile";
                guna2Button3.Text = "Complete";
            }
        }




        private void guna2Button3_Click(object sender, EventArgs e) //btnCompleteProfile
        {
            OpenChildForm(new Forms.SubForms.completeProfile(currUser), sender);
        }

        private void btnApply_Click(object sender, EventArgs e) //Apply as Trainer
        {
            if (currUser.isProfileComplete == false)
            {
                Form messageBox = new customMessage_CompleteProfile();
                messageBox.FormBorderStyle = FormBorderStyle.None;
                messageBox.StartPosition = FormStartPosition.CenterScreen;
                messageBox.Show();

                return;
            }
            OpenChildForm(new Forms.SubForms.ApplyForTrainer(currUser), sender);
        }

        private void btnApplyOwner_Click(object sender, EventArgs e)
            
        {
            if (currUser.isProfileComplete == false)
            {
                Form messageBox = new customMessage_CompleteProfile();
                messageBox.FormBorderStyle = FormBorderStyle.None;
                messageBox.StartPosition = FormStartPosition.CenterScreen;
                messageBox.Show();

                return;
            }
            OpenChildForm(new Forms.SubForms.ApplyForOwner(currUser), sender);
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm == (Form)childForm)
                return;
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.subFormPanel.Controls.Add(childForm);
            this.subFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

    
    }
}
