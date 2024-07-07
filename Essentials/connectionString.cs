using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_FLEXTrainer.Essentials
{
    public static class ConnectionString
    {
        public static string GetConnectionString()
        {
            //return "Data Source=MNK\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;Encrypt=False";
            return "Data Source=DESKTOP-OLHUDAG;Initial Catalog=JAJA;Integrated Security=True;Encrypt=False";
        }
    }
}
