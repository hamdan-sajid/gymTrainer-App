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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Project_FLEXTrainer
{
    public partial class login : Form
    {
        string user;
        string connectionString;
        public login()
        {
            InitializeComponent();
            connectionString = Essentials.ConnectionString.GetConnectionString();

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Username";
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (Pass.Text == "Password")
            {
                Pass.Text = "";
            }
            Pass.PasswordChar = '\u25CF'; // Set consistent password masking character
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Pass.Text))
            {
                Pass.PasswordChar = '\0'; // Reset PasswordChar to default (no masking)
                Pass.Text = "Password";
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tesxtBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void link_click(object sender, EventArgs e) //dive back in time ~~~
        {
            register regMember = new register();
            regMember.Show();
            this.Close();
        }

        private void button2_click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            //SqlConnection connection = new SqlConnection("Data Source=MNK\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;Encrypt=False");
            connection.Open();
            SqlCommand checkifuser = new SqlCommand("SELECT 1 FROM dbo.account WHERE Username = '" + textBox1.Text + "'", connection);
            int flag = Convert.ToInt32(checkifuser.ExecuteScalar());
            
            if (flag != 1)
            {
                Form messageBox = new Essentials.MessageBoxes.prompt_dismiss("Username Does Not Exist");
                messageBox.FormBorderStyle = FormBorderStyle.None;
                messageBox.StartPosition = FormStartPosition.CenterScreen;
                messageBox.Show();
            }
            else
            {
                SqlCommand returnpass = new SqlCommand("SELECT Password FROM dbo.account WHERE Username = '" + textBox1.Text + "'", connection);
                string passw = Convert.ToString(returnpass.ExecuteScalar());
                if (passw == Pass.Text)
                {
                    
                    Essentials.MessageBoxes.prompt messageBox = new Essentials.MessageBoxes.prompt("Login Successful");
                    messageBox.FormBorderStyle = FormBorderStyle.None;
                    messageBox.StartPosition = FormStartPosition.CenterScreen;


                    messageBox.OKButtonClick += (sender, e) =>
                    {
                        string connectString = Essentials.ConnectionString.GetConnectionString();
                        SqlConnection Connection = new SqlConnection(connectString);
                        Connection.Open();
                        SqlCommand account_type = new SqlCommand("Select account_type from dbo.account where Username = '" + textBox1.Text + "'", Connection);
                        string acc_t = Convert.ToString(account_type.ExecuteScalar());

                        SqlCommand getUserID = new SqlCommand("Select id FROM userr where Username = '" + textBox1.Text + "'", Connection);
                        int userID = Convert.ToInt32(getUserID.ExecuteScalar());
                        User currentUser = new User(textBox1.Text, acc_t, passw, userID);

                        if (currentUser.Type == "member")
                        {
                            home home = new home(currentUser);
                            home.Show();
                        }

                        else if (currentUser.Type == "owner")
                        {
                            Owner.home_owner own = new Owner.home_owner(currentUser);
                            own.Show();
                        }
                        else if (currentUser.Type == "admin" || currentUser.Type == "Admin")
                        {
                            Admin.home_admin form = new Admin.home_admin(currentUser);
                            form.Show();
                        }
                        else if (currentUser.Type == "Trainer" || currentUser.Type == "trainer")
                        {
                            Trainer.home_trainer form = new Trainer.home_trainer(currentUser);
                            form.Show();
                        }




                        this.Close();
                    };
                    messageBox.Show();
                }
                else
                {
                    Form messageBox = new Essentials.MessageBoxes.prompt_dismiss("Incorrect Password");
                    messageBox.FormBorderStyle = FormBorderStyle.None;
                    messageBox.StartPosition = FormStartPosition.CenterScreen;
                    messageBox.Show();


                    return;

                }
            }
            connection.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
