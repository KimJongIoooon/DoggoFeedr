using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using GUIDoggoFeedr;
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
        
        public void Login(string username, string password)
        {
            login = new MySqlDataAdapter("SELECT COUNT(*) FROM Account WHERE Name ='" + username + "' AND Password ='" + password + "'", con);
            DataTable logindata = new DataTable();

            try
            {
                login.Fill(logindata);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (logindata.Rows[0][0].ToString() == "1")
            {
                var dashboard = new Dashboard();
                dashboard.Show();
                LoginForm loginform = new LoginForm();
                loginform.Close();
            }
            else
            {
                MessageBox.Show("Gebruikersnaam of wachtwoord onjuist");
            }
        }

        public void Logout()
        {

        }

        public int getId(string username, string password)
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

            return Id;
        }

        string getName()
        {


            return Name;
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
