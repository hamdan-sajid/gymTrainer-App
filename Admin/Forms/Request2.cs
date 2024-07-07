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
    public delegate void DisplayEntryDelegate_r2(int id, string name, string gname, string location, string userID);
    public partial class Request2 : Form
    {
        private User user;
        private Button activeButton;
        private Panel dpanel;
        public Request2(Panel panel,User user)
        {
            InitializeComponent();
            panelTemplate.Visible = false;
            dpanel = panel;
            LoadData();
            this.user = user;
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

        private void btnArchived_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
            this.Close();
            OpenChildForm(new Forms.Requests(dpanel,user), sender);
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
            dpanel.Controls.Add(childForm);
            dpanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            pgTitle.Text = childForm.Text;
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
            //string connectionString = "Data Source=MNK\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;Encrypt=False";
            //string connectionString = "Data Source=DESKTOP-OLHUDAG;Initial Catalog=Flex_trainer;Integrated Security=True;Encrypt=False";
            string query = "Select REQUEST.ID, CONCAT(firstname,' ', lastname) as name,GYMname,location from REQUEST JOIN userr on REQUEST.memberID = userr.id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    DisplayEntryDelegate_r2 displayDelegate = DisplayEntry;

                    while (reader.Read())
                    {
                        int id = reader.GetInt32("ID");
                        string name = reader["name"].ToString();
                        string gname = reader["GYMname"].ToString();
                        string location = reader["location"].ToString();
                        string memid = reader["memberID"].ToString();

                        displayDelegate.Invoke(id, name, gname, location,memid);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public void DisplayEntry(int id, string name, string gname, string location, string userID)
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
                        label.Text = "Location: " + location;

                }
                else if (control is Button)
                {
                    Button button = (Button)control;
                    button.Click += (sender, e) =>
                    {
                        string connect = Essentials.ConnectionString.GetConnectionString();
                        //string connect = "Data Source=DESKTOP-OLHUDAG;Initial Catalog=Flex_trainer;Integrated Security=True;Encrypt=False";
                        SqlConnection connection = new SqlConnection(connect);
                        connection.Open();
                        SqlCommand comm = new SqlCommand("Delete from REQUEST where REQUEST.id = '" + id + "';", connection);
                        comm.ExecuteNonQuery();
                        connection.Close();

                        this.Close();
                        OpenChildForm(new Forms.Request2(dpanel,user), sender);
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
