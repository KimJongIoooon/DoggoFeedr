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
        private MySqlDataAdapter loginadap;
        private MySqlDataAdapter idSelect;

        public bool login(string username, string password)
        {

            loginadap = new MySqlDataAdapter(
                "SELECT COUNT(*) FROM Account WHERE Name ='" + username + "' AND Password ='" + password + "'", con);
            DataTable logindata = new DataTable();
            loginadap.Fill(logindata);
            if (logindata.Rows[0][0].ToString() == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
