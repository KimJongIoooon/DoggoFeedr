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
    public partial class FoodSetings : Form
    {
        FeedrSettings feedrSettings;

        public FoodSetings(FeedrSettings feedrSettings)
        {
            this.feedrSettings = feedrSettings;
            this.Text = $"Voer instellingen Feedr{feedrSettings.currentFeedr.id}";
            InitializeComponent();
            foreach (FeedTime dateTime in feedrSettings.currentFeedr.mealtimes)
            {
                lbFeedTimes.Items.Add(dateTime.ToString());
            }
            dtpNewFeedTime.CustomFormat = "HH:mm";
            dtpNewFeedTime.Format = DateTimePickerFormat.Custom;
            btnDeleteTime.Enabled = false;
        }

        private void lbFeedTimes_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpNewFeedTime.Value = Convert.ToDateTime(lbFeedTimes.SelectedItem);
        }

        private void dtpNewFeedTime_ValueChanged(object sender, EventArgs e)
        {
            string Hour;
            string Minute;
            string strTime;
            Hour = dtpNewFeedTime.Value.Hour.ToString();
            Minute = dtpNewFeedTime.Value.Minute.ToString();
            strTime = $"{Hour}:{Minute}";
            FeedTime feedTime = new FeedTime(strTime);
            bool alreadyExists = feedrSettings.currentFeedr.mealtimes.Contains(feedTime);
            if (alreadyExists == true)
            {
                btnAddTime.Enabled = false;
                btnDeleteTime.Enabled = true;
            }

            else
            {
                btnAddTime.Enabled = true;
                btnDeleteTime.Enabled = false;
            }
        }

        private void btnAddTime_Click(object sender, EventArgs e)
        {
            string Hour;
            string Minute;
            string strTime;
            Hour = dtpNewFeedTime.Value.Hour.ToString();
            Minute = dtpNewFeedTime.Value.Minute.ToString();
            strTime = $"{Hour}:{Minute}";
            FeedTime feedTime = new FeedTime(strTime);

            bool alreadyExists = feedrSettings.currentFeedr.mealtimes.Contains(feedTime);
            if (alreadyExists == true)
            {
                btnAddTime.Enabled = false;
                btnDeleteTime.Enabled = true;
            }

            else
            {
                feedrSettings.currentFeedr.mealtimes.Add(feedTime);
                lbFeedTimes.Items.Clear();
                foreach (FeedTime dateTime in feedrSettings.currentFeedr.mealtimes)
                {
                    lbFeedTimes.Items.Add(dateTime);
                }
                feedrSettings.owner.Feedrs[feedrSettings.owner.Feedrs.FindIndex(x => x.id.Equals(feedrSettings.currentFeedr.id))] = feedrSettings.currentFeedr;
            }
        }


        private void btnDone_Click(object sender, EventArgs e)
        {
            feedrSettings.Select();
            this.Hide();
        }

        private void btnDeleteTime_Click(object sender, EventArgs e)
        {
            string Hour;
            string Minute;
            string strTime;
            Hour = dtpNewFeedTime.Value.Hour.ToString();
            Minute = dtpNewFeedTime.Value.Minute.ToString();
            strTime = $"{Hour}:{Minute}";
            FeedTime feedTime = new FeedTime(strTime);

            int index = feedrSettings.currentFeedr.mealtimes.IndexOf(feedTime);
            feedrSettings.currentFeedr.mealtimes.RemoveAt(index);
            lbFeedTimes.Items.Clear();
            lbFeedTimes.SelectedItem = null;
            foreach (FeedTime dateTime in feedrSettings.currentFeedr.mealtimes)
            {
                lbFeedTimes.Items.Add(dateTime);
            }
            feedrSettings.owner.Feedrs[feedrSettings.owner.Feedrs.FindIndex(x => x.id.Equals(feedrSettings.currentFeedr.id))] = feedrSettings.currentFeedr;
            btnAddTime.Enabled = true;
            btnDeleteTime.Enabled = false;
        }
    }
}
