using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Login
{
    public partial class Create : Form
    {
        MySqlConnection con = new MySqlConnection("server=192.168.8.14;uid=colin;pwd=root;database=DoggoFeedr;");
        MySqlCommand insertCommand;
        MySqlDataReader insertReader;

        public Create()
        {
            InitializeComponent();
            passWord.PasswordChar = '*';
        }

        public bool usernameCheck()
        {
            MySqlCommand check = new MySqlCommand("SELECT COUNT(*) FROM Account WHERE Name = @username", con);
            check.Parameters.AddWithValue("@username", this.userName.Text);
            con.Open();
            int TotalRows = 0;
            TotalRows = Convert.ToInt32(check.ExecuteScalar());
            con.Close();
            if (TotalRows > 0)
            {
                MessageBox.Show("Gebruikersnaam " + userName.Text + " al in gebruik");
                return true;
            }
            else 
            {
                return false;
            }
        }

        private void addAccount()
        {
            try
            {
                if (!usernameCheck()) 
                {
                    con.Open();
                    insertCommand = new MySqlCommand("INSERT INTO Account (Name, Password)" + "VALUES (@name, @pwd)", con);

                    insertCommand.Parameters.AddWithValue("@name", userName.Text);
                    insertCommand.Parameters.AddWithValue("@pwd", passWord.Text);

                    insertCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Gebruiker succesvol aangemaakt!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void makeAccount_Click(object sender, EventArgs e)
        {
            addAccount();
        }

        private void Create_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }
    }
}
