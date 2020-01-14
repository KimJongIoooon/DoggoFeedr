namespace Login
{
    partial class FeedrSettings
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
            this.dgvFeedrs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedrs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFeedrs
            // 
            this.dgvFeedrs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeedrs.Location = new System.Drawing.Point(13, 13);
            this.dgvFeedrs.Name = "dgvFeedrs";
            this.dgvFeedrs.RowHeadersWidth = 51;
            this.dgvFeedrs.RowTemplate.Height = 24;
            this.dgvFeedrs.Size = new System.Drawing.Size(499, 425);
            this.dgvFeedrs.TabIndex = 0;
            // 
            // FeedrSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvFeedrs);
            this.Name = "FeedrSettings";
            this.Text = "Feedr Instellingen";
            this.Load += new System.EventHandler(this.FeedrSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedrs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFeedrs;
    }
}