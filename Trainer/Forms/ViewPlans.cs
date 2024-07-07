using Microsoft.VisualBasic.ApplicationServices;
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

namespace Project_FLEXTrainer.Trainer.Forms
{
    public delegate void DisplayEntryDelegate(string goal, string experience_lvl, string schedule, string planID);
    public partial class ViewPlans : Form
    {
        private Button activeButton;
        User currentuser;
        string stringConnection;
        private Panel panel;
        Form activeForm;

        public ViewPlans(User user, Panel panel)
        {
            InitializeComponent();
            stringConnection = Essentials.ConnectionString.GetConnectionString();
            currentuser = user;
            LoadData();
            this.panel = panel;
            panelTemplate.Visible = false;
            
        }

        private void btnDP_Click(object sender, EventArgs e)
        {
            if ((Button)sender != (Button)activeButton)
            {
                OpenChildForm(new Forms.ViewPlans2(currentuser, panel), sender);
            }
        }

        private void activateBtn(object sender)
        {
            if (sender != null)
            {
                if (activeButton != (Button)sender)
                {
                    disableBtn();
                    Color color = Color.FromArgb(76, 126, 122);
                    activeButton = (Button)sender;
                    activeButton.BackColor = color;
                    activeButton.ForeColor = Color.White;
                    activeButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);


                }
            }
        }

        private void disableBtn()
        {
            foreach (Control prevbtn in navPanel.Controls)
            {
                if (prevbtn.GetType() == typeof(Button))
                {
                    prevbtn.BackColor = Color.FromArgb(25, 42, 40);
                    prevbtn.ForeColor = Color.Gainsboro;
                    prevbtn.Font = new Font("Segoe UI", 14.25F);
                }
            }
        }

        private void btnWP_Click(object sender, EventArgs e)
        {
            if ((Button)sender != (Button)activeButton)
            {
                //OpenChildForm(new Forms.ViewPlans(currentuser, panel), sender);
                activeForm.Close();
                activateBtn(sender);
                activeForm = this;
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            activateBtn(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
            //tabPic.Image. = ;
        }

        private void LoadData()
        {
           
            
            String query = "Select goal,experience_lvl,schedule,plan_id from workout_plan Join Plann on workout_plan.plan_id = Plann.id Join userr on userr.id = Plann.creator_id where userr.username = @currentuser";

            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@currentuser", currentuser.Username);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    DisplayEntryDelegate displayDelegate = DisplayEntry;

                    while (reader.Read())
                    {
                        string goal = reader["goal"].ToString();
                        string experience_lvl = reader["experience_lvl"].ToString();
                        string schedule = reader["schedule"].ToString();
                        string planId = reader["plan_id"].ToString();

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
                        label.Text = "Goal: " + goal;
                    else if (label.Name == "genderLabel")
                        label.Text = "Schedule: " + schedule;
                    else if (label.Name == "experienceLabel")
                        label.Text = "Experience: " + experience_lvl;
                    else if (label.Name == "hiddenID")
                        label.Text = "planID";

                }
                else if (control is Button)
                {
                    Button button = (Button)control;
                    button.Click += (sender, e) =>
                    {
                        string connectString = Essentials.ConnectionString.GetConnectionString();
                        SqlConnection connection = new SqlConnection(connectString);
                        connection.Open();
                        string query1 = "Delete from workout_plan where workout_plan.plan_id = " + planID + "";
                        SqlCommand com = new SqlCommand(query1, connection);
                        com.ExecuteNonQuery();
                        query1 = "Delete from Plann where Plann.id = " + planID + "";
                        com = new SqlCommand(query1, connection);
                        com.ExecuteNonQuery();

                        this.Close();
                        OpenChildForm(new Forms.ViewPlans(currentuser, panel), sender);

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
