using Guna.Charts.WinForms;
using Project_FLEXTrainer.Essentials;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
//using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project_FLEXTrainer.Forms
{
    public partial class bookSession : Form
    {
        User currUser;
        string connectionString;
        public delegate void DisplayEntryDelegate(string name, string gender, string experience, string rating, string id);
        public bookSession(User user)
        {
            InitializeComponent();
            connectionString = Essentials.ConnectionString.GetConnectionString();

            currUser = user;
            LoadData();
            //redPanel.Visible = false;
            panelTemplate.Visible = false;
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
                    if (newControl.Name == "ID_hidden")
                    {
                        newControl.Visible = false;
                    }
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


        private void LoadData()
        {

            SqlConnection connection1 = new SqlConnection(connectionString);
            connection1.Open();
            string gymMembership;

            string query = "SELECT name\r\nFrom gym\r\nINNER JOIN MemberMembership on MemberMembership.gymId=gym.id\r\nINNER JOIN userr on userr.id = MemberMembership.memberId\r\nWHERE userr.username = @userName";
            SqlCommand command = new SqlCommand(query, connection1);
            command.Parameters.AddWithValue("@userName", currUser.Username);

            object result = command.ExecuteScalar();
            gymMembership = result != null ? result.ToString() : string.Empty;

            if (gymMembership == "" || gymMembership == null)
            {
                panel2.Show();

                return;
            }
            else
            {
                panel2.Hide();
            }


            //string connectionString = "Data Source=MNK\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;Encrypt=False";
            //string connectionString = "Data Source=DESKTOP-OLHUDAG;Initial Catalog=Flex_trainer;Integrated Security=True;Encrypt=False";
            string queryMain = "EXEC GetTrainersByGymName @gymName;";
            int count = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command1 = new SqlCommand(queryMain, connection);
                command1.Parameters.AddWithValue("@gymName", gymMembership);

                try
                {
                    connection.Open();
                    SqlDataReader reader1 = command1.ExecuteReader();

                    DisplayEntryDelegate displayDelegate = DisplayEntry;

                    while (reader1.Read())
                    {
                        count++;
                        string name = reader1["name"].ToString();
                        string gender = reader1["gender"].ToString();
                        string experience = reader1["experience"].ToString();
                        string rating = reader1["rating"].ToString();
                        string id = reader1["id"].ToString();
                        //string username = "nigga";

                        //label2.Text = username;

                        displayDelegate.Invoke(name, gender, experience, rating, id);
                    }

                    if (count == 0)
                    {
                        MessageBox.Show("No trainers working at the Gym you've applied for");
                    }
                    reader1.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public void DisplayEntry(string name, string gender, string experience, string rating, string id)
        {
            Panel templatePanel = panelTemplate; // Assuming panelTemplate is your template panel

            Panel entryPanel = CreatePanelFromTemplate(templatePanel);


            foreach (Control control in entryPanel.Controls)
            {
                if (control is Label)
                {
                    Label label = (Label)control;
                    //label2.Text = username;
                    if (label.Name == "nameLabel")
                        label.Text = "Name: " + name;
                    else if (label.Name == "genderLabel")
                        label.Text = "Gender: " + gender;
                    else if (label.Name == "experienceLabel")
                        label.Text = "Experience: " + experience;
                    else if (label.Name == "ratingLabel")
                        label.Text = "Rating: " + rating;
                    else if (label.Name == "ID_hidden")
                        label.Text = id;
                }
                else if (control is Button)
                {
                    Button button = (Button)control;
                    button.Click += (sender, e) =>
                    {
                        Forms.SubForms.TrainerInfo SubForm = new Forms.SubForms.TrainerInfo(id, name, gender, experience, rating, currUser);
                        SubForm.FormBorderStyle = FormBorderStyle.None; // Remove title bar
                        SubForm.StartPosition = FormStartPosition.CenterScreen;

                        SubForm.Show(); // Show the form as a separate window
                    };
                }

            }

            // Calculate vertical position based on existing panels
            int yOffset = panelContainer.Controls.Cast<Control>().Sum(control => control.Height + control.Margin.Vertical);

            entryPanel.Location = new Point(0, yOffset);

            panelContainer.Controls.Add(entryPanel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Hide();
        }
    }
}
