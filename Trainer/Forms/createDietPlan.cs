using Microsoft.VisualBasic.ApplicationServices;
using Project_FLEXTrainer.Essentials;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_FLEXTrainer.Trainer.Forms
{

    public partial class createDietPlan : Form
    {
        List<Essentials.Meal> MealsAdded = new List<Essentials.Meal>();
        string connectionString;
        User currUser;
        public createDietPlan(User userr)
        {
            InitializeComponent();
            connectionString = Essentials.ConnectionString.GetConnectionString();
            currUser = userr;

            listGoals.Items.Add("Muscle Building");
            listGoals.Items.Add("Weight Management");
            listGoals.Items.Add("Pre-Workout Nutrition");
            listGoals.Items.Add("Post-Workout Nutrition");
            listGoals.Items.Add("Hydration");
            listGoals.Items.Add("Supplementation");

            listType.Items.Add("Mediterranean Diet");
            listType.Items.Add("Paleo Diet");
            listType.Items.Add("Keto Diet (Ketogenic)");
            listType.Items.Add("Vegetarian Diet");
            listType.Items.Add("Vegan Diet");
            listType.Items.Add("Low-Carb Diet");
            listType.Items.Add("Intermittent Fasting");
            listType.Items.Add("Mediterranean Diet");

            ListNutrition.Items.Add("Macronutrients");
            ListNutrition.Items.Add("Proteins");
            ListNutrition.Items.Add("Fats");
            ListNutrition.Items.Add("Vitamins");
            ListNutrition.Items.Add("Minerals");

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

        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" ||AllergensTxt.Text == "" || txtProts.Text == "" || txtCals.Text == "" || txtCarbs.Text == "" || txtFats.Text == "")
            {
                Form MessageBox = new Essentials.MessageBoxes.missingInfo();
                MessageBox.FormBorderStyle = FormBorderStyle.None;
                MessageBox.StartPosition = FormStartPosition.CenterScreen;
                MessageBox.Show();

                return;
            }
            Meal meal = new Meal();
            meal.Name = txtName.Text;
            meal.Allergens = AllergensTxt.Text;
            meal.Proteins = txtProts.Text;
            meal.Carbs = txtCarbs.Text;
            meal.Fats = txtFats.Text;
            meal.Calories = txtCals.Text;

            MealsAdded.Add(meal);
            comboAddedMeals.Items.Add(txtName.Text);


            Form messageBox = new Essentials.MessageBoxes.prompt("Meal Added to Plan");
            messageBox.FormBorderStyle = FormBorderStyle.None;
            messageBox.StartPosition = FormStartPosition.CenterScreen;
            messageBox.Show();
            txtName.Text = "";
            AllergensTxt.Text = "";
            txtProts.Text = "";
            txtFats.Text = "";
            txtCals.Text = "";
            txtCarbs.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(DName.Text=="" || listGoals.SelectedIndex==-1 || listType.SelectedIndex==-1 || ListNutrition.SelectedIndex==-1 || MealsAdded.Count==0) {
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

                //Inserting Diet Plan Query
                string queryDPInsert = "INSERT INTO diet_plan  VALUES ('" + ListNutrition.SelectedItem.ToString() + "', '" + listType.SelectedItem.ToString() + "', '" + listGoals.SelectedItem.ToString() + "', " + insertedId + ");";
                SqlCommand command3 = new SqlCommand(queryDPInsert, connection);
                command3.ExecuteNonQuery();


                //Inserting Meals
                for (int i = 0; i < MealsAdded.Count; i++)
                {

                    string queryMealAdd = "INSERT INTO meals (meal_name,allergents,proteins, carbs, fats, calories, plan_id) " +
                                          "VALUES (@mn,@Allergens, @prots, @carbs, @fats, @cals, @PlanID)";
                    SqlCommand command4 = new SqlCommand(queryMealAdd, connection);
                    command4.Parameters.AddWithValue("@mn", MealsAdded[i].Name);
                    command4.Parameters.AddWithValue("@Allergens", MealsAdded[i].Allergens);
                    command4.Parameters.AddWithValue("@prots", Convert.ToInt32(MealsAdded[i].Proteins));
                    command4.Parameters.AddWithValue("@carbs", Convert.ToInt32(MealsAdded[i].Carbs));
                    command4.Parameters.AddWithValue("@fats", Convert.ToInt32(MealsAdded[i].Fats));
                    command4.Parameters.AddWithValue("@cals", Convert.ToInt32(MealsAdded[i].Calories));
                    command4.Parameters.AddWithValue("@PlanID", insertedId);

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

                Form messageBox = new Essentials.MessageBoxes.prompt("Diet Plan Created Successfully for Client");
                messageBox.FormBorderStyle = FormBorderStyle.None;
                messageBox.StartPosition = FormStartPosition.CenterScreen;
                messageBox.Show();
                messageBox.BringToFront();
                connection.Close();


            }
        }
    }
}
