using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Login
{
    public partial class Dashboard : Form
    {
        MySqlConnection mysqlCon = new MySqlConnection("server=192.168.8.14;uid=root;pwd=root;database=DoggoFeedr;");
        MySqlCommand cmd;
        MySqlDataAdapter adapt;
        Account _account;

        public Dashboard(Account account)
        {
            _account = account;
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            dogData();
            foodData();
            label11.Text = progressBar.Value.ToString() + " %";
            userName.Text = Account.Name;
        }

        public void showPercentage()
        {
            progressBar.Refresh();
            int percent = (int)(((double)progressBar.Value / (double)progressBar.Maximum) * 100);
            progressBar.CreateGraphics().DrawString(percent.ToString() + "%", new Font("Arial", (float)8.25, FontStyle.Regular), new SolidBrush(Color.Black), new PointF(progressBar.Width / 2 - 10, progressBar.Height / 2 - 7));
        }

        public void dogData()
        {
            try
            {
                dogName.Text = _account.Feedrs[0].dog.Name;
                bodyWeight.Text = Convert.ToString(_account.Feedrs[0].dog.Weight);
            }
            catch
            {

            }
        }

        public void foodData()
        {
            mysqlCon.Open();
            adapt = new MySqlDataAdapter();

            string sqlSelectAll = "SELECT * FROM Food";

            adapt.SelectCommand = new MySqlCommand(sqlSelectAll, mysqlCon);

            MySqlDataReader rdr = adapt.SelectCommand.ExecuteReader();

            while (rdr.Read())
            {
                foodType.Text = rdr.GetString(2);
            }

            mysqlCon.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToString();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= progressBar.Maximum; i++)
            {
                progressBar.Value = i;
                label11.Refresh();
                label11.Text = progressBar.Value.ToString() + " %";
            }
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            var Account = new Account();
            Account.Logout();
            this.Hide();
            var loginform = new LoginForm();
            loginform.Show();
        }

        private void dogSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dogsettings = new DogSettings(_account);
            dogsettings.Show();
        }
        
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void feedrSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            var feedrsettings = new FeedrSettings();
            feedrsettings.Show();
        }
    }
}
