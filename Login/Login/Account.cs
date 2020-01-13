using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Login
{
    class Account
    {
        private MySqlConnection con = new MySqlConnection("server=192.168.8.14;uid=root;pwd=root;database=DoggoFeedr;");
        private MySqlDataAdapter login;
        private MySqlDataAdapter idSelect;
        
        public static int Id { get; private set; } 
        public static string Name { get; private set; }
        string Password;
        string Email;
        bool isLoggedIn;
        //List<Dog> dogs = new List<Dog>();
        //List<Feeder> feeders = new List<Feeder>();
        //List<Food> foods = new List<Food>();
        
        public bool Login(string username, string password)
        {
            var Database = new Database();
            if (Database.Login(username, password))
            {
                var loginform = new LoginForm();
                loginform.Hide();
                var dashboard = new Dashboard();
                dashboard.Show();
                return true;
            }
            else
            {
                MessageBox.Show("Gebruikersnaam of wachtwoord onjuist");
                return false;
            }
        }

        public void Logout()
        {
            int? Id = null;
        }

        public void GetId(string username, string password)
        {
            var Database = new Database();
            Id = Database.GetId(username, password);
        }

        public void getName(string name)
        {
            Name = name;
        }

        public void changeName(string name)
        {
            // this.Name = name;
        }

        public void changePassword(string password)
        {
            this.Password = password;
        }

        public void changeEmail(string email)
        {
            this.Email = email;
        }

    }
}
