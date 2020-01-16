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
            this.lblFeedr = new System.Windows.Forms.Label();
            this.lblDog = new System.Windows.Forms.Label();
            this.cbDog = new System.Windows.Forms.ComboBox();
            this.cbFeedr = new System.Windows.Forms.ComboBox();
            this.lblpuzzle = new System.Windows.Forms.Label();
            this.cbPuzzle = new System.Windows.Forms.ComboBox();
            this.btnFoodSettings = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFeedr
            // 
            this.lblFeedr.AutoSize = true;
            this.lblFeedr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblFeedr.Location = new System.Drawing.Point(11, 17);
            this.lblFeedr.Name = "lblFeedr";
            this.lblFeedr.Size = new System.Drawing.Size(115, 39);
            this.lblFeedr.TabIndex = 2;
            this.lblFeedr.Text = "Feedr:";
            // 
            // lblDog
            // 
            this.lblDog.AutoSize = true;
            this.lblDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblDog.Location = new System.Drawing.Point(11, 79);
            this.lblDog.Name = "lblDog";
            this.lblDog.Size = new System.Drawing.Size(117, 39);
            this.lblDog.TabIndex = 3;
            this.lblDog.Text = "Hond: ";
            // 
            // cbDog
            // 
            this.cbDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cbDog.FormattingEnabled = true;
            this.cbDog.Location = new System.Drawing.Point(245, 72);
            this.cbDog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDog.Name = "cbDog";
            this.cbDog.Size = new System.Drawing.Size(247, 46);
            this.cbDog.TabIndex = 4;
            // 
            // cbFeedr
            // 
            this.cbFeedr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cbFeedr.FormattingEnabled = true;
            this.cbFeedr.Location = new System.Drawing.Point(245, 11);
            this.cbFeedr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFeedr.Name = "cbFeedr";
            this.cbFeedr.Size = new System.Drawing.Size(247, 46);
            this.cbFeedr.TabIndex = 5;
            this.cbFeedr.SelectedIndexChanged += new System.EventHandler(this.cbFeedr_SelectedIndexChanged);
            // 
            // lblpuzzle
            // 
            this.lblpuzzle.AutoSize = true;
            this.lblpuzzle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblpuzzle.Location = new System.Drawing.Point(11, 141);
            this.lblpuzzle.Name = "lblpuzzle";
            this.lblpuzzle.Size = new System.Drawing.Size(129, 39);
            this.lblpuzzle.TabIndex = 6;
            this.lblpuzzle.Text = "Puzzel:";
            // 
            // cbPuzzle
            // 
            this.cbPuzzle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cbPuzzle.FormattingEnabled = true;
            this.cbPuzzle.Location = new System.Drawing.Point(245, 134);
            this.cbPuzzle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPuzzle.Name = "cbPuzzle";
            this.cbPuzzle.Size = new System.Drawing.Size(247, 46);
            this.cbPuzzle.TabIndex = 8;
            // 
            // btnFoodSettings
            // 
            this.btnFoodSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnFoodSettings.Location = new System.Drawing.Point(245, 201);
            this.btnFoodSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFoodSettings.Name = "btnFoodSettings";
            this.btnFoodSettings.Size = new System.Drawing.Size(248, 97);
            this.btnFoodSettings.TabIndex = 9;
            this.btnFoodSettings.Text = "Voer Instellingen";
            this.btnFoodSettings.UseVisualStyleBackColor = true;
            this.btnFoodSettings.Click += new System.EventHandler(this.btnFoodSettings_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnSave.Location = new System.Drawing.Point(19, 201);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(189, 97);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Opslaan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FeedrSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 474);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFoodSettings);
            this.Controls.Add(this.cbPuzzle);
            this.Controls.Add(this.lblpuzzle);
            this.Controls.Add(this.cbFeedr);
            this.Controls.Add(this.cbDog);
            this.Controls.Add(this.lblDog);
            this.Controls.Add(this.lblFeedr);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FeedrSettings";
            this.Text = "Feedr Instellingen";
            this.Load += new System.EventHandler(this.FeedrSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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