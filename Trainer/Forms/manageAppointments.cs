using Guna.Charts.WinForms;
using Project_FLEXTrainer.Admin.Forms;
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
    public delegate void DisplayEntryDelegate_o(string planid,string name, string gname, string gender);

    public partial class manageAppointments : Form
    {
        private Button activeButton;
        User user;
        string stringConnection;
        Panel panel;

        public manageAppointments(User user, Panel panel)
        {
            InitializeComponent();
            this.user = user;
            stringConnection = Essentials.ConnectionString.GetConnectionString();
            LoadData();
            panelTemplate.Visible = false;
            this.panel = panel;
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

        private void btnAll_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
        }

        private void btnArchived_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
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
                    newLabel.AutoSize = true; // Set AutoSize property to true for labels
                }
            }

            return newPanel;
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

        private void LoadData()
        {
            string connectionString = Essentials.ConnectionString.GetConnectionString();
            string query = " Select Training_sessions.id, CONCAT(firstname,' ',lastname)as name, gym.name as gname, Training_sessions.timing from Training_sessions JOIN userr on userr.id = member_id JOIN gym on gym.id = gym_id where Training_sessions.trainer_id = (Select id from userr where userr.username = @currentuser)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@currentuser", user.Username);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    DisplayEntryDelegate_o displayDelegate = DisplayEntry;

                    while (reader.Read())
                    {
                        string name = reader["name"].ToString();
                        string gname = reader["gname"].ToString();
                        string gender = reader["timing"].ToString();
                        string planid = reader["id"].ToString();
                        displayDelegate.Invoke(planid, name, gname, gender);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: aaaaaaaa" + ex.Message);
                }
            }
        }

        public void DisplayEntry(string planid, string name, string gname, string gender)
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
                        label.Text = "Gym Name: " + gname;
                    else if (label.Name == "experienceLabel")
                        label.Text = "Timing: " + gender;

                }
                else if (control is Button)
                {
                    Button button = (Button)control;
                    button.Click += (sender, e) =>
                    {
                        string connect = Essentials.ConnectionString.GetConnectionString();
                        SqlConnection connection = new SqlConnection(connect);
                        connection.Open();
                        SqlCommand comm = new SqlCommand("Delete from Training_sessions where Training_sessions.id =  '" + planid + "';", connection);
                        comm.ExecuteNonQuery();
                        connection.Close();

                        this.Close();
                        OpenChildForm(new Forms.manageAppointments(user,panel), sender);
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
