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

    public delegate void DisplayEntryDelegate_i(string name, string gname, string gender);
    public partial class Feedbacks : Form
    {
        User user;
        string stringConnection;
        private Button activeButton;
        public Feedbacks(User user)
        {
            InitializeComponent();
            this.user = user;
            stringConnection = Essentials.ConnectionString.GetConnectionString();
            LoadData();
            panelTemplate.Visible = false;

            SqlConnection connection = new SqlConnection(Essentials.ConnectionString.GetConnectionString());
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select AVG(feedback.rating) as rating from feedback Join userr on userr.id = feedback.member_id where feedback.trainer_id = (Select id from userr where userr.username = '" + user.Username + "') GROUP by feedback.rating", connection);
            string rating = Convert.ToString(cmd.ExecuteScalar());
            label3.Text = rating;

            

            connection.Close();
        }

        private void LoadData()
        {

            String query = "Select CONCAT(userr.firstname,' ', userr.lastname) as name, feedback.rating, feedback.message from feedback Join userr on userr.id = feedback.member_id where feedback.trainer_id = (Select id from userr where userr.username = @currentuser)";
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@currentuser", user.Username);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    DisplayEntryDelegate_i displayDelegate = DisplayEntry;

                    while (reader.Read())
                    {
                        string name = reader["name"].ToString();
                        string gname = reader["rating"].ToString();
                        string gender = reader["message"].ToString();

                        displayDelegate.Invoke(name, gname, gender);
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
        public void DisplayEntry(string name, string gname, string gender)
        {
            Panel templatePanel = panelTemplate; // Assuming panelTemplate is your template panel

            Panel entryPanel = CreatePanelFromTemplate(templatePanel);


            foreach (Control control in entryPanel.Controls)
            {
                if (control is Label)
                {
                    Label label = (Label)control;

                    if (label.Name == "nameLabel")
                        label.Text = "Name: " + name;
                    else if (label.Name == "genderLabel")
                        label.Text = "Message: " + gender;
                    else if (label.Name == "experienceLabel")
                        label.Text = "Rating: " + gname;

                }


            }

            // Calculate vertical position based on existing panels
            int yOffset = panelContainer.Controls.Cast<Control>().Sum(control => control.Height + control.Margin.Vertical);

            entryPanel.Location = new Point(0, yOffset);

            panelContainer.Controls.Add(entryPanel);
        }
    }
}
