namespace Login
{
    partial class FoodSetings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbFeedTimes = new System.Windows.Forms.ListBox();
            this.dtpNewFeedTime = new System.Windows.Forms.DateTimePicker();
            this.lblNextTime = new System.Windows.Forms.Label();
            this.btnAddTime = new System.Windows.Forms.Button();
            this.btnDeleteTime = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbFeedTimes
            // 
            this.lbFeedTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbFeedTimes.FormattingEnabled = true;
            this.lbFeedTimes.ItemHeight = 38;
            this.lbFeedTimes.Location = new System.Drawing.Point(12, 12);
            this.lbFeedTimes.Name = "lbFeedTimes";
            this.lbFeedTimes.Size = new System.Drawing.Size(202, 460);
            this.lbFeedTimes.TabIndex = 0;
            this.lbFeedTimes.SelectedIndexChanged += new System.EventHandler(this.lbFeedTimes_SelectedIndexChanged);
            // 
            // dtpNewFeedTime
            // 
            this.dtpNewFeedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.dtpNewFeedTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpNewFeedTime.Location = new System.Drawing.Point(318, 13);
            this.dtpNewFeedTime.Name = "dtpNewFeedTime";
            this.dtpNewFeedTime.ShowUpDown = true;
            this.dtpNewFeedTime.Size = new System.Drawing.Size(200, 45);
            this.dtpNewFeedTime.TabIndex = 1;
            this.dtpNewFeedTime.Value = new System.DateTime(2020, 1, 16, 19, 22, 42, 0);
            this.dtpNewFeedTime.ValueChanged += new System.EventHandler(this.dtpNewFeedTime_ValueChanged);
            // 
            // lblNextTime
            // 
            this.lblNextTime.AutoSize = true;
            this.lblNextTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblNextTime.Location = new System.Drawing.Point(221, 13);
            this.lblNextTime.Name = "lblNextTime";
            this.lblNextTime.Size = new System.Drawing.Size(91, 39);
            this.lblNextTime.TabIndex = 2;
            this.lblNextTime.Text = "Tijd: ";
            // 
            // btnAddTime
            // 
            this.btnAddTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnAddTime.Location = new System.Drawing.Point(228, 70);
            this.btnAddTime.Name = "btnAddTime";
            this.btnAddTime.Size = new System.Drawing.Size(290, 131);
            this.btnAddTime.TabIndex = 3;
            this.btnAddTime.Text = "Tijd toevoegen";
            this.btnAddTime.UseVisualStyleBackColor = true;
            this.btnAddTime.Click += new System.EventHandler(this.btnAddTime_Click);
            // 
            // btnDeleteTime
            // 
            this.btnDeleteTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnDeleteTime.Location = new System.Drawing.Point(228, 207);
            this.btnDeleteTime.Name = "btnDeleteTime";
            this.btnDeleteTime.Size = new System.Drawing.Size(290, 134);
            this.btnDeleteTime.TabIndex = 4;
            this.btnDeleteTime.Text = "Tijd verwijderen";
            this.btnDeleteTime.UseVisualStyleBackColor = true;
            this.btnDeleteTime.Click += new System.EventHandler(this.btnDeleteTime_Click);
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnDone.Location = new System.Drawing.Point(228, 347);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(290, 134);
            this.btnDone.TabIndex = 5;
            this.btnDone.Text = "Klaar";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // FoodSetings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 489);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnDeleteTime);
            this.Controls.Add(this.btnAddTime);
            this.Controls.Add(this.lblNextTime);
            this.Controls.Add(this.dtpNewFeedTime);
            this.Controls.Add(this.lbFeedTimes);
            this.Name = "FoodSetings";
            this.Text = "Voer Instellingen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbFeedTimes;
        private System.Windows.Forms.DateTimePicker dtpNewFeedTime;
        private System.Windows.Forms.Label lblNextTime;
        private System.Windows.Forms.Button btnAddTime;
        private System.Windows.Forms.Button btnDeleteTime;
        private System.Windows.Forms.Button btnDone;
    }
}