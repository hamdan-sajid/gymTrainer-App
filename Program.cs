using Project_FLEXTrainer.Admin;
using Project_FLEXTrainer.Trainer;

namespace Project_FLEXTrainer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            //User user = new User("Maria","Admin","yaaa");
            //Application.Run(new home(user));
            //Application.Run(new home_trainer(user));
            //Application.Run(new home_admin(user));
            //Application.Run(new Owner.home_owner(user));
        }
    }
}