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
using Project_FLEXTrainer.Essentials;


namespace Project_FLEXTrainer.Forms.SubForms
{
    public partial class completeProfile : Form
    {
        User currUser;
        public completeProfile(User user)
        {
            InitializeComponent();

            currUser = user;

            genderCombo.Items.Add("Male");
            genderCombo.Items.Add("Female");

            if (currUser.isProfileComplete == true)
            {
                txt.Text = "Edit Profile";
                txtFname.Text = currUser.firstName;
                txtLname.Text = currUser.lastName;
                if (user.gender == "Male")
                {
                    genderCombo.SelectedIndex = 0;
                }
                else if (user.gender == "Female")
                    genderCombo.SelectedIndex = 1;
            }
            else
            {
                txt.Text = "Complete Profile";
            }
        }


        private void doneBtn_Click(object sender, EventArgs e)
        {
            //Queries to insert data
            if(txtFname.Text=="" || txtLname.Text=="" || genderCombo.SelectedIndex==-1 || genderCombo.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Missing Info!");
                return;
            }

            string connect = ConnectionString.GetConnectionString();
            SqlConnection connection = new SqlConnection (connect);
            connection.Open();
            string query;
            if (currUser.isProfileComplete == false)
            {
                 query = "UPDATE userr SET FirstName = @FirstName,   LastName = @LastName, Gender = @Gender WHERE username = @Username; ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", txtFname.Text);
                command.Parameters.AddWithValue("@LastName", txtLname.Text);
                command.Parameters.AddWithValue("@Gender", genderCombo.SelectedItem.ToString());
                command.Parameters.AddWithValue("@Username", currUser.Username);

                command.ExecuteNonQuery();
            }
            else
            {
                query = "UPDATE userr SET FirstName = @FirstName,   LastName = @LastName, Gender = @Gender WHERE username = @Username; ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", txtFname.Text);
                command.Parameters.AddWithValue("@LastName", txtLname.Text);
                command.Parameters.AddWithValue("@Gender", genderCombo.SelectedItem.ToString());
                command.Parameters.AddWithValue("@Username", currUser.Username);

                command.ExecuteNonQuery();
            }

            
            if (currUser.isProfileComplete == false)
            {
                MessageBox.Show("Profile completed");
                currUser.isProfileComplete = true;
                currUser.firstName = txtFname.Text;
                currUser.lastName= txtLname.Text;
                currUser.gender = genderCombo.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Profile Edited Successfully");
            }

            connection.Close();
        }
    }
}
