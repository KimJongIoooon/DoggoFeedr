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
    public class Account
    {
        
        public static int Id { get; private set; } 
        public static string Name { get; private set; }
        string Password;
        string Email;
        bool isLoggedIn;
        public List<Dog> Dogs = new List<Dog>();
        public List<Feedr> Feedrs = new List<Feedr>();
        public List<Food> Foods = new List<Food>();
        public Account()
        {
            
        }

        public Account(string name, string password, string email)
        {

        }

        public void addDog(Dog dog)
        {
            Dogs.Add(dog);
        }

        public void addFeedr(Feedr feedr)
        {
            Feedrs.Add(feedr);
        }
        
        public void addFood(Food food)
        {
            Foods.Add(food);
        }
        public bool Login(string username, string password)
        {
            var Database = new Database();
            if (Database.Login(username, password))
            {
                var loginform = new LoginForm();
                loginform.Hide();
                var dashboard = new Dashboard(this);
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
    }
}
