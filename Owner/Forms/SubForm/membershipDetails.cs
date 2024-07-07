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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_FLEXTrainer.Owner.Forms.SubForm
{
    public partial class membershipDetails : Form
    {
        string connectionString;
        User currUser;
        public membershipDetails(User user)
        {
            InitializeComponent();
            connectionString = Essentials.ConnectionString.GetConnectionString();
            currUser = user;
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            if(txtBasic.Text=="" || txtPremium.Text == "")
            {
                Form MessageBox = new Essentials.MessageBoxes.missingInfo();
                MessageBox.FormBorderStyle = FormBorderStyle.None;
                MessageBox.StartPosition = FormStartPosition.CenterScreen;
                MessageBox.Show();

                return;
            }
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string queryProc = "UpdateGymMembershipPrices"; 
            SqlCommand command = new SqlCommand(queryProc, connection);
            command.CommandType = CommandType.StoredProcedure; 

            command.Parameters.AddWithValue("@username", currUser.Username);
            command.Parameters.AddWithValue("@basicPrice", txtBasic.Text);
            command.Parameters.AddWithValue("@premiumPrice", txtPremium.Text);

            try
            {
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Essentials.MessageBoxes.prompt messageBox = new Essentials.MessageBoxes.prompt("Details Added");
                    messageBox.FormBorderStyle = FormBorderStyle.None;
                    messageBox.StartPosition = FormStartPosition.CenterScreen;
                    messageBox.Show();
                }
                else
                {
                    Essentials.MessageBoxes.prompt messageBox = new Essentials.MessageBoxes.prompt("Error");
                    messageBox.FormBorderStyle = FormBorderStyle.None;
                    messageBox.StartPosition = FormStartPosition.CenterScreen;
                    messageBox.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            this.Close();

        }
    }
}
