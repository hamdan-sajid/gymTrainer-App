using Guna.Charts.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_FLEXTrainer.Forms.SubForms
{

    public partial class Profile : Form
    {
        User currentuser;
        Panel panel;
        Form ror;
        public Profile(Form fm, User user, Panel pane)
        {
            InitializeComponent();
            pfpuser.Text = user.Username;
            pfptype.Text = user.Type;
            currentuser = user;
            panel = pane;
            ror = fm;
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void OpenChildForm(Form childForm, object btnSender)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        Forms.SubForms.Profile_more SubForm;
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            if (SubForm == null || SubForm.IsDisposed)
            {
                OpenChildForm(new Forms.SubForms.Profile_Apply(currentuser), sender);
            }
            else
            {
                SubForm.BringToFront();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            login loginMember = new login();
         
            ror.Close();

            loginMember.Show();
            this.Close();
        }
    }
}
