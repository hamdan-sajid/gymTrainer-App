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

namespace Project_FLEXTrainer.Forms.SubForms
{
    public partial class Profile_more : Form
    {
        public Profile_more(User user)
        {
            InitializeComponent();
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-OLHUDAG;Initial Catalog=DB-project;Integrated Security=True;Encrypt=False");
            connection.Open();

            pfp1.Text = user.Username;
            SqlCommand command = new SqlCommand("SELECT firstname FROM userr JOIN account ON userr.username = account.username WHERE account.username = '" + user.Username + "'", connection);
            pfp2.Text = Convert.ToString(command.ExecuteScalar());

            command = new SqlCommand("SELECT lastname FROM userr JOIN account ON userr.username = account.username WHERE account.username = '" + user.Username + "'", connection);
            pfp3.Text = Convert.ToString(command.ExecuteScalar());

            command = new SqlCommand("SELECT gender FROM userr JOIN account ON userr.username = account.username WHERE account.username = '" + user.Username + "'", connection);
            pfp4.Text = Convert.ToString(command.ExecuteScalar());


            pfp1.ForeColor = Color.FromArgb(50, 50, 50); 
            pfp2.ForeColor = Color.FromArgb(50, 50, 50);
            pfp3.ForeColor = Color.FromArgb(50, 50, 50);
            pfp4.ForeColor = Color.FromArgb(50, 50, 50);



        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
