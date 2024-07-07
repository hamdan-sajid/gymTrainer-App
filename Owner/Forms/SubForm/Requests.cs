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

namespace Project_FLEXTrainer.Owner.Forms.SubForm
{
    public partial class Requests : Form
    {
        User currUser;
        string connectionString;
        public delegate void DisplayEntryDelegate(string name, string exp, string qual, string specs, string userID);
        public Requests(User user)
        {
            InitializeComponent();
            currUser = user;
            connectionString = Essentials.ConnectionString.GetConnectionString();
            panelTemplate.Visible = false;
            LoadData();
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
                    if (newControl.Name == "acceptBtn")
                    {
                        Button newButton = (Button)newControl;
                        newButton.FlatStyle = FlatStyle.Flat;
                        newButton.FlatAppearance.BorderSize = 0;
                    }
                    else if (newControl.Name == "rejectBtn")
                    {
                        Button newButton = (Button)newControl;
                        newButton.FlatStyle = FlatStyle.Flat;
                        newButton.FlatAppearance.BorderSize = 0;
                    }
                }

                /*if (newControl is Label)
                {
                    if (newControl.Name == "ID_hidden")
                    {
                        newControl.Visible = false;
                    }
                    Label newLabel = (Label)newControl;
                    newLabel.AutoSize = true; // Set AutoSize property to true for labels
                }*/
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



            //string connectionString = "Data Source=MNK\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;Encrypt=False";
            //string connectionString = "Data Source=DESKTOP-OLHUDAG;Initial Catalog=Flex_trainer;Integrated Security=True;Encrypt=False";
            string queryMain = "EXEC GetTrainerRequests @ownerID;";
            //int count = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command1 = new SqlCommand(queryMain, connection);
                command1.Parameters.AddWithValue("@ownerID", currUser.userId);

                try
                {
                    connection.Open();
                    SqlDataReader reader1 = command1.ExecuteReader();

                    DisplayEntryDelegate displayDelegate = DisplayEntry;

                    while (reader1.Read())
                    {
                        string exp = reader1["experience"].ToString();
                        string qual = reader1["qualification"].ToString();
                        string specs = reader1["specializaion"].ToString();
                        string name = reader1["name"].ToString();
                        string userID = reader1["memberid"].ToString();
                        //string username = "nigga";

                        //label2.Text = username;

                        displayDelegate.Invoke(name, exp, qual, specs, userID);
                    }

                    reader1.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public void DisplayEntry(string name, string exp, string qual, string specs, string userID)
        {
            Panel templatePanel = panelTemplate; // Assuming panelTemplate is your template panel

            Panel entryPanel = CreatePanelFromTemplate(templatePanel);


            foreach (Control control in entryPanel.Controls)
            {
                if (control is Label)
                {
                    Label label = (Label)control;
                    //label2.Text = username;
                    if (label.Name == "txtName")
                        label.Text = "Name: " + name;
                    else if (label.Name == "txtExp")
                        label.Text = "Experience: " + exp;
                    else if (label.Name == "txtQual")
                        label.Text = "Qualifification: " + qual;
                    else if (label.Name == "txtSpecs")
                        label.Text = "Specialization: " + specs;
                }
                else if (control is Button)
                {
                    if (control.Name == "acceptBtn")
                    {
                        Button button = (Button)control;
                        button.Click += (sender, e) =>
                        {
                            /* Forms.SubForms.TrainerInfo SubForm = new Forms.SubForms.TrainerInfo(id, name, gender, experience, rating, currUser);
                             SubForm.FormBorderStyle = FormBorderStyle.None; // Remove title bar
                             SubForm.StartPosition = FormStartPosition.CenterScreen;

                             SubForm.Show(); // Show the form as a separate window*/
                            SqlConnection connection = new SqlConnection(Essentials.ConnectionString.GetConnectionString());
                            connection.Open();


                            string checktrainer = "SELECT 1\r\n\tFROM trainer\r\n\tWHERE trainer.id = @id";
                            SqlCommand cm = new SqlCommand(checktrainer, connection);
                            cm.Parameters.AddWithValue("@id", userID);
                            int result = Convert.ToInt32(cm.ExecuteScalar());
                            if (result == 0 || result == null) {


                                string query1 = "INSERT INTO trainer VALUES (@userid, @specialization, @qualification, 0, @experience)";
                                SqlCommand command1 = new SqlCommand(query1, connection);
                                command1.Parameters.AddWithValue("@userid", userID);
                                command1.Parameters.AddWithValue("@specialization", specs);
                                command1.Parameters.AddWithValue("@qualification", qual);
                                command1.Parameters.AddWithValue("@rating", 0);
                                command1.Parameters.AddWithValue("@experience", exp);

                                command1.ExecuteNonQuery();

                                string query3 = "update account set account_type='trainer' where username =(SELECT username FROM userr WHERE id = @useridd)";
                                SqlCommand command3 = new SqlCommand(query3, connection);
                                command3.Parameters.AddWithValue("@useridd", userID);
                                command3.ExecuteNonQuery();

                                string query4 = "delete from member where id = @userID";
                                SqlCommand command4 = new SqlCommand(query4, connection);
                                command4.Parameters.AddWithValue("@userID", userID);
                                command4.ExecuteNonQuery();
                            }

                            string query2 = "INSERT INTO gym_assign_to_trainer VALUES (@userID, (select id \r\n\tFROM gym\r\n\twhere owner_id = @ownerID))";
                            SqlCommand command = new SqlCommand(query2, connection);
                            command.Parameters.AddWithValue("@userID", userID);
                            command.Parameters.AddWithValue("@ownerID", currUser.userId);
                            command.ExecuteNonQuery();
                          

                            string query5 = "DELETE TR FROM TRAINER_REQUEST TR INNER JOIN gym G ON G.ID = TR.gymID WHERE G.owner_id = @ownID AND memberID = @userID";
                            SqlCommand command5 = new SqlCommand(query5, connection);
                            command5.Parameters.AddWithValue("@ownID", currUser.userId);
                            command5.Parameters.AddWithValue("@userID", userID);
                            command5.ExecuteNonQuery();


                            Form messageBox = new Essentials.MessageBoxes.prompt("Accepted!");
                            messageBox.FormBorderStyle = FormBorderStyle.None;
                            messageBox.StartPosition = FormStartPosition.CenterScreen;
                            messageBox.Show();
                            messageBox.BringToFront();
                            messageBox.BringToFront();

                            connection.Close();
                        };
                    }
                }

            }

            // Calculate vertical position based on existing panels
            int yOffset = panelContainer.Controls.Cast<Control>().Sum(control => control.Height + control.Margin.Vertical);

            entryPanel.Location = new Point(0, yOffset);

            panelContainer.Controls.Add(entryPanel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
