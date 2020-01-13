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
            if (Database.login(username, password))
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

        public void getId(string username, string password)
        {
            idSelect = new MySqlDataAdapter("SELECT Id FROM Account WHERE Name ='" + username + "' AND Password ='" + password + "'", con);
            DataTable iddata = new DataTable();

            try
            {
                idSelect.Fill(iddata);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (iddata.Rows.Count == 0)
            {
                MessageBox.Show("Geen ID meegegeven");
            }
            else
            {
                Id = Convert.ToInt32(iddata.Rows[0][0]);
            }
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
