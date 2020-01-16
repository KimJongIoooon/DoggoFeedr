namespace Login
{
    partial class CalculateFoodDog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxAdult = new System.Windows.Forms.CheckBox();
            this.cbxGrowing = new System.Windows.Forms.CheckBox();
            this.cbxLactating = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cbxPregnant = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Energie behoefte volwassen hond";
            // 
            // cbxAdult
            // 
            this.cbxAdult.AutoSize = true;
            this.cbxAdult.Location = new System.Drawing.Point(15, 96);
            this.cbxAdult.Name = "cbxAdult";
            this.cbxAdult.Size = new System.Drawing.Size(77, 17);
            this.cbxAdult.TabIndex = 2;
            this.cbxAdult.Text = "Volwassen";
            this.cbxAdult.UseVisualStyleBackColor = true;
            // 
            // cbxGrowing
            // 
            this.cbxGrowing.AutoSize = true;
            this.cbxGrowing.Location = new System.Drawing.Point(18, 47);
            this.cbxGrowing.Name = "cbxGrowing";
            this.cbxGrowing.Size = new System.Drawing.Size(69, 17);
            this.cbxGrowing.TabIndex = 3;
            this.cbxGrowing.Text = "Groeiend";
            this.cbxGrowing.UseVisualStyleBackColor = true;
            // 
            // cbxLactating
            // 
            this.cbxLactating.AutoSize = true;
            this.cbxLactating.Location = new System.Drawing.Point(12, 206);
            this.cbxLactating.Name = "cbxLactating";
            this.cbxLactating.Size = new System.Drawing.Size(74, 17);
            this.cbxLactating.TabIndex = 4;
            this.cbxLactating.Text = "Lacterend";
            this.cbxLactating.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 276);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(773, 171);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // cbxPregnant
            // 
            this.cbxPregnant.AutoSize = true;
            this.cbxPregnant.Location = new System.Drawing.Point(15, 142);
            this.cbxPregnant.Name = "cbxPregnant";
            this.cbxPregnant.Size = new System.Drawing.Size(66, 17);
            this.cbxPregnant.TabIndex = 8;
            this.cbxPregnant.Text = "Drachtig";
            this.cbxPregnant.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 165);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(15, 229);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 10;
            // 
            // btnCalculate
            // 
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCalculate.Location = new System.Drawing.Point(694, 202);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(94, 68);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Bereken!";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // CalculateFoodDog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cbxPregnant);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cbxAdult);
            this.Controls.Add(this.cbxGrowing);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbxLactating);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CalculateFoodDog";
            this.Text = "CalculateFoodDog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbxAdult;
        private System.Windows.Forms.CheckBox cbxGrowing;
        private System.Windows.Forms.CheckBox cbxLactating;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox cbxPregnant;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnCalculate;
    }
}