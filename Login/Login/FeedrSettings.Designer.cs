﻿namespace Login
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
            this.lblFeedr = new System.Windows.Forms.Label();
            this.lblDog = new System.Windows.Forms.Label();
            this.cbDog = new System.Windows.Forms.ComboBox();
            this.cbFeedr = new System.Windows.Forms.ComboBox();
            this.lblpuzzle = new System.Windows.Forms.Label();
            this.cbPuzzle = new System.Windows.Forms.ComboBox();
            this.btnFoodSettings = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
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
            // lblFeedr
            // 
            this.lblFeedr.AutoSize = true;
            this.lblFeedr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblFeedr.Location = new System.Drawing.Point(539, 19);
            this.lblFeedr.Name = "lblFeedr";
            this.lblFeedr.Size = new System.Drawing.Size(115, 39);
            this.lblFeedr.TabIndex = 2;
            this.lblFeedr.Text = "Feedr:";
            // 
            // lblDog
            // 
            this.lblDog.AutoSize = true;
            this.lblDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblDog.Location = new System.Drawing.Point(539, 80);
            this.lblDog.Name = "lblDog";
            this.lblDog.Size = new System.Drawing.Size(117, 39);
            this.lblDog.TabIndex = 3;
            this.lblDog.Text = "Hond: ";
            // 
            // cbDog
            // 
            this.cbDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cbDog.FormattingEnabled = true;
            this.cbDog.Location = new System.Drawing.Point(774, 73);
            this.cbDog.Name = "cbDog";
            this.cbDog.Size = new System.Drawing.Size(246, 46);
            this.cbDog.TabIndex = 4;
            // 
            // cbFeedr
            // 
            this.cbFeedr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cbFeedr.FormattingEnabled = true;
            this.cbFeedr.Location = new System.Drawing.Point(774, 12);
            this.cbFeedr.Name = "cbFeedr";
            this.cbFeedr.Size = new System.Drawing.Size(246, 46);
            this.cbFeedr.TabIndex = 5;
            this.cbFeedr.SelectedIndexChanged += new System.EventHandler(this.cbFeedr_SelectedIndexChanged);
            // 
            // lblpuzzle
            // 
            this.lblpuzzle.AutoSize = true;
            this.lblpuzzle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblpuzzle.Location = new System.Drawing.Point(539, 142);
            this.lblpuzzle.Name = "lblpuzzle";
            this.lblpuzzle.Size = new System.Drawing.Size(129, 39);
            this.lblpuzzle.TabIndex = 6;
            this.lblpuzzle.Text = "Puzzel:";
            // 
            // cbPuzzle
            // 
            this.cbPuzzle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cbPuzzle.FormattingEnabled = true;
            this.cbPuzzle.Location = new System.Drawing.Point(774, 135);
            this.cbPuzzle.Name = "cbPuzzle";
            this.cbPuzzle.Size = new System.Drawing.Size(246, 46);
            this.cbPuzzle.TabIndex = 8;
            // 
            // btnFoodSettings
            // 
            this.btnFoodSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnFoodSettings.Location = new System.Drawing.Point(774, 202);
            this.btnFoodSettings.Name = "btnFoodSettings";
            this.btnFoodSettings.Size = new System.Drawing.Size(205, 97);
            this.btnFoodSettings.TabIndex = 9;
            this.btnFoodSettings.Text = "voer instellingen";
            this.btnFoodSettings.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnSave.Location = new System.Drawing.Point(546, 202);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(190, 97);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Opslaan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FeedrSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 474);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFoodSettings);
            this.Controls.Add(this.cbPuzzle);
            this.Controls.Add(this.lblpuzzle);
            this.Controls.Add(this.cbFeedr);
            this.Controls.Add(this.cbDog);
            this.Controls.Add(this.lblDog);
            this.Controls.Add(this.lblFeedr);
            this.Controls.Add(this.dgvFeedrs);
            this.Name = "FeedrSettings";
            this.Text = "Feedr Instellingen";
            this.Load += new System.EventHandler(this.FeedrSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedrs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFeedrs;
        private System.Windows.Forms.Label lblFeedr;
        private System.Windows.Forms.Label lblDog;
        private System.Windows.Forms.ComboBox cbDog;
        private System.Windows.Forms.ComboBox cbFeedr;
        private System.Windows.Forms.Label lblpuzzle;
        private System.Windows.Forms.ComboBox cbPuzzle;
        private System.Windows.Forms.Button btnFoodSettings;
        private System.Windows.Forms.Button btnSave;
    }
}