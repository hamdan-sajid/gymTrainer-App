using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_FLEXTrainer.Owner
{
    public partial class home_owner : Form
    {
        bool pfpShow = false;
        private Button activeButton;
        private Form activeForm;
        User currentuser;
        string connectionString;

        public home_owner(User user)
        {
            InitializeComponent();
            currentuser = user;
            label3.Text = user.Username;
            label2.Text = user.Type;
            connectionString = Essentials.ConnectionString.GetConnectionString();

            string query = "SELECT 1\r\nFROM gymMembership\r\nINNER JOIN gym on gymID = gym.id\r\nINNER JOIN owner on owner.id = gym.owner_id\r\nINNER JOIN userr on owner.id = userr.id\r\nWHERE username = @userName";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command= new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@userName", currentuser.Username);

            object result = command.ExecuteScalar();



            if(result==null){
                Form details = new Forms.SubForm.membershipDetails(currentuser);
                
                details.FormBorderStyle = FormBorderStyle.None;
                details.StartPosition = FormStartPosition.CenterScreen;
                details.Deactivate += (sender, e) =>
                {
                    details.TopMost = true;
                };

                // Show the form
                details.Show();

                // Bring the form to the front
                details.BringToFront();
                details.Show();

                return;
            }
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
       
        private void btnGymReports_Click(object sender, EventArgs e)
        {
            if ((Button)sender != (Button)activeButton)
                OpenChildForm(new Forms.GymReport(currentuser), sender);
        }

        private void btnMemberReports_Click(object sender, EventArgs e)
        {
            if ((Button)sender != (Button)activeButton)
                OpenChildForm(new Forms.MemberReports(currentuser), sender);
        }

        private void btnTrainerReports_Click(object sender, EventArgs e)
        {
            if ((Button)sender != (Button)activeButton)
                OpenChildForm(new Forms.TrainerReports(currentuser), sender);
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            if ((Button)sender != (Button)activeButton)
                OpenChildForm(new Forms.Manage(currentuser), sender);
        }


        private void btnAddTrainer_Click(object sender, EventArgs e)
        {
            if ((Button)sender != (Button)activeButton)
                OpenChildForm(new Forms.addTrainer(currentuser), sender);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!pfpShow)
            {
                if (SubForm == null || SubForm.IsDisposed)
                {
                    SubForm = new Project_FLEXTrainer.Forms.SubForms.Profile(this,currentuser,this.desktopPanel);
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
    }
}
