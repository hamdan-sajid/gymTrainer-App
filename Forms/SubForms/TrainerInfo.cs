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
    public partial class TrainerInfo : Form
    {
        string connectionString;
        User currUser;
        string thegymname;
        string trainerID;
        public TrainerInfo(string id, string name, string gender, string experience, string rating, User user)
        {
            InitializeComponent();
            currUser = user;
            label1.Text = name;
            label2.Text = "Experience " + experience;
            label3.Text = "Rating " + rating;
            trainerID = id;

            connectionString = Essentials.ConnectionString.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string gymMembership;

            string query = "SELECT name\r\nFrom gym\r\nINNER JOIN MemberMembership on MemberMembership.gymId=gym.id\r\nINNER JOIN userr on userr.id = MemberMembership.memberId\r\nWHERE userr.username = @userName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@userName", currUser.Username);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                gymMembership = reader["name"].ToString();
                gymName.Text = gymMembership;
                thegymname = gymMembership;
            }

            reader.Close();


        }

        private void TimingCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void closeError_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (txtTiming.Text == "")
            {
                Form MessageBox = new Essentials.MessageBoxes.missingInfo();
                MessageBox.FormBorderStyle = FormBorderStyle.None;
                MessageBox.StartPosition = FormStartPosition.CenterScreen;
                MessageBox.Show();

                return;
            }

            SqlConnection connection = new SqlConnection (connectionString);
            connection.Open();

                string queryExec = "EXEC AddTrainingAppointmentWithTrainer @username, @gymname, @timing, @trainerID;";
                //MessageBox.Show(""+currUser.userId+", "+gymName.Text+", "+txtTiming.Text.ToString()+","+label1.Text.ToString()+"");
                SqlCommand command = new SqlCommand(queryExec, connection);
                command.Parameters.AddWithValue("@username", currUser.Username);
                command.Parameters.AddWithValue("@gymname", gymName.Text);
                command.Parameters.AddWithValue("@timing", txtTiming.Text); // Convert to string explicitly
                command.Parameters.AddWithValue("@trainerID", trainerID); // Assuming label1.Text contains the trainer's name


                // Execute the command
                command.ExecuteNonQuery();

                // Close the connection
                Form messageBox = new Essentials.MessageBoxes.prompt("Appointment Booked Successfully");
                messageBox.FormBorderStyle = FormBorderStyle.None;
                messageBox.StartPosition = FormStartPosition.CenterScreen;
                messageBox.Show();
                this.Close();
                messageBox.BringToFront();

                connection.Close();
            


            
            


        
        }
    }
}
