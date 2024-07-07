using Project_FLEXTrainer.Essentials.MessageBoxes;
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

namespace Project_FLEXTrainer.Forms
{
    public partial class Membership : Form
    {
        string connectionString;
        User currUser;
        bool alreadyMember;
        public Membership(User user)
        {
            InitializeComponent();
            currUser = user;
            connectionString = Essentials.ConnectionString.GetConnectionString();
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

                string query = "SELECT 1 FROM MemberMembership WHERE memberId = @id";
                SqlCommand command1 = new SqlCommand(query, connection);
                command1.Parameters.AddWithValue("@id", currUser.userId);

                object result = command1.ExecuteScalar();

                if (result == null)
                {
                    noMemberPanel.Visible = true;
                    alreadyMember = false;
                }
                else
                {
                    noMemberPanel.Visible = false;
                    alreadyMember = true;

                    string exec = "EXEC checkMembership @userID";
                    SqlCommand execc = new SqlCommand(exec, connection);
                    execc.Parameters.AddWithValue("@userID", currUser.userId);

                    SqlDataReader reader = execc.ExecuteReader();

                    if (reader.Read())
                    {
                        txtGym.Text = "Gym: " + reader["name"].ToString();
                        txtPlan.Text = "Plan Type: " + reader["type"].ToString();
                    }
                    reader.Close();
                }
                connection.Close();
            }
        }

        private void closeError_Click(object sender, EventArgs e)
        {
            noMemberPanel.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (alreadyMember)
            {
                Form messageBox = new Essentials.MessageBoxes.prompt("Can only have one Membership");
                messageBox.FormBorderStyle = FormBorderStyle.None;
                messageBox.StartPosition = FormStartPosition.CenterScreen;
                messageBox.Show();
                messageBox.BringToFront();
                return;
            }

            if (currUser.isProfileComplete == false)
            {
                Form messageBox = new customMessage_CompleteProfile();
                messageBox.FormBorderStyle = FormBorderStyle.None;
                messageBox.StartPosition = FormStartPosition.CenterScreen;
                messageBox.Show();

                return;
            }

            if (gunaCombo.SelectedIndex == -1)
            {
                MessageBox.Show("Missing INFO");
                return;
            }

            string sqlQuery = "INSERT INTO MemberMembership VALUES (@userId, (SELECT id\r\nFrom gym\r\nWHERE gym.name=@gymName), 'Basic','2024-06-14');";
            string selectedGymName = gunaCombo.SelectedItem.ToString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@userId", currUser.userId);
                        command.Parameters.AddWithValue("@gymName", selectedGymName);
                        connection.Open();

                        command.ExecuteNonQuery();

                        Form messageBox = new Essentials.MessageBoxes.prompt("Applied Successfully");
                        messageBox.FormBorderStyle = FormBorderStyle.None;
                        messageBox.StartPosition = FormStartPosition.CenterScreen;
                        messageBox.Show();
                        messageBox.BringToFront();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void gunaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gunaCombo.SelectedIndex != -1)
            {
                string selectedGymName = gunaCombo.SelectedItem.ToString();

                string sqlQuery = "SELECT basic_price, premium_price\r\nFROM gymMembership\r\nINNER JOIN gym on gym.id=gymMembership.gymId\r\nWHERE gym.name=@gymName";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        try
                        {
                            command.Parameters.AddWithValue("@gymName", selectedGymName);
                            connection.Open();

                            SqlDataReader reader = command.ExecuteReader();

                            if (reader.Read())
                            {
                                lblBasic.Text = "$" + reader["basic_price"].ToString();
                                lblPremium.Text = "$" + reader["premium_price"].ToString();
                            }

                            // Close the SqlDataReader
                            reader.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (alreadyMember)
            {
                Form messageBox = new Essentials.MessageBoxes.prompt("Can only have one Membership");
                messageBox.FormBorderStyle = FormBorderStyle.None;
                messageBox.StartPosition = FormStartPosition.CenterScreen;
                messageBox.Show();
                messageBox.BringToFront();
                return;
            }

            if (currUser.isProfileComplete == false)
            {
                Form messageBox = new customMessage_CompleteProfile();
                messageBox.FormBorderStyle = FormBorderStyle.None;
                messageBox.StartPosition = FormStartPosition.CenterScreen;
                messageBox.Show();

                return;
            }
            string sqlQuery = "INSERT INTO MemberMembership VALUES (@userId, (SELECT id\r\nFrom gym\r\nWHERE gym.name=@gymName), 'Premium','2024-06-14');";
            //string sqlQuery = "INSERT INTO MemberMembership VALUES ((SELECT id\r\nFROM userr\r\nWHERE username = @username), (SELECT id\r\nFrom gym\r\nWHERE gym.name=@gymName), 'Premium','2024-06-14');";
            string selectedGymName = gunaCombo.SelectedItem.ToString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@userId", currUser.userId);
                        command.Parameters.AddWithValue("@gymName", selectedGymName);
                        connection.Open();

                        command.ExecuteNonQuery();
                        Form messageBox = new Essentials.MessageBoxes.prompt("Applied Successfully");
                        messageBox.FormBorderStyle = FormBorderStyle.None;
                        messageBox.StartPosition = FormStartPosition.CenterScreen;
                        messageBox.Show();
                        messageBox.BringToFront();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void gunaCombo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
