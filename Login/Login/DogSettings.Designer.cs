namespace Login
{

    partial class DogSettings
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
            this.tbxDogName = new System.Windows.Forms.TextBox();
            this.tbxBodyWeight = new System.Windows.Forms.TextBox();
            this.dataBase = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.drdStageOfLife = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataBase)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxDogName
            // 
            this.tbxDogName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDogName.Location = new System.Drawing.Point(575, 59);
            this.tbxDogName.Name = "tbxDogName";
            this.tbxDogName.Size = new System.Drawing.Size(188, 38);
            this.tbxDogName.TabIndex = 0;
            // 
            // tbxBodyWeight
            // 
            this.tbxBodyWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBodyWeight.Location = new System.Drawing.Point(798, 59);
            this.tbxBodyWeight.Name = "tbxBodyWeight";
            this.tbxBodyWeight.Size = new System.Drawing.Size(188, 38);
            this.tbxBodyWeight.TabIndex = 1;
            // 
            // dataBase
            // 
            this.dataBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBase.Location = new System.Drawing.Point(12, 13);
            this.dataBase.Name = "dataBase";
            this.dataBase.Size = new System.Drawing.Size(532, 449);
            this.dataBase.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(569, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hondennaam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(792, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lichaamsgewicht";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(571, 420);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(188, 42);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Voeg toe";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.addButton_Click);
            // 
            // drdStageOfLife
            // 
            this.drdStageOfLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drdStageOfLife.FormattingEnabled = true;
            this.drdStageOfLife.Location = new System.Drawing.Point(575, 185);
            this.drdStageOfLife.Name = "drdStageOfLife";
            this.drdStageOfLife.Size = new System.Drawing.Size(188, 39);
            this.drdStageOfLife.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(569, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Levensfase";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(569, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Geboortedatum";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthDate.Location = new System.Drawing.Point(571, 325);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(415, 38);
            this.dtpBirthDate.TabIndex = 11;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(798, 420);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(188, 42);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DogSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 607);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.drdStageOfLife);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataBase);
            this.Controls.Add(this.tbxBodyWeight);
            this.Controls.Add(this.tbxDogName);
            this.Name = "DogSettings";
            this.Text = " HondenInstellingen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DogSettings_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxDogName;
        private System.Windows.Forms.TextBox tbxBodyWeight;
        private System.Windows.Forms.DataGridView dataBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox drdStageOfLife;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Button btnBack;
    }
}

