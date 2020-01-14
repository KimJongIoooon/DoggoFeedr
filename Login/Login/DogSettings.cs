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

        public DogSettings()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getData();
            fillStageOfLife();
        }

        // get data
        public void getData()
        {
            mysqlCon.Open();
            adapt = new MySqlDataAdapter();

            string sqlSelectAll = "SELECT * FROM Dog";

            adapt.SelectCommand = new MySqlCommand(sqlSelectAll, mysqlCon);

            DataTable table = new DataTable();
            adapt.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            dataBase.DataSource = bSource;

            mysqlCon.Close();

            // zorgt ervoor dat alle colommen en rijen automatisch aangepast worden zodat de tekst past
            dataBase.AutoResizeColumns();
            dataBase.AutoResizeRows();
            dataBase.AutoResizeColumnHeadersHeight();
            //dataBase.AutoResizeRowHeadersWidth();
        }

        public void fillStageOfLife()
        {
            foreach (StageOfLife members in Enum.GetValues(typeof(StageOfLife)))
            {
                stageOfLife.Items.Add(members);
            }
        }

        public void fillFields()
        {
            Name = dogName.Text;
            Weight = Convert.ToInt32(bodyWeight.Text);
            Stage = stageOfLife.SelectedIndex;
            var Year = dateTimePicker.Value.Year;
            var Month = dateTimePicker.Value.Month;
            var Day = dateTimePicker.Value.Day;
            BirthDate = Convert.ToString(Year + "-" + Month + "-" + Day);
        }

        public void clearFields()
        {
            dogName.Text = "";
            bodyWeight.Text = "";
            stageOfLife.Text = "";
            dateTimePicker.Text = "";
        }
        
        private void addButton_Click(object sender, EventArgs e)
        {
            getData();
            var Dog = new Dog(Name, dateTimePicker.Value, Stage, Weight);
        }
    }
}
