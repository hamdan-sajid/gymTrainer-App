using Project_FLEXTrainer.Essentials.MessageBoxes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_FLEXTrainer.Forms.SubForms
{
    public partial class ApplyForOwner : Form
    {
        User currUser;
        string connectionString;
        public ApplyForOwner(User user)
        {
            InitializeComponent();
            currUser = user;
            connectionString = Essentials.ConnectionString.GetConnectionString();
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            if(txtGymName.Text=="" && txtGymLoc.Text == "")
            {
                Form MessageBox = new Essentials.MessageBoxes.missingInfo();
                MessageBox.FormBorderStyle = FormBorderStyle.None;
                MessageBox.StartPosition = FormStartPosition.CenterScreen;
                MessageBox.Show();

                return;
            }

            //get userID 
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string userIDQuery = "SELECT userr.id FROM userr WHERE username = @Username";

            SqlCommand command1 = new SqlCommand(userIDQuery, connection);
            command1.Parameters.AddWithValue("@Username", currUser.Username);

            object result = command1.ExecuteScalar();
            int userId;
            if (result != null)
            {
                userId = Convert.ToInt32(result);
            }
            else
            {
                MessageBox.Show("problem inserting :: username");
                return;
            }

            //request Query
            string requestAdd = "INSERT INTO REQUEST ( memberID, GYMname, location) VALUES ( @UserID, @Name, @Location);";
            SqlCommand command2 = new SqlCommand(requestAdd, connection);
            command2.Parameters.AddWithValue("@UserID",userId);
            command2.Parameters.AddWithValue("@Name",txtGymName.Text);
            command2.Parameters.AddWithValue("@Location",txtGymLoc.Text);
            command2.ExecuteNonQuery();
            connection.Close();

            Form messageBox = new Essentials.MessageBoxes.prompt("Request Sent To Admin");
            messageBox.FormBorderStyle = FormBorderStyle.None;
            messageBox.StartPosition = FormStartPosition.CenterScreen;
            messageBox.Show();
            this.Close();
            messageBox.BringToFront();
            txtGymLoc.Text = "";
            txtGymName.Text = "";
            return;
        }
    }
}
