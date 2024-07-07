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
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_FLEXTrainer.Trainer.Forms
{
    public partial class createWorkoutPlan : Form
    {
        List<Essentials.Exercise> ExercisesAdded = new List<Essentials.Exercise>();
        string connectionString;
        User currUser;
        public createWorkoutPlan(User userr)
        {
            InitializeComponent();
            connectionString = Essentials.ConnectionString.GetConnectionString();
            currUser = userr;

            goalCombo.Items.Add("Muscle Gain ");
            goalCombo.Items.Add("Weight Loss ");
            goalCombo.Items.Add("Strength and Power ");
            goalCombo.Items.Add("Endurance and Stamina ");
            goalCombo.Items.Add("Flexibility and Mobility ");
            goalCombo.Items.Add("Functional Fitness: ");
            goalCombo.Items.Add("Rehabilitation");
            goalCombo.Items.Add("Sports-Specific Training ");
            goalCombo.Items.Add("Overall Health ");

            comboSchedule.Items.Add("1 Day/Week");
            comboSchedule.Items.Add("2 Day/Week");
            comboSchedule.Items.Add("3 Day/Week");
            comboSchedule.Items.Add("4 Day/Week");
            comboSchedule.Items.Add("5 Day/Week");
            comboSchedule.Items.Add("6 Day/Week");
            comboSchedule.Items.Add("7 Day/Week");

            comboExperience.Items.Add("Beginner");
            comboExperience.Items.Add("Intermediate");
            comboExperience.Items.Add("Professional");

            string getClients = "SELECT CONCAT(userr.firstname, ' ', userr.lastname) AS name\r\n\tFROM Training_Sessions\r\n\tINNER JOIN userr on Training_Sessions.member_id = userr.id\r\n\tWHERE trainer_id = @trainerID";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(getClients, connection);
            command.Parameters.AddWithValue("@trainerID", userr.userId);
            SqlDataReader reader = command.ExecuteReader();

            clientCombo.Items.Clear();

            while (reader.Read())
            {
                string clientName = reader["name"].ToString();
                clientCombo.Items.Add(clientName);
            }

            reader.Close();
            connection.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddExercise_Click(object sender, EventArgs e)
        {
            if (txtTM.Text == "" || txtR.Text == "" || txtM.Text == "" || txtReps.Text == "" || txtSets.Text == "")
            {
                Form MessageBox = new Essentials.MessageBoxes.missingInfo();
                MessageBox.FormBorderStyle = FormBorderStyle.None;
                MessageBox.StartPosition = FormStartPosition.CenterScreen;
                MessageBox.Show();

                return;
            }
            Exercise ex = new Exercise();
            ex.targetMuscle = txtTM.Text;
            ex.Routine = txtR.Text;
            ex.Sets = txtSets.Text;
            ex.Reps = txtReps.Text;
            ex.Machine = txtM.Text;

            ExercisesAdded.Add(ex);
            comboAddedExercises.Items.Add(txtTM.Text);


            Form messageBox = new Essentials.MessageBoxes.prompt("Exercise Added to Plan");
            messageBox.FormBorderStyle = FormBorderStyle.None;
            messageBox.StartPosition = FormStartPosition.CenterScreen;
            messageBox.Show();
            txtTM.Text = "";
            txtR.Text = "";
            txtM.Text = "";
            txtReps.Text = "";
            txtSets.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DName.Text == "" || goalCombo.SelectedIndex == -1 || comboExperience.SelectedIndex == -1 || comboSchedule.SelectedIndex == -1 || ExercisesAdded.Count == 0)
            {
                Form MessageBox = new Essentials.MessageBoxes.missingInfo();
                MessageBox.FormBorderStyle = FormBorderStyle.None;
                MessageBox.StartPosition = FormStartPosition.CenterScreen;
                MessageBox.Show();

                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                //Inserting Plan Query
                string queryPlanInsert = "INSERT INTO Plann  VALUES ('" + DName.Text + "', '" + currUser.Type + "', " + currUser.userId + ", 'public');";
                SqlCommand command2 = new SqlCommand(queryPlanInsert, connection);
                int resultt = command2.ExecuteNonQuery();

                string getPlanId = "SELECT SCOPE_IDENTITY();";
                SqlCommand commandID = new SqlCommand(getPlanId, connection);
                object idresult = commandID.ExecuteScalar();
                int insertedId = Convert.ToInt32(idresult);

                string queryWPInsert = "INSERT INTO workout_plan  VALUES ('" + goalCombo.SelectedItem.ToString() + "', '" + comboExperience.SelectedItem.ToString() + "', '" + comboSchedule.SelectedItem.ToString() + "', " + insertedId + ");";
                SqlCommand command3 = new SqlCommand(queryWPInsert, connection);
                command3.ExecuteNonQuery();


                //Inserting Meals
                for (int i = 0; i < ExercisesAdded.Count; i++)
                {

                    string queryExerciseAdd = "INSERT INTO exercise (reps, sets, target_muscles, routine, machine, plan_id) " +
                                          "VALUES (@Reps, @Sets, @TargetMuscles, @Routine, @Machine, @PlanId)";
                    SqlCommand command4 = new SqlCommand(queryExerciseAdd, connection);
                    command4.Parameters.AddWithValue("@Reps", ExercisesAdded[i].Sets);
                    command4.Parameters.AddWithValue("@Sets", ExercisesAdded[i].Reps);
                    command4.Parameters.AddWithValue("@TargetMuscles", ExercisesAdded[i].targetMuscle);
                    command4.Parameters.AddWithValue("@Routine", ExercisesAdded[i].Routine);
                    command4.Parameters.AddWithValue("@Machine", ExercisesAdded[i].Machine); // Assuming this is a string
                    command4.Parameters.AddWithValue("@PlanId", insertedId); // 

                    command4.ExecuteNonQuery();
                }

                string queryUserPlan = "INSERT into UserPlans VALUES (" + currUser.userId + "," + insertedId + ");";
                SqlCommand command5 = new SqlCommand(queryUserPlan, connection);
                command5.ExecuteNonQuery();

                string queryUserPlann = "INSERT into UserPlans VALUES ((SELECT id FROM userr WHERE CONCAT(firstname, ' ', lastname) = @fullName ) , @insertedID);";
                SqlCommand command6 = new SqlCommand(queryUserPlann, connection);
                command6.Parameters.AddWithValue("@fullName", clientCombo.SelectedItem.ToString());
                command6.Parameters.AddWithValue("@insertedID", insertedId);

                command6.ExecuteNonQuery();

                Form messageBox = new Essentials.MessageBoxes.prompt("Workout Plan Created Successfully for Client");
                messageBox.FormBorderStyle = FormBorderStyle.None;
                messageBox.StartPosition = FormStartPosition.CenterScreen;
                messageBox.Show();
                messageBox.BringToFront();
                connection.Close();

            }
        }
    }
}
