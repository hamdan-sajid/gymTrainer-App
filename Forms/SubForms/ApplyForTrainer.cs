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
    public partial class ApplyForTrainer : Form
    {
        string connectionString;
        User currentUser;

        List<string> gymAdded = new List<string>();
        public ApplyForTrainer(User user)
        {
            InitializeComponent();

            connectionString = Essentials.ConnectionString.GetConnectionString();
            currentUser = user;
            string queryGetGyms = "SELECT name FROM gym";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(queryGetGyms, connection))
                {
                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            string temp = reader["name"].ToString();
                            gymCombo.Items.Add(temp);
                        }

                        // Close the SqlDataReader
                        reader.Close();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }


        }

        private void addGym_Click(object sender, EventArgs e)
        {
            if (gymCombo.SelectedIndex.ToString() == "")
            {
                Form MessageBox = new Essentials.MessageBoxes.missingInfo();
                MessageBox.FormBorderStyle = FormBorderStyle.None;
                MessageBox.StartPosition = FormStartPosition.CenterScreen;
                MessageBox.Show();

                return;
            }
            else
            {
                bool isGymNamePresent = gymAdded.Contains(gymCombo.SelectedItem.ToString());
                if (isGymNamePresent == true)
                {
                    Form messageBox = new Essentials.MessageBoxes.prompt("Already Present");
                    messageBox.FormBorderStyle = FormBorderStyle.None;
                    messageBox.StartPosition = FormStartPosition.CenterScreen;
                    messageBox.Show();
                    messageBox.BringToFront();

                    return;
                }
                else
                {
                    gymAdded.Add(gymCombo.SelectedItem.ToString());
                    Form messageBox = new Essentials.MessageBoxes.prompt("Gym Added");
                    messageBox.FormBorderStyle = FormBorderStyle.None;
                    messageBox.StartPosition = FormStartPosition.CenterScreen;
                    messageBox.Show();
                    messageBox.BringToFront();
                    return;
                }
            }
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            if (Exp.Text == "" || txtQualification.Text == "" || txtSpecialization.Text == "")
            {
                Form MessageBox = new Essentials.MessageBoxes.missingInfo();
                MessageBox.FormBorderStyle = FormBorderStyle.None;
                MessageBox.StartPosition = FormStartPosition.CenterScreen;
                MessageBox.Show();

                return;
            }
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            /*
           */

           
            
            for(int i=0; i<gymAdded.Count; i++)
            {
                string query = "INSERT INTO TRAINER_REQUEST VALUES ((SELECT TOP 1 id from userr where username = @username), (SELECT TOP 1 id from gym where name = @gymName), @exp, @spec, @qual)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", currentUser.Username);
                command.Parameters.AddWithValue("@gymName", gymAdded[i]);
                command.Parameters.AddWithValue("@exp", txtExp.Text);
                command.Parameters.AddWithValue("@spec", txtSpecialization.Text);
                command.Parameters.AddWithValue("@qual", txtQualification.Text);
                command.ExecuteNonQuery();
            }




            Form messageBox = new Essentials.MessageBoxes.prompt("Request(s) Sent to Gym Owner(s)");
            messageBox.FormBorderStyle = FormBorderStyle.None;
            messageBox.StartPosition = FormStartPosition.CenterScreen;
            messageBox.Show();
            messageBox.BringToFront();
            messageBox.BringToFront();
            messageBox.BringToFront();




        }
    }
}
