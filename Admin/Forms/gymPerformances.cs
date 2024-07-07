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

namespace Project_FLEXTrainer.Admin.Forms
{
    public partial class gymPerformances : Form
    {
        public delegate void DisplayEntryDelegate(string name, string location, string totalMembers);
        User currUser;
        public gymPerformances(User user)
        {
            InitializeComponent();

            panelTemplate.Visible = false;

            using (SqlConnection connection = new SqlConnection(Essentials.ConnectionString.GetConnectionString()))
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

            gunaCombo.SelectedIndexChanged += new EventHandler(gunaCombo_SelectedIndexChanged);


            LoadData();
        }

        private void btnCancelled_Click(object sender, EventArgs e)
        {

        }

        private void pgTitle_Click(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {

            string query;
            query = "EXEC displayGymMetrics1";

            using (SqlConnection connection = new SqlConnection(Essentials.ConnectionString.GetConnectionString()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    DisplayEntryDelegate displayDelegate = DisplayEntry;

                    while (reader.Read())
                    {
                        string str1 = reader["name"].ToString();
                        string str2 = reader["location"].ToString();
                        string str3 = reader["totalMembers"].ToString();

                        displayDelegate.Invoke(str1, str2, str3);
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

        public void DisplayEntry(string name, string location, string totalMembers)
        {
            Panel templatePanel = panelTemplate; // Assuming panelTemplate is your template panel

            Panel entryPanel = CreatePanelFromTemplate(templatePanel);


            foreach (Control control in entryPanel.Controls)
            {
                if (control is Label)
                {
                    Label label = (Label)control;

                    if (label.Name == "name")
                        label.Text = "Name: " + name;
                    else if (label.Name == "txtLoc")
                        label.Text = "Location: " + location;
                    else if (label.Name == "totalMember")
                        label.Text = "Total Members: " + totalMembers;


                }
            }

            // Calculate vertical position based on existing panels
            int yOffset = panelContainer.Controls.Cast<Control>().Sum(control => control.Height + control.Margin.Vertical);

            entryPanel.Location = new Point(0, yOffset);

            panelContainer.Controls.Add(entryPanel);
        }
        private void gunaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(Essentials.ConnectionString.GetConnectionString()))
            {
                connect.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(MemberMembership.MembershipId) FROM MemberMembership WHERE gymId = (SELECT gym.id FROM gym WHERE gym.name = @currentgym)", connect))
                {
                    cmd.Parameters.AddWithValue("@currentgym", gunaCombo.SelectedItem.ToString());
                    string count = Convert.ToString(cmd.ExecuteScalar());
                    label2.Text = count;
                }
            }
        }

    }
}