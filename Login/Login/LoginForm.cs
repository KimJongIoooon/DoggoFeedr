﻿using System;
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
    public partial class LoginForm : Form
    {
        MySqlConnection con = new MySqlConnection("server=192.168.8.14;uid=colin;pwd=root;database=DoggoFeedr;");
        MySqlDataAdapter adap;
        MySqlDataAdapter idSelect;

        public static int accountId;

        public LoginForm()
        {
            InitializeComponent();
            passWord.PasswordChar = '*';
        }
        
        private void loginButton_Click(object sender, EventArgs e)
        {
            var Account = new Account();
            if (Account.Login(userName.Text, passWord.Text))
            {
                this.Hide();
                Account.getId(userName.Text, passWord.Text);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Create create = new Create();
            create.Show();
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
