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

        public FeedrSettings()
        {
            InitializeComponent();
        }

        private void FeedrSettings_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public void GetData()
        {
            mysqlCon.Open();
            adapt = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT * FROM Feeder";

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
    }
}
