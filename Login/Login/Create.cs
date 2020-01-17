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

        private void makeAccount_Click(object sender, EventArgs e)
        {
            if (userName.Text.Trim() == string.Empty || passWord.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vul een wachtwoord of gebruikersnaam in");
            }
            else
            {
                var Database = new Database();
                Database.AddAccount(userName.Text, passWord.Text);
            }

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
