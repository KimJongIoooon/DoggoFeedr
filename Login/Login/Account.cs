﻿using System;
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
        private MySqlConnection con = new MySqlConnection("server=192.168.8.14;uid=root;pwd=root;database=DoggoFeedr;");
        private MySqlDataAdapter login;
        private MySqlDataAdapter idSelect;
        
        public static int Id { get; private set; } 
        public static string Name { get; private set; }
        string Password;
        string Email;
        bool isLoggedIn;
        List<Dog> Dogs = new List<Dog>();
        //List<Feeder> feeders = new List<Feeder>();
        //List<Food> foods = new List<Food>();
        public Account()
        {

        }
        
        public bool Login(string username, string password)
        {
            var Database = new Database();
            if (Database.Login(username, password))
            {
                getAccountData(username, password);
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

        public void getAccountData(string username, string password)
        {
            
            var database = new Database();
            int id = database.GetId(username, password);
            DataTable data = database.getAccountInfo(id);
            Id = (int)data.Rows[0][0];
            Name = Convert.ToString(data.Rows[0][2]);

        }

        public void Logout()
        {
            int? Id = null;
        }
    }
}
