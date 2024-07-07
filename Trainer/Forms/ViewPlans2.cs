using Microsoft.VisualBasic.ApplicationServices;
using Project_FLEXTrainer.Forms;
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
    public partial class ViewPlans2 : Form
    {
        private Button activeButton;
        User user;

        string stringConnection;
        private Panel panel;
        public ViewPlans2(User user, Panel panel)
        {
            InitializeComponent();
            stringConnection = Essentials.ConnectionString.GetConnectionString();
            this.user = user;
            Display_diet();
            this.panel = panel;
            panelTemplate.Visible = false;
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

        private void Display_diet()
        {

            String query = "SELECT goal AS 'Goal', nutrition AS 'Nutrition', type AS 'Type', plan_id FROM diet_plan Join PLann on diet_plan.plan_id = Plann.id Join userr on userr.id = Plann.creator_id where userr.username = @currentuser";

            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@currentuser", user.Username);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    DisplayEntryDelegate_d displayDelegate = DisplayEntry;

                    while (reader.Read())
                    {
                        string goal = reader["Goal"].ToString();
                        string experience_lvl = reader["Nutrition"].ToString();
                        string schedule = reader["Type"].ToString();
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
                }

                if (newControl is Label)
                {

                    Label newLabel = (Label)newControl;
                    if (newLabel.Name == "hiddenID")
                    {
                        newLabel.Visible = false;
                    }
                    newLabel.AutoSize = true;
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
        public void DisplayEntry(string goal, string nutrition, string type, string planID)
        {
            Panel templatePanel = panelTemplate;

            Panel entryPanel = CreatePanelFromTemplate(templatePanel);


            foreach (Control control in entryPanel.Controls)
            {
                if (control is Label)
                {
                    Label label = (Label)control;

                    if (label.Name == "nameLabel")
                        label.Text = "Goal: " + goal;
                    else if (label.Name == "genderLabel")
                        label.Text = "Schedule: " + nutrition;
                    else if (label.Name == "experienceLabel")
                        label.Text = "Experience: " + type;

                }
                else if (control is Button)
                {
                    Button button = (Button)control;
                    button.Click += (sender, e) =>
                    {
                        string connectString = Essentials.ConnectionString.GetConnectionString();
                        SqlConnection connection = new SqlConnection(connectString);
                        connection.Open();
                        string query1 = "Delete from diet_plan where diet_plan.plan_id =  " + planID + "";
                        SqlCommand com = new SqlCommand(query1, connection);
                        com.ExecuteNonQuery();
                        query1 = "Delete from Plann where Plann.id = " + planID + "";
                        com = new SqlCommand(query1, connection);
                        com.ExecuteNonQuery();

                        this.Close();
                        OpenChildForm(new Forms.ViewPlans(user, panel), sender);
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
