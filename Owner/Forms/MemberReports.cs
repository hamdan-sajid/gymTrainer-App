using Microsoft.VisualBasic.ApplicationServices;
using Project_FLEXTrainer.Essentials;
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
using System.Xml.Linq;

namespace Project_FLEXTrainer.Owner.Forms
{

    public delegate void DisplayEntryDelegate(string name, string gname, string gender);

    public partial class MemberReports : Form
    {
        private Button activeButton;
        User currentuser;
        string stringConnection;
        private Panel panel;
        public MemberReports(User user)
        {
            InitializeComponent();
            stringConnection = Essentials.ConnectionString.GetConnectionString();
            currentuser = user;
            this.panel = panel;
            panelTemplate.Visible = false;

            trainerCombo.SelectedIndexChanged += trainerCombo_SelectedIndexChanged;

            LoadData();

            SqlConnection connection = new SqlConnection(stringConnection);
            connection.Open();
            string getTrainers = "EXEC getTrainersOfGym @id";
            SqlCommand command = new SqlCommand(getTrainers, connection);
            command.Parameters.AddWithValue("@id", currentuser.userId);

            try
            {

                SqlDataReader reader = command.ExecuteReader();

                trainerCombo.Items.Clear();

                while (reader.Read())
                {
                    string name = reader["name"].ToString();
                    trainerCombo.Items.Add(name);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            connection.Close();



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

        private void btnActive_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
        }

        private void btnSuspended_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
        }

        private void btnCancelled_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
        }

        private void btnExpired_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
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
            string query = "Select CONCAT(firstname, ' ', lastname) as name, gym.name as gname, gender from userr JOIN MemberMembership on MemberMembership.memberId = userr.id JOIN gym on MemberMembership.gymId = gym.id where gym.owner_id = (Select id from userr where userr.username = @currentuser)";

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
                        string name = reader["name"].ToString();
                        string gname = reader["gname"].ToString();
                        string gender = reader["gender"].ToString();

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

        private void LoadDataFromTrainer()
        {
            string selectedTrainer = trainerCombo.SelectedItem.ToString();
            SqlConnection connection = new SqlConnection(stringConnection);
            connection.Open();
            string sqlQuery = "EXEC getMembersTrainedByTrainer @trainerName, @ownerID";
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            command.Parameters.AddWithValue("@trainerName", selectedTrainer);
            command.Parameters.AddWithValue("@ownerID", currentuser.userId);

            try
            {
                SqlDataReader reader = command.ExecuteReader();

                DisplayEntryDelegate displayDelegate = DisplayEntry;

                while (reader.Read())
                {
                    string name = reader["name"].ToString();
                    string gname = reader["gname"].ToString();
                    string gender = reader["gender"].ToString();

                    displayDelegate.Invoke(name, gname, gender);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            connection.Close();
        }

        private void trainerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (trainerCombo.SelectedIndex != -1)
            {
                panelContainer.Controls.Clear();
                LoadDataFromTrainer();

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
                        label.Text = "Gender: " + gender;
                    else if (label.Name == "experienceLabel")
                        label.Text = "Gym Name: " + gname;

                }


            }

            // Calculate vertical position based on existing panels
            int yOffset = panelContainer.Controls.Cast<Control>().Sum(control => control.Height + control.Margin.Vertical);

            entryPanel.Location = new Point(0, yOffset);

            panelContainer.Controls.Add(entryPanel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            LoadData();
        }
    }
}
