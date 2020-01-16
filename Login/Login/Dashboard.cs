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
        Account _account;
        private TimeSpan timeToGo;
        private System.Threading.Timer timer;

        public Dashboard(Account account)
        {
            _account = account;
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            dogData();
            label11.Text = progressBar.Value.ToString() + " %";
            userName.Text = _account.Name;
            dogName.Text = _account.Feedrs[0].dog.Name;
        }

        private void SetUpTimer(TimeSpan alertTime)
        {
            DateTime current = DateTime.Now;
            timeToGo = alertTime - current.TimeOfDay;
            if (timeToGo < TimeSpan.Zero)
            {
                return;//time already passed
            }
            this.timer = new System.Threading.Timer(x =>
            {
                this.ShowMessageToUser();
            }, null, timeToGo, Timeout.InfiniteTimeSpan);
        }

        private void ShowMessageToUser()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(this.ShowMessageToUser));
            }
            else
            {
                MessageBox.Show("HET IS TIJD");
            }
        }

        private void setTimer()
        {
            TimeSpan time = new TimeSpan(21, 10, 00);
            SetUpTimer(time);
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
                tbxFeedr.Text = _account.Feedrs[0].id.ToString();
                tbxFood.Text = _account.Foods[0].name;
                Puzzles puzzles = (Puzzles)_account.Feedrs[0].puzzle;
                tbxPuzzle.Text = puzzles.ToString();
                progressBar.Value = _account.Feedrs[0].foodLevel;
                label11.Text = _account.Feedrs[0].foodLevel.ToString();
            }
            catch
            {

            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            setTimer();
            label7.Text = timeToGo.Hours + ":" + timeToGo.Minutes + ":" + timeToGo.Seconds.ToString();
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
            var feedrsettings = new FeedrSettings(_account);
            feedrsettings.Show();
        }
    }
}
