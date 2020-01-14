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
        public AddFeedr()
        {
            InitializeComponent();
        }

        private void btnDoorgaan_Click(object sender, EventArgs e)
        {
            var Database = new Database();
            Database.insertFeedrId(1, Convert.ToInt32(tbxFeederId.Text));
        }
    }
}
