using Project_FLEXTrainer.Essentials;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_FLEXTrainer.Forms.SubForms
{
    public partial class createWorkoutPlan : Form
    {
        List<Essentials.Exercise> ExercisesAdded = new List<Essentials.Exercise>();
        private string connectionString;
        User currUser;
        public createWorkoutPlan(User user)
        {
            InitializeComponent();
            goalCombo.Items.Add("Muscle Gain ");
            goalCombo.Items.Add("Weight Loss ");
            goalCombo.Items.Add("Strength and Power ");
            goalCombo.Items.Add("Endurance and Stamina ");
            goalCombo.Items.Add("Flexibility and Mobility ");
            goalCombo.Items.Add("Functional Fitness: ");
            goalCombo.Items.Add("Rehabilitation");
            goalCombo.Items.Add("Sports-Specific Training ");
            goalCombo.Items.Add("Overall Health ");

            ScheduleCombo.Items.Add("1 Day/Week");
            ScheduleCombo.Items.Add("2 Day/Week");
            ScheduleCombo.Items.Add("3 Day/Week");
            ScheduleCombo.Items.Add("4 Day/Week");
            ScheduleCombo.Items.Add("5 Day/Week");
            ScheduleCombo.Items.Add("6 Day/Week");
            ScheduleCombo.Items.Add("7 Day/Week");

            ExpCombo.Items.Add("Beginner");
            ExpCombo.Items.Add("Intermediate");
            ExpCombo.Items.Add("Professional");

            statusCombo.Items.Add("Private");
            statusCombo.Items.Add("Public");

            connectionString = ConnectionString.GetConnectionString();
            currUser = user;

        }

        private void btnAddExercise_Click(object sender, EventArgs e)
        {

            Forms.SubForms.addExercise SubForm = new Forms.SubForms.addExercise(this);
            SubForm.FormBorderStyle = FormBorderStyle.None; // Remove title bar
            SubForm.Dock = DockStyle.Fill;
            SubForm.TopLevel = false;
            this.exPanel.Controls.Add(SubForm);
            this.exPanel.Tag = SubForm;
            SubForm.BringToFront();
            SubForm.Show();
        }
        public void AddExercise(Exercise exercise)
        {
            ExercisesAdded.Add(exercise);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (ExercisesAdded.Count == 0)
            {
                MessageBox.Show("Please added at least one Exercise.");
                return;
            }

            if (txtPlanName.Text == "" || goalCombo.SelectedItem.ToString() == "" || ScheduleCombo.SelectedItem.ToString() == "" || ExpCombo.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Missing Info!");
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string userIDQuery = "SELECT userr.id FROM userr WHERE username = @Username";

                SqlCommand command1 = new SqlCommand(userIDQuery, connection);
                command1.Parameters.AddWithValue("@Username", currUser.Username);
                //connection.Open();
                object result = command1.ExecuteScalar();
                string userId;
                if (result != null)
                {
                    userId = Convert.ToString(result);
                }
                else
                {
                    MessageBox.Show("problem inserting :: username");
                    return;
                }
                string queryPlanInsert = "INSERT INTO Plann  VALUES ('" + txtPlanName.Text + "', '" + currUser.Type + "', " + userId + ", '" + statusCombo.Text + "');";
                SqlCommand command2 = new SqlCommand(queryPlanInsert, connection);
                int resultt = command2.ExecuteNonQuery();
                string getPlanId = "SELECT SCOPE_IDENTITY();";
                SqlCommand commandID = new SqlCommand(getPlanId, connection);

                object idresult = commandID.ExecuteScalar();
                int insertedId = Convert.ToInt32(idresult);
                MessageBox.Show("" + insertedId + "");

                string queryWPInsert = "INSERT INTO workout_plan  VALUES ('" + goalCombo.SelectedItem.ToString() + "', '" + ExpCombo.SelectedItem.ToString() + "', '" + ScheduleCombo.SelectedItem.ToString() + "', " + insertedId + ");";
                SqlCommand command3 = new SqlCommand(queryWPInsert, connection);
                command3.ExecuteNonQuery();


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
                    command4.Parameters.AddWithValue("@PlanId", insertedId); // Assuming this is your inserted ID+ ExercisesAdded[0].Routine +"', '" + ExercisesAdded[0].Machine + "', "+insertedId+");";
                                                                             //SqlCommand command4 = new SqlCommand(queryExerciseAdd, connection);
                    command4.ExecuteNonQuery();
                }

                string queryUserPlan = "INSERT into UserPlans VALUES (" + userId + "," + insertedId + ");";
                SqlCommand command5 = new SqlCommand(queryUserPlan, connection);
                command5.ExecuteNonQuery();

                connection.Close();

            }


        }

        private void txtPlanName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
