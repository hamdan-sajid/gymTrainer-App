using Guna.Charts.WinForms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.ApplicationServices;
using Project_FLEXTrainer.Essentials.MessageBoxes;
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
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;



namespace Project_FLEXTrainer.Forms
{

    public delegate void DisplayEntryDelegate_d(string goal, string experience_lvl, string schedule, string planID);
    public partial class dietPlans : Form
    {
        User user;
        private string stringConnection;
        public dietPlans(User userr)
        {
            InitializeComponent();

            calorieFilter.Items.Add("Less than 200");
            calorieFilter.Items.Add("Less than 500");
            calorieFilter.Items.Add("Less than 1000");

            carbCombo.Items.Add("Less than 100");
            carbCombo.Items.Add("Less than 300");
            carbCombo.Items.Add("Less than 500");

            stringConnection = Essentials.ConnectionString.GetConnectionString();

            user = userr;
            string temp = "SELECT goal AS 'Goal', nutrition AS 'Nutrition', type AS 'Type', plan_id FROM diet_plan";
            panelTemplate.Visible = false;

            comboBox4.Items.Add("None");
            comboBox4.Items.Add("Peanuts");
            comboBox4.Items.Add("Allergens");
            

            comboBox4.SelectedIndexChanged += new EventHandler(comboBox4_SelectedIndexChanged);
            DisplayDietPlans(false, false,temp);
        }


        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
                string rr;
                rr = "Select * from diet_plan Join meals on diet_plan.plan_id = meals.plan_id where allergents != '" + comboBox4.SelectedItem.ToString() + "'";
                panelContainer.Controls.Clear();
                DisplayDietPlans(true, true,"aaaa");

            
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
                    if (newControl.Name == "button2")
                    {
                        Button newButton = (Button)newControl;
                        newButton.Image = imageList1.Images[0];
                        newButton.FlatStyle = FlatStyle.Flat;
                        newButton.FlatAppearance.BorderSize = 0;
                    }
                    else
                    {
                        Button newButton = (Button)newControl;
                        newButton.Image = imageList1.Images[1];
                        newButton.FlatStyle = FlatStyle.Flat;
                        newButton.FlatAppearance.BorderSize = 0;
                    }
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
                else if (control is Button && control.Name == "button2")
                {
                    Button button = (Button)control;
                    button.Click += (sender, e) =>
                    {
                        SqlConnection connection = new SqlConnection(stringConnection);
                        connection.Open();
                        string userIDQuery = "SELECT userr.id FROM userr WHERE username = @Username";

                        SqlCommand command1 = new SqlCommand(userIDQuery, connection);
                        command1.Parameters.AddWithValue("@Username", user.Username);
                        //connection.Open();
                        object result = command1.ExecuteScalar();
                        string userId;
                        if (result != null)
                        {
                            userId = Convert.ToString(result);
                        }
                        else
                        {
                            MessageBox.Show("problem inserting :: username");
                            return;
                        }

                        string queryUserPlan = "INSERT into UserPlans VALUES (" + userId + "," + planID + ");";
                        SqlCommand command5 = new SqlCommand(queryUserPlan, connection);
                        command5.ExecuteNonQuery();
                        //MessageBox.Show("Plan Added");
                        connection.Close();
                        Essentials.MessageBoxes.prompt messageBox = new Essentials.MessageBoxes.prompt("Plan Added");
                        messageBox.FormBorderStyle = FormBorderStyle.None;
                        messageBox.StartPosition = FormStartPosition.CenterScreen;
                        messageBox.Show();
                    };
                }
                else if (control is Button && control.Name == "button3")
                {
                    Button button = (Button)control;
                    button.Click += (sender, e) =>
                    {
                        Forms.SubForms.showSelected SubForm = new Forms.SubForms.showSelected(user, planID);
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

        private void DisplayDietPlans(bool calFilter, bool carbFilter, string temp)
        {
            String query;
            if (calFilter == false && carbFilter == false)
            {
                query = "SELECT goal AS 'Goal', nutrition AS 'Nutrition', type AS 'Type', plan_id FROM diet_plan";
            }
            else if (calFilter == true)
            {
                query = "EXEC getPlansWithCalorie @calorieFilter";
            }
            else if(temp == "aaaa")
            {
                query = "Select * from diet_plan Join meals on diet_plan.plan_id = meals.plan_id where allergents != 'None'";
            }
            else
            {
                query = "EXEC getPlansWithCarb @carbFilter";
            }
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                SqlCommand command = new SqlCommand(query, connection);
                if (calFilter == true)
                {
                    int num;
                    if (calorieFilter.SelectedIndex == 0)
                        num = 200;
                    else if (calorieFilter.SelectedIndex == 1)
                        num = 500;
                    else
                        num = 1000;
                    command.Parameters.AddWithValue("@calorieFilter", num);
                }else if (carbFilter == true)
                {
                    int num;
                    if (carbCombo.SelectedIndex == 0)
                        num = 100;
                    else if (carbCombo.SelectedIndex == 1)
                        num = 300;
                    else
                        num = 500;
                    command.Parameters.AddWithValue("@carbFilter", num);
                }
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

        private void btnCreateDP_Click(object sender, EventArgs e)
        {
            if (user.isProfileComplete == false)
            {
                Form messageBox = new customMessage_CompleteProfile();
                messageBox.FormBorderStyle = FormBorderStyle.None;
                messageBox.StartPosition = FormStartPosition.CenterScreen;
                messageBox.Show();

                return;
            }
            Forms.SubForms.createDietPlancs SubForm = new Forms.SubForms.createDietPlancs(user);
            SubForm.FormBorderStyle = FormBorderStyle.None; // Remove title bar
            SubForm.StartPosition = FormStartPosition.CenterScreen;

            SubForm.Show(); // Show the form as a separate window
        }

        private void calorieFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            carbCombo.SelectedIndex = -1;
            string temp = "SELECT goal AS 'Goal', nutrition AS 'Nutrition', type AS 'Type', plan_id FROM diet_plan";
            if (calorieFilter.SelectedIndex != -1)
            {
                panelContainer.Controls.Clear();
                DisplayDietPlans(true, false,temp);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            DisplayDietPlans(false, false,"false");
        }

        private void carbCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            calorieFilter.SelectedIndex = -1;
            string temp = "SELECT goal AS 'Goal', nutrition AS 'Nutrition', type AS 'Type', plan_id FROM diet_plan";
            if (carbCombo.SelectedIndex != -1)
            {
                panelContainer.Controls.Clear();
                DisplayDietPlans(false,true,temp);

            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            string rr;
            rr = "SELECT goal AS 'Goal', nutrition AS 'Nutrition', type AS 'Type', plan_id FROM diet_plan";

            panelContainer.Controls.Clear();
            DisplayDietPlans(false, false,rr);
        }
    }
}
