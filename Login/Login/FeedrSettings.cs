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
    public partial class FeedrSettings : Form
    {
        MySqlConnection mysqlCon = new MySqlConnection("server=192.168.8.14;uid=root;pwd=root;database=DoggoFeedr;");
        MySqlCommand cmd;
        MySqlDataAdapter adapt;
        public Account owner;
        public Feedr currentFeedr;
        Database database = new Database();


        public FeedrSettings(Account account)
        {
            InitializeComponent();
            owner = account;
            foreach(Feedr feedr in owner.Feedrs)
            {
                cbFeedr.Items.Add(feedr.id);
            }

            foreach(Dog dog in owner.Dogs)
            {
                cbDog.Items.Add(dog.Name);
            }

            foreach(Puzzles puzzles in Enum.GetValues(typeof(Puzzles)))
            {
                cbPuzzle.Items.Add(puzzles);
            }
            cbPuzzle.SelectedItem = Puzzles.Geen;
            btnFoodSettings.Enabled = false;
        }

        private void FeedrSettings_Load(object sender, EventArgs e)
        {
        }


        private void cbFeedr_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentFeedr = owner.Feedrs.Find(x => x.id == Convert.ToInt32(cbFeedr.Text));
            if (currentFeedr.dog != null)
            {
                cbDog.SelectedItem = currentFeedr.dog.Name;               
            }

            if (cbDog.Text != null)
            {
                btnFoodSettings.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            currentFeedr.updateFeedr(Convert.ToInt32(cbFeedr.SelectedItem), owner.Dogs.Find(x => x.Name == cbDog.Text), cbPuzzle.SelectedIndex);
            owner.Feedrs[owner.Feedrs.FindIndex(x => x.id.Equals(Convert.ToInt32(cbFeedr.Text)))] = currentFeedr;
            database.UpdateAccountInfo(owner);
        }

        private void btnFoodSettings_Click(object sender, EventArgs e)
        {
            FoodSetings food = new FoodSetings(this);
            food.Show();
        }
    }
}
