using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_FLEXTrainer.Owner.Forms
{
    public partial class addTrainer : Form
    {
        User currUser;
        public addTrainer(User currUser)
        {
            InitializeComponent();

            comboBox1.Items.Add("Male");
            comboBox1.Items.Add("Female");
            this.currUser = currUser;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (txtAcc.Text == "" || txtPass.Text == "" || txtEmail.Text == "" || txtFname.Text == "" || txtLname.Text == "" || txtSpeciality.Text == "" || txtQualification.Text == "" || comboBox1.SelectedIndex == -1 || expTxt.Text == "")
            {
                Form MessageBox = new Essentials.MessageBoxes.missingInfo();
                MessageBox.FormBorderStyle = FormBorderStyle.None;
                MessageBox.StartPosition = FormStartPosition.CenterScreen;
                MessageBox.Show();
                return;
            }


            SqlConnection connection = new SqlConnection(Essentials.ConnectionString.GetConnectionString());
            connection.Open();

            string usercheck = "SELECT 1 FROM dbo.account WHERE Username = '" + txtAcc.Text + "'";
            SqlCommand usercheckcmd = new SqlCommand(usercheck, connection);



            int flag = Convert.ToInt32(usercheckcmd.ExecuteScalar());

            if (flag == 1)
            {
                MessageBox.Show("This username is taken!");
                return;
            }

            string query0 = "INSERT INTO account  VALUES (@username, 'trainer', @email, @pass);";
            SqlCommand command0 = new SqlCommand(query0, connection);
            command0.Parameters.AddWithValue("@username", txtAcc.Text);
            command0.Parameters.AddWithValue("@email", txtEmail.Text);
            command0.Parameters.AddWithValue("@pass", txtPass.Text);
            command0.ExecuteNonQuery();


            string query00 = "INSERT INTO userr  VALUES ( @fname, @lname, @username, @gender);";
            SqlCommand command00 = new SqlCommand(query00, connection);
            command00.Parameters.AddWithValue("@fname", txtFname.Text);
            command00.Parameters.AddWithValue("@lname", txtLname.Text);
            command00.Parameters.AddWithValue("@username", txtAcc.Text);
            command00.Parameters.AddWithValue("@gender", comboBox1.SelectedItem.ToString());
            command00.ExecuteNonQuery();

            string getPlanId = "SELECT id from userr where username = @username";
            SqlCommand commandID = new SqlCommand(getPlanId, connection);
            commandID.Parameters.AddWithValue("@username", txtAcc.Text);
            object idresult = commandID.ExecuteScalar();
            string userID = Convert.ToString(idresult);

            string query1 = "INSERT INTO trainer VALUES (@userid, @specialization, @qualification, 0, @experience)";
            SqlCommand command1 = new SqlCommand(query1, connection);
            command1.Parameters.AddWithValue("@userid", userID);
            command1.Parameters.AddWithValue("@specialization", txtSpeciality.Text);
            command1.Parameters.AddWithValue("@qualification", txtQualification.Text);
            command1.Parameters.AddWithValue("@experience", expTxt.Text);

            command1.ExecuteNonQuery();

            string query2 = "INSERT INTO gym_assign_to_trainer VALUES (@userID, (select id \r\n\tFROM gym\r\n\twhere owner_id = @ownerID))";
            SqlCommand command = new SqlCommand(query2, connection);
            command.Parameters.AddWithValue("@userID", userID);
            command.Parameters.AddWithValue("@ownerID", currUser.userId);
            command.ExecuteNonQuery();

            Form messageBox = new Essentials.MessageBoxes.prompt("Trainer Added!");
            messageBox.FormBorderStyle = FormBorderStyle.None;
            messageBox.StartPosition = FormStartPosition.CenterScreen;
            messageBox.Show();
            messageBox.BringToFront();
            messageBox.BringToFront();

            connection.Close();

            txtAcc.Text = "";
            txtPass.Text = "";
            txtEmail.Text = "";
            txtFname.Text = "";
            txtLname.Text = "";
            txtSpeciality.Text = "";
            txtQualification.Text = "";
            comboBox1.SelectedIndex = -1;
            expTxt.Text = "";


        }

        private void txtAcc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
