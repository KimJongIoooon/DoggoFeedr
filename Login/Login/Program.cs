using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()  
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //var dashboard = new Dashboard(new Account());
            //var main = new Main();
            //var dogsettings = new DogSettings(new Account());
            var loginform = new LoginForm();
            loginform.Show();
            Application.Run();
        }
    }
}
