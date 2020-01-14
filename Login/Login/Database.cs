﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Login
{
    class Database
    {
        private MySqlConnection con = new MySqlConnection("server=192.168.8.14;uid=root;pwd=root;database=DoggoFeedr;");
        private MySqlDataAdapter loginAdapter;
        private MySqlDataAdapter idSelect;
        private MySqlCommand insertAdapter;

        public bool Login(string username, string password)
        {
            con.Open();
            loginAdapter = new MySqlDataAdapter(
                "SELECT COUNT(*) FROM Account WHERE Name ='" + username + "' AND Password ='" + password + "'", con);
            DataTable logindata = new DataTable();
            loginAdapter.Fill(logindata);
            con.Close();
            if (logindata.Rows[0][0].ToString() == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public int GetId(string username, string password)
        {
            con.Open();
            idSelect = new MySqlDataAdapter("SELECT Id FROM Account WHERE Name ='" + username + "' AND Password ='" + password + "'", con);
            DataTable iddata = new DataTable();
            idSelect.Fill(iddata);
            con.Close();
            if (iddata.Rows.Count == 0)
            {
                return -1;
            }
            else
            {
                return Convert.ToInt32(iddata.Rows[0][0]);
            }
        }

        public bool usernameCheck(string username)
        {
            MySqlCommand check = new MySqlCommand("SELECT COUNT(*) FROM Account WHERE Name = @username", con);
            check.Parameters.AddWithValue("@username", username);
            con.Open();
            int TotalRows = 0;
            TotalRows = Convert.ToInt32(check.ExecuteScalar());
            con.Close();
            if (TotalRows > 0)
            {
                MessageBox.Show("Gebruikersnaam " + username + " al in gebruik");
                return true;
            }
            else
            {
                return false;
            }
        }

        public void addAccount(string username, string password)
        {
            if (!usernameCheck(username))
            {
                con.Open();
                insertAdapter = new MySqlCommand("INSERT INTO Account (Name, Password)" + "VALUES (@name, @pwd)", con);

                insertAdapter.Parameters.AddWithValue("@name", username);
                insertAdapter.Parameters.AddWithValue("@pwd", password);

                insertAdapter.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Gebruiker succesvol aangemaakt!");
            }
        }

        public DataTable getAccountInfo(int id)
        {
            con.Open();
            MySqlDataAdapter selectAdapter = new MySqlDataAdapter($"SELECT * FROM Account WHERE ID = {id}", con);
            DataTable dataTable = new DataTable();
            selectAdapter.Fill(dataTable);
            con.Close();
            
            return dataTable;
            
        }
        public Account getAcountInfo(int id)
        {
            //get account table
            string Query = $"SELECT * FROM Account WHERE ID = {id}";
            MySqlCommand mySqlCommand = new MySqlCommand(Query, con);
            con.Open();
            MySqlDataReader myReader;
            myReader = mySqlCommand.ExecuteReader();
            myReader.Read();
            int Account_id = myReader.GetInt32("Id");
            int feedrId = myReader.GetInt32("FeedrId");
            string name = myReader.GetString("Name");
            string email = myReader.GetString("Email");
            string password = myReader.GetString("Password"); 
            Account account = new Account(name, password, email);
            myReader.Close();
            //get dogs info
            string DogQuery = $"SELECT * FROM Dog WHERE accountId = {id}";
            mySqlCommand = new MySqlCommand(DogQuery, con);
            
            myReader = mySqlCommand.ExecuteReader();

            while (myReader.Read())
            {
                string dogName = myReader.GetString("Name");
                int weight = myReader.GetInt32("Weight");
                int stageOfLife = myReader.GetInt32("StageOfLife");
                DateTime dateOfBirth = myReader.GetDateTime("DateOfBirth");


                account.addDog(new Dog(dogName, dateOfBirth, stageOfLife, weight));
                
            }
            myReader.Close();

            //get foods
            string foodQuery = $"SELECT * FROM Food Where accountId = {id}";
            mySqlCommand = new MySqlCommand(foodQuery, con);
            
            myReader = mySqlCommand.ExecuteReader();

            while (myReader.Read())
            {
                int foodid = myReader.GetInt32("Id");
                string foodName = myReader.GetString("Name");
                int energy = myReader.GetInt32("Energy");
                account.addFood(new Food(foodid, foodName, energy));
                
            }
            myReader.Close();
            //get feedrs 

            string feedrQuery = $"SELECT * FROM Feedr Where accountId = {id}";
            mySqlCommand = new MySqlCommand(feedrQuery, con);
            myReader = mySqlCommand.ExecuteReader();

            while(myReader.Read()){
                int dogId = myReader.GetInt32("DogId");
                int foodId = myReader.GetInt32("FoodId");
                int foodPerMeal = myReader.GetInt32("FoodPerMeal");
                int puzzle = myReader.GetInt32("Puzzle");
                int level = myReader.GetInt32("level");
                bool active = myReader.GetBoolean("active");
                
            }
            myReader.Close();
            con.Close();
            return account;
        }
        
        public List<Dog> accountDogs(int id)
        {
           List<Dog> dogs = new List<Dog>();
           return dogs;
        }

        public DataTable getDogData(int id)
        {
            con.Open();
            MySqlDataAdapter adapt = new MySqlDataAdapter($"SELECT * FROM Dog WHERE Account_Id = {id}", con);
            DataTable dataTable = new DataTable();
            adapt.Fill(dataTable);
            con.Close();

            return dataTable;
        }

        public DataTable getFoodData(int id)
        {
            con.Open();
            MySqlDataAdapter adapt = new MySqlDataAdapter($"SELECT * FROM Food WHERE Account_Id = {id}", con);
            DataTable dataTable = new DataTable();
            adapt.Fill(dataTable);
            con.Close();

            return dataTable;
        }
        
        public DataTable getFeedrData(int id)
        {
            con.Open();
            MySqlDataAdapter adapt = new MySqlDataAdapter($"SELECT * FROM Feedr WHERE Account_Id = {id}", con);
            DataTable dataTable = new DataTable();
            adapt.Fill(dataTable);
            con.Close();

            return dataTable;
        }

        public void dogInsert(string name, int weight, int stage, DateTime birthdate)
        {
            string sqlInsert = "INSERT INTO Dog (Name, Weight, StageOfLife, DateOfBirth)" +
                               "VALUES ('" + name + "' , '" + weight + "', '" + stage + "', '" + birthdate + "')";
            con.Open();
            MySqlCommand InsertCommand = new MySqlCommand(sqlInsert, con);
            MySqlDataReader Insert;
            Insert = InsertCommand.ExecuteReader();
            while (Insert.Read())
            {

            }
            con.Close();
        }

    }
}
