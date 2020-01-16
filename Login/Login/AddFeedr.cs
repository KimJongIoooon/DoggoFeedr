using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class AddFeedr : Form
    {
        private Account _account;

        public AddFeedr()
        {
            InitializeComponent();
        }

        private void btnDoorgaan_Click(object sender, EventArgs e)
        {
            var Database = new Database();
            Database.insertFeedrId(Account.Id, Convert.ToInt32(tbxFeederId.Text));
            this.Hide();
            var Dashboard = new Dashboard(_account);
            Dashboard.Show();
        }
    }
}
