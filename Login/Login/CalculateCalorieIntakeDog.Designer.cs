namespace Login
{
    partial class CalculateCalorieIntakeDog
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
            this.tbxBodyWeight = new System.Windows.Forms.TextBox();
            this.drdStageOfLife = new System.Windows.Forms.ComboBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // tbxBodyWeight
            // 
            this.tbxBodyWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBodyWeight.Location = new System.Drawing.Point(151, 216);
            this.tbxBodyWeight.Name = "tbxBodyWeight";
            this.tbxBodyWeight.Size = new System.Drawing.Size(188, 38);
            this.tbxBodyWeight.TabIndex = 2;
            // 
            // drdStageOfLife
            // 
            this.drdStageOfLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drdStageOfLife.FormattingEnabled = true;
            this.drdStageOfLife.Location = new System.Drawing.Point(151, 260);
            this.drdStageOfLife.Name = "drdStageOfLife";
            this.drdStageOfLife.Size = new System.Drawing.Size(188, 39);
            this.drdStageOfLife.TabIndex = 9;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthDate.Location = new System.Drawing.Point(151, 172);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(415, 38);
            this.dtpBirthDate.TabIndex = 12;
            // 
            // CalculateCalorieIntakeDog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.drdStageOfLife);
            this.Controls.Add(this.tbxBodyWeight);
            this.Name = "CalculateCalorieIntakeDog";
            this.Text = "CalculateCalorieIntakeDog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxBodyWeight;
        private System.Windows.Forms.ComboBox drdStageOfLife;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
    }
}