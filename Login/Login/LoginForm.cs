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
        private Account _account;

        public static int accountId;

        public LoginForm()
        {
            InitializeComponent();
            tbxPassword.PasswordChar = '*';
        }
        
        private void loginButton_Click(object sender, EventArgs e)
        {
            Database db = new Database();

            if (db.Login(tbxUsername.Text, tbxPassword.Text))
            {
                int accId = db.GetId(tbxUsername.Text, tbxPassword.Text);
                Account account = db.GetAcountInfo(accId);
                if (account.Feedrs.Count > 0)
                {
                    Dashboard dashboard = new Dashboard(account);
                    dashboard.Show();
                } else
                {
                    this.Hide();
                    var add = new AddFeedr();
                    add.Show();
                    MessageBox.Show("Error: voeg een feeder toe");
                }
                this.Hide();
            }
        }



            private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Create create = new Create();
            create.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
