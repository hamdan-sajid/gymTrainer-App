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

namespace Project_FLEXTrainer.Forms.SubForms
{
    public partial class createDietPlancs : Form
    {
        List<Essentials.Meal> MealsAdded = new List<Essentials.Meal>();
        string connectionString;
        User currUser;
        public createDietPlancs(User userr)
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
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            Forms.SubForms.addMeal SubForm = new Forms.SubForms.addMeal(this);
            SubForm.FormBorderStyle = FormBorderStyle.None; // Remove title bar
            SubForm.Dock = DockStyle.Fill;
            SubForm.TopLevel = false;
            this.mealPanel.Controls.Add(SubForm);
            this.mealPanel.Tag = SubForm;
            SubForm.BringToFront();
            SubForm.Show();
        }
        public void AddMeal(Meal meal)
        {
            MealsAdded.Add(meal);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (MealsAdded.Count == 0)
            {
                MessageBox.Show("Please add at least one Meal");
            }
            if (txtPlanName.Text=="" || listGoals.SelectedItem.ToString() == "" || ListNutrition.SelectedItem.ToString() == "" || listType.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Missing Info!");
                return;
            }



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                //query to get usernID
                string userIDQuery = "SELECT userr.id FROM userr WHERE username = @Username";

                SqlCommand command1 = new SqlCommand(userIDQuery, connection);
                command1.Parameters.AddWithValue("@Username", currUser.Username);
             
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
                //Inserting Plan Query
                string queryPlanInsert = "INSERT INTO Plann  VALUES ('" + txtPlanName.Text + "', '" + currUser.Type + "', " + userId + ", '" + statusCombo.Text + "');";
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

                string queryUserPlan = "INSERT into UserPlans VALUES ("+userId+","+insertedId+");";
                SqlCommand command5 = new SqlCommand(queryUserPlan, connection);
                command5.ExecuteNonQuery();

                Form messageBox = new Essentials.MessageBoxes.prompt("Plan Created!");
                messageBox.FormBorderStyle = FormBorderStyle.None;
                messageBox.StartPosition = FormStartPosition.CenterScreen;
                messageBox.Show();
                connection.Close();


            }

        }
    }
}
