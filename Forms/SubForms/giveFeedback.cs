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

namespace Project_FLEXTrainer.Forms.SubForms
{
    public partial class giveFeedback : Form
    {
        User currUser;
        string connectionString;

        public giveFeedback(User user)
        {
            InitializeComponent();

            currUser = user;
            connectionString = Essentials.ConnectionString.GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "GetTrainersForMember @username";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    try
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@username", currUser.Username);

                        SqlDataReader reader = command.ExecuteReader();

                        comboTrainer.Items.Clear();

                        while (reader.Read())
                        {
                            string trainerName = reader["trainer_name"].ToString();
                            comboTrainer.Items.Add(trainerName);
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            ratingCombo.Items.Add("1");
            ratingCombo.Items.Add("2");
            ratingCombo.Items.Add("3");
            ratingCombo.Items.Add("4");
            ratingCombo.Items.Add("5");


            this.currUser = currUser;
            this.connectionString = connectionString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            if(ratingCombo.SelectedIndex==-1 || feedbackmsg.Text == "")
            {
                Form MessageBox = new Essentials.MessageBoxes.missingInfo();
                MessageBox.FormBorderStyle = FormBorderStyle.None;
                MessageBox.StartPosition = FormStartPosition.CenterScreen;
                MessageBox.Show();

                return;
            }

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "GiveFeedback @message, @rating, @trainerFullName, @memberUsername";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@message", feedbackmsg.Text);
            command.Parameters.AddWithValue("@rating", ratingCombo.SelectedItem.ToString());
            command.Parameters.AddWithValue("@trainerFullName", comboTrainer.SelectedItem.ToString());
            command.Parameters.AddWithValue("@memberUsername", currUser.Username);

            command.ExecuteNonQuery();

            string getRating = "SELECT rating\r\nFROM trainer\r\nINNER JOIN userr on userr.id = trainer.id\r\nWHERE CONCAT(userr.firstname, ' ', userr.lastname) = @trainerFullName";
            SqlCommand command1 = new SqlCommand(getRating, connection);
            command1.Parameters.AddWithValue("@trainerFullName", comboTrainer.SelectedItem.ToString());

            object resultObj = command1.ExecuteScalar();
            int result;
            if (resultObj != null)
            {
                result = Convert.ToInt32(resultObj);
                MessageBox.Show("current rating : " + result + "");

            }
            else
            {
                MessageBox.Show("Rating Not Found");
                return;
            }
            int countf;
            string countFeedbacks = "SELECT COUNT (*)\r\nFROM feedback\r\nINNER JOIN trainer on trainer.id = feedback.trainer_id\r\nINNER JOIN userr on userr.id = trainer.id\r\nWHERE CONCAT(userr.firstname, ' ', userr.lastname) = @trainerFullName";
            SqlCommand command2 = new SqlCommand(countFeedbacks, connection);
            command2.Parameters.AddWithValue("@trainerFullName", comboTrainer.SelectedItem.ToString());

            object resultObj1 = command2.ExecuteScalar();

            if (resultObj1 != null)
            {
                countf = Convert.ToInt32(resultObj1);
                MessageBox.Show("numFeedbacks (including this) : " + countf + "");

            }
            else
            {
                MessageBox.Show("count");
                return;
            }
            int newRating;
            newRating = (result + Convert.ToInt32(ratingCombo.SelectedItem))/countf;

            MessageBox.Show("new rating : " + newRating + "");

            string updateRating = "EXEC updateTrainerRating @name, @newRating";
            SqlCommand command3 = new SqlCommand(updateRating, connection);
            command3.Parameters.AddWithValue("@name", comboTrainer.SelectedItem.ToString());
            command3.Parameters.AddWithValue("@newRating", newRating.ToString());

            command3.ExecuteNonQuery();

            Form messageBox = new Essentials.MessageBoxes.prompt("Feedback Sent");
            messageBox.FormBorderStyle = FormBorderStyle.None;
            messageBox.StartPosition = FormStartPosition.CenterScreen;
            messageBox.Show();
            this.Close();
            messageBox.BringToFront();

            connection.Close();

        }
    }
}
