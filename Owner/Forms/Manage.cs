using Guna.Charts.WinForms;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_FLEXTrainer.Owner.Forms
{
    public delegate void DisplayEntryDelegate_d(string str1, string str2, string str3);
    public partial class Manage : Form
    {
        private Button activeButton;
        User currUser;
        string stringConnection;
        public Manage(User user)
        {
            InitializeComponent();
            stringConnection = Essentials.ConnectionString.GetConnectionString();

            currUser = user;
            panel1.Visible = false;
            LoadDataMember();
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
                    newButton.ImageAlign = ContentAlignment.MiddleLeft;
                    newButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                    newButton.FlatStyle = FlatStyle.Flat;
                    newButton.FlatAppearance.BorderSize = 0;
                }
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

        public void DisplayEntryMember(string str1, string str2, string str3)
        {
            Panel templatePanel = panel1;

            Panel entryPanel = CreatePanelFromTemplate(templatePanel);


            foreach (Control control in entryPanel.Controls)
            {
                if (control is Label)
                {
                    Label label = (Label)control;

                    if (label.Name == "name")
                    {
                        label.Text = "Name: " + str1;
                    }
                    else if (label.Name == "label1" && str3 == "member")
                        label.Text = "Membership Type: " + str2;
                    else if (label.Name == "label1" && str3 == "trainer")
                        label.Text = "Rating: " + str2;
                    else if (label.Name == "label2")
                        label.Text = str3;

                }
                else if (control is Button)
                {
                    Button button = (Button)control;
                    button.Click += (sender, e) =>
                    {
                        SqlConnection connection = new SqlConnection(stringConnection);
                        connection.Open();

                        if (str3 == "trainer") {
                            string query = "DELETE FROM gym_assign_to_trainer WHERE gym_id = (SELECT TOP 1  gym.id from gym INNER JOIN owner on owner.id = gym.owner_id WHERE owner.id = @OwnerID) \r\nAND gym_assign_to_trainer.trainerid = (SELECT TOP 1  trainer.id FROM trainer INNER JOIN userr on userr.id = trainer.id WHERE @fullname = CONCAT(userr.firstname, ' ', userr.lastname))";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@OwnerID", currUser.userId);
                            command.Parameters.AddWithValue("@fullname", str1);

                            command.ExecuteNonQuery();
                            Essentials.MessageBoxes.prompt messageBox = new Essentials.MessageBoxes.prompt("Removed!");
                            messageBox.FormBorderStyle = FormBorderStyle.None;
                            messageBox.StartPosition = FormStartPosition.CenterScreen;
                            messageBox.Show();

                        }
                        else
                        {
                            string query = "DELETE FROM MemberMembership WHERE gymId = (SELECT TOP 1 gym.id from gym INNER JOIN owner on owner.id = gym.owner_id WHERE owner.id = @OwnerID) \r\nAND memberId = (SELECT TOP 1 userr.id FROM member INNER JOIN userr on userr.id = member.id WHERE @fullname = CONCAT(userr.firstname, ' ', userr.lastname))";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@OwnerID", currUser.userId);
                            command.Parameters.AddWithValue("@fullname", str1);

                            command.ExecuteNonQuery();
                            Essentials.MessageBoxes.prompt messageBox = new Essentials.MessageBoxes.prompt("Removed!");
                            messageBox.FormBorderStyle = FormBorderStyle.None;
                            messageBox.StartPosition = FormStartPosition.CenterScreen;
                            messageBox.Show();
                        }

                        connection.Close();
                        
                    };
                }
            }

            // Calculate vertical position based on existing panels
            int yOffset = panelContainer.Controls.Cast<Control>().Sum(control => control.Height + control.Margin.Vertical);

            entryPanel.Location = new Point(0, yOffset);

            panelContainer.Controls.Add(entryPanel);
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

        private void btnMember_Click(object sender, EventArgs e)
        {
            if ((Button)sender != (Button)activeButton)
            {
                activateBtn(sender);
           
            }
        }

        void LoadDataMember()
        {
            String queryEXEC = "EXEC GetMemberInfoByOwnerId @ownerId";
            String queryEXECC = "EXEC GetTrainerInfoByOwnerId @ownerId";
            

            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                SqlCommand command = new SqlCommand(queryEXEC, connection);
                command.Parameters.AddWithValue("@ownerId", currUser.userId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    DisplayEntryDelegate_d displayDelegate = DisplayEntryMember;

                    while (reader.Read())
                    {
                        string name = reader["name"].ToString();
                        string type = reader["type"].ToString();
                        string t = reader["account_type"].ToString();

                        displayDelegate.Invoke(name, type, t);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

                connection.Close();

                SqlCommand command1 = new SqlCommand(queryEXECC, connection);
                command1.Parameters.AddWithValue("@ownerId", currUser.userId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command1.ExecuteReader();

                    DisplayEntryDelegate_d displayDelegate = DisplayEntryMember;

                    while (reader.Read())
                    {
                        string name = reader["name"].ToString();
                        string type = reader["type"].ToString();
                        string t = reader["account_type"].ToString();

                        displayDelegate.Invoke(name, type, t);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                connection.Close();
            }
        }

        private void btnTrainer_Click(object sender, EventArgs e)
        {
            if ((Button)sender != (Button)activeButton)
            {
                activateBtn(sender);
                //LoadDataTrainer();
            }
        }

        private void btnRequests_Click(object sender, EventArgs e)
        {
            SubForm.Requests SubForm = new SubForm.Requests(currUser);
            SubForm.FormBorderStyle = FormBorderStyle.None; // Remove title bar
            SubForm.StartPosition = FormStartPosition.CenterScreen;
            SubForm.BringToFront();

            SubForm.Show(); // Show the form as a separate window
        }
    }
}
