using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Login
{
    public partial class DogSettings : Form
    {
        MySqlConnection mysqlCon = new MySqlConnection("server=192.168.8.14;uid=root;pwd=root;database=DoggoFeedr;");
        MySqlCommand cmd;
        MySqlDataAdapter adapt;

        string Name;
        int Weight;
        int Stage;
        string BirthDate;
        private Account _account;
        private int selectedDog;

        public DogSettings(Account account)
        {
            _account = account;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // getData();
            getDogs();
            fillStageOfLife();
        }

        public void getDogs()
        {
            lbxDogs.Items.Clear();
            foreach (Dog dog in _account.Dogs)
            {
                lbxDogs.Items.Add(dog);
            }
            
        }


        public void fillStageOfLife()
        {
            foreach (StageOfLife members in Enum.GetValues(typeof(StageOfLife)))
            {
                drdStageOfLife.Items.Add(members);
            }
        }

        public void fillFields()
        {
            Name = tbxDogName.Text;
            Weight = Convert.ToInt32(tbxBodyWeight.Text);
            Stage = drdStageOfLife.SelectedIndex;
            var Year = dtpBirthDate.Value.Year;
            var Month = dtpBirthDate.Value.Month;
            var Day = dtpBirthDate.Value.Day;
            BirthDate = Convert.ToString(Year + "-" + Month + "-" + Day);
        }

        public void clearFields()
        {
            tbxDogName.Text = "";
            tbxBodyWeight.Text = "";
            drdStageOfLife.Text = "";
            dtpBirthDate.Text = "";
        }
        
        private void addButton_Click(object sender, EventArgs e)
        {
            var dog = new Dog(Name, Account.Id, dtpBirthDate.Value, Stage, Weight);

            if (selectedDog == -1)
            {
                var Database = new Database();
                _account.addDog(dog);
                Database.DogInsert(Account.Id, Name, Weight, Stage, BirthDate);
            }
            else
            {
                for (int i = 0; i < _account.Dogs.Count; i++)
                {
                    if (_account.Dogs[i].Id == selectedDog)
                    {
                        _account.Dogs[i] = dog;
                        MessageBox.Show("to do: fix update method in acc");
                    }    
                }
                
            }
            fillFields();
            // getData();
            getDogs();
            clearFields();
        }

        private void DogSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Dashboard = new Dashboard(_account);
            Dashboard.Show();
        }

        private void lbxDogs_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbxDogs.SelectedIndex;
            Dog dog = (Dog)lbxDogs.Items[index];
            tbxDogName.Text = dog.Name;
            tbxBodyWeight.Text = dog.Weight.ToString();
            drdStageOfLife.SelectedIndex = dog.stageOfLife;
            dtpBirthDate.Value = dog.dateOfBirth;
            selectedDog = dog.Id;
        }

        private void btnAddDog_Click(object sender, EventArgs e)
        {
            selectedDog = -1;
        }
    }
}
