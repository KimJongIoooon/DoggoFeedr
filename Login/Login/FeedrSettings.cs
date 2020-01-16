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
        Account owner;
        Feedr currentFeedr;
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
        }

        private void FeedrSettings_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public void GetData()
        {
            mysqlCon.Open();
            adapt = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT * FROM Feedr";

            adapt.SelectCommand = new MySqlCommand(sqlSelectAll, mysqlCon);

            DataTable table = new DataTable();
            adapt.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            dgvFeedrs.DataSource = bSource;

            mysqlCon.Close();

            // zorgt ervoor dat alle colommen en rijen automatisch aangepast worden zodat de tekst past
            dgvFeedrs.AutoResizeColumns();
            dgvFeedrs.AutoResizeRows();
            dgvFeedrs.AutoResizeColumnHeadersHeight();
            //dgvFeedrs.AutoResizeRowHeadersWidth();
        }

        private void cbFeedr_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentFeedr = owner.Feedrs.Find(x => x.id == Convert.ToInt32(cbFeedr.Text));
            if (currentFeedr.dog != null)
            {
                cbDog.SelectedItem = currentFeedr.dog.Name;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            currentFeedr.updateFeedr(Convert.ToInt32(cbFeedr.SelectedItem), owner.Dogs.Find(x => x.Name == cbDog.Text), cbPuzzle.SelectedIndex);
            owner.Feedrs[owner.Feedrs.FindIndex(x => x.id.Equals(Convert.ToInt32(cbFeedr.Text)))] = currentFeedr;
            database.UpdateAccountInfo(owner);
            GetData();
        }
    }
}
