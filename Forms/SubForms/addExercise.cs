using Project_FLEXTrainer.Essentials;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_FLEXTrainer.Forms.SubForms
{
    public partial class addExercise : Form
    {

        private createWorkoutPlan main;
        public addExercise(createWorkoutPlan mainForm)
        {
            InitializeComponent();
            main = mainForm;

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Missing Info");
                return;
            }
            Exercise ex = new Exercise();
            ex.targetMuscle = textBox1.Text;
            ex.Routine = textBox2.Text;
            ex.Sets = textBox4.Text;
            ex.Reps = textBox5.Text;
            ex.Machine = textBox3.Text;

            main.AddExercise(ex);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
