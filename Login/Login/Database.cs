using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

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

    }
}
