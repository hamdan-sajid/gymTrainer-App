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

namespace Project_FLEXTrainer.Forms
{
    public partial class Appointments : Form
    {
        User user;
        string stringConnection;
        private Button activeButton;
        private Panel panel;
        public Appointments(Panel panel, User user)
        {
            InitializeComponent();
            this.user = user;
            stringConnection = Essentials.ConnectionString.GetConnectionString();
            LoadData();
            this.panel = panel;
            panelTemplate.Visible = false;
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            Forms.SubForms.giveFeedback SubForm = new Forms.SubForms.giveFeedback(user);
            SubForm.FormBorderStyle = FormBorderStyle.None; // Remove title bar
            SubForm.StartPosition = FormStartPosition.CenterScreen;

            SubForm.Show(); // Show the form as a separate window
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
            //tabPic.Image. = ;
        }

        private void LoadData()
        {
            String query = " Select Training_Sessions.id, CONCAT(userr.firstname ,' ', userr.lastname) as name, timing, gym.name as gname from userr JOIN Training_Sessions on Training_sessions.trainer_id = userr.id JOIN gym on Training_sessions.gym_id = gym.id where Training_sessions.member_id = (Select userr.id from userr where userr.username = @currentuser)";

            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@currentuser", user.Username);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    DisplayEntryDelegate displayDelegate = DisplayEntry;

                    while (reader.Read())
                    {
                        string goal = reader["name"].ToString();
                        string experience_lvl = reader["timing"].ToString();
                        string schedule = reader["gname"].ToString();
                        string planId = reader["id"].ToString();

                        displayDelegate.Invoke(goal, experience_lvl, schedule, planId);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private Panel CreatePanelFromTemplate(Panel templatePanel)
        {
            Panel newPanel = new Panel();
            newPanel.BorderStyle = templatePanel.BorderStyle;
            newPanel.BackColor = templatePanel.BackColor;
            newPanel.Width = templatePanel.Width;
            newPanel.Height = templatePanel.Height;
            newPanel.Padding = templatePanel.Padding;
            newPanel.Dock = DockStyle.None;

            foreach (Control control in templatePanel.Controls)
            {
                Control newControl = CreateControlFromTemplate(control);
                newPanel.Controls.Add(newControl);

                if (newControl is Button)
                {
                    Button newButton = (Button)newControl;
                    newButton.Image = imageList1.Images[0];
                    newButton.FlatStyle = FlatStyle.Flat;
                    newButton.FlatAppearance.BorderSize = 0;
                    newButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                    newButton.ImageAlign = ContentAlignment.MiddleLeft;
                }

                if (newControl is Label)
                {

                    Label newLabel = (Label)newControl;
                    if (newLabel.Name == "hiddenID")
                    {
                        newLabel.Visible = false;
                    }
                    newLabel.AutoSize = true; // Set AutoSize property to true for labels
                }
            }

            return newPanel;
        }


        private Control CreateControlFromTemplate(Control templateControl)
        {
            Control newControl = (Control)Activator.CreateInstance(templateControl.GetType());
            newControl.Name = templateControl.Name; // Set control name
            newControl.Location = templateControl.Location;
            newControl.Size = templateControl.Size;
            newControl.BackColor = templateControl.BackColor;
            newControl.ForeColor = templateControl.ForeColor;
            newControl.Font = templateControl.Font;
            newControl.Text = templateControl.Text;
            newControl.Dock = templateControl.Dock;
            newControl.Padding = templateControl.Padding;
            newControl.Location = templateControl.Location;

            return newControl;
        }
        public void DisplayEntry(string goal, string experience_lvl, string schedule, string planID)
        {
            Panel templatePanel = panelTemplate; // Assuming panelTemplate is your template panel

            Panel entryPanel = CreatePanelFromTemplate(templatePanel);


            foreach (Control control in entryPanel.Controls)
            {
                if (control is Label)
                {
                    Label label = (Label)control;

                    if (label.Name == "nameLabel")
                        label.Text = "Trainer name: " + goal;
                    else if (label.Name == "genderLabel")
                        label.Text = "Gym name: " + schedule;
                    else if (label.Name == "experienceLabel")
                        label.Text = "Timing: " + experience_lvl;
                    

                }
                else if (control is Button)
                {
                    Button button = (Button)control;
                    button.Click += (sender, e) =>
                    {
                        string connectString = Essentials.ConnectionString.GetConnectionString();
                        SqlConnection connection = new SqlConnection(connectString);
                        connection.Open();
                        string query1 = "Delete from Training_sessions where id =  " + planID + "";
                        SqlCommand com = new SqlCommand(query1, connection);
                        com.ExecuteNonQuery();
                        this.Close();

                        OpenChildForm(new Forms.Appointments(panel,user), sender);
                    };
                }

            }

            // Calculate vertical position based on existing panels
            int yOffset = panelContainer.Controls.Cast<Control>().Sum(control => control.Height + control.Margin.Vertical);

            entryPanel.Location = new Point(0, yOffset);

            panelContainer.Controls.Add(entryPanel);
        }
    }
}
