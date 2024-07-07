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

namespace Project_FLEXTrainer.Forms.SubForms
{
    public partial class showSelected : Form
    {
        public delegate void DisplayEntryDelegate_d(string firstname, string fullname, string gender);

        string connectionString;
        User currUser;
        string planID;
        public showSelected(User user, string planID)
        {
            InitializeComponent();
            panelTemplate.Visible = false;
            currUser = user;
            connectionString = Essentials.ConnectionString.GetConnectionString();
            this.planID = planID;

            gunaCombo.SelectedIndexChanged += gunaCombo_SelectedIndexChanged;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT name FROM gym";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        gunaCombo.Items.Clear();

                        while (reader.Read())
                        {
                            string gymName = reader["name"].ToString();
                            gunaCombo.Items.Add(gymName);
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }


                LoadData(false);
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
        public void DisplayEntry(string firstname, string lastname, string gender)
        {
            Panel templatePanel = panelTemplate;

            Panel entryPanel = CreatePanelFromTemplate(templatePanel);


            foreach (Control control in entryPanel.Controls)
            {
                if (control is Label)
                {
                    Label label = (Label)control;

                    if (label.Name == "label1")
                        label.Text = "First Name: " + firstname;
                    else if (label.Name == "label2")
                        label.Text = "Last Name: " + lastname;
                    else if (label.Name == "label3")
                        label.Text = "Gender: " + gender;

                }
            }

            // Calculate vertical position based on existing panels
            int yOffset = panelContainer.Controls.Cast<Control>().Sum(control => control.Height + control.Margin.Vertical);

            entryPanel.Location = new Point(0, yOffset);

            panelContainer.Controls.Add(entryPanel);
        }

        private void LoadData(bool gymFilter)
        {

            String query;
            if(gymFilter == false)
            {
                query = "EXEC getSubscribedMembers @planID";
            }
            else
            {
                query = "EXEC getSubscribedMembersFromGym @planID ,@gymName";
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@planID", planID);
                    if (gymFilter == true)
                    {
                        command.Parameters.AddWithValue("@gymName", gunaCombo.SelectedItem.ToString());
                    }
                    
                    SqlDataReader reader = command.ExecuteReader();

                    DisplayEntryDelegate_d displayDelegate = DisplayEntry;

                    while (reader.Read())
                    {
                        string fname = reader["firstname"].ToString();
                        string lname = reader["lastname"].ToString();
                        string gender = reader["gender"].ToString();

                        displayDelegate.Invoke(fname, lname, gender);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void closeError_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void gunaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gunaCombo.SelectedIndex != -1)
            {
                panelContainer.Controls.Clear();
                LoadData(true);
            }
        }
    }


}
