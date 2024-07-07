//MNK\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;Trust Server Certificate=True

namespace Project_FLEXTrainer
{
    public partial class Form1 : Form
    {

        private Form1 refForm1;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            register registerMember = new register();
            this.Hide();
            registerMember.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void LoginAs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            login loginMember = new login();
            this.Hide();
            loginMember.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
