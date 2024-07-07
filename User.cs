using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_FLEXTrainer.Essentials;

namespace Project_FLEXTrainer
{
    public class User
    {
        public string Username { get; set; }

        public string Type { get; set; }
        public string Password { get; set; }
        public int userId;

        public string firstName;
        public string gender;
        public string lastName;
        public bool isProfileComplete;
       // public bool appliedOwner;

        // Constructor
        public User(string username, string type, string password, int ID)
        {
            Username = username;
            Type = type;
            Password = password;
            userId = ID;
            //appliedOwner = false;




            string connect = ConnectionString.GetConnectionString();
            SqlConnection connection = new SqlConnection (connect);
            connection.Open();
            string Query = "SELECT 1 FROM userr WHERE userr.username = '" + Username + "' AND userr.firstname IS NOT NULL AND userr.lastname IS NOT NULL AND userr.gender IS NOT NULL";
            SqlCommand command = new SqlCommand(Query, connection);
            Object result = command.ExecuteScalar();
            int flag = Convert.ToInt32(result);
            if (flag == 1)
                isProfileComplete = true;
            else
            isProfileComplete = false;

        }
    }
}
