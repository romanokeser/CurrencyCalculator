namespace CurrencyCalculator
{
    partial class Form1
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
            this.TextInputEURtoHRK = new System.Windows.Forms.TextBox();
            this.TextInputUSDtoHRK = new System.Windows.Forms.TextBox();
            this.LabelOutput1 = new System.Windows.Forms.Label();
            this.LabelOutput2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextInputHRKtoUSD = new System.Windows.Forms.TextBox();
            this.TextInputHRKtoEUR = new System.Windows.Forms.TextBox();
            this.LabelOutput4 = new System.Windows.Forms.Label();
            this.LabelOutput3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Currency Calculator";
            // 
            // TextInputEURtoHRK
            // 
            this.TextInputEURtoHRK.Location = new System.Drawing.Point(16, 75);
            this.TextInputEURtoHRK.Name = "TextInputEURtoHRK";
            this.TextInputEURtoHRK.Size = new System.Drawing.Size(73, 20);
            this.TextInputEURtoHRK.TabIndex = 3;
            this.TextInputEURtoHRK.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TextInputUSDtoHRK
            // 
            this.TextInputUSDtoHRK.Location = new System.Drawing.Point(16, 125);
            this.TextInputUSDtoHRK.Name = "TextInputUSDtoHRK";
            this.TextInputUSDtoHRK.Size = new System.Drawing.Size(73, 20);
            this.TextInputUSDtoHRK.TabIndex = 4;
            this.TextInputUSDtoHRK.TextChanged += new System.EventHandler(this.TextInputUSDtoHRK_TextChanged);
            // 
            // LabelOutput1
            // 
            this.LabelOutput1.AutoSize = true;
            this.LabelOutput1.Location = new System.Drawing.Point(166, 78);
            this.LabelOutput1.Name = "LabelOutput1";
            this.LabelOutput1.Size = new System.Drawing.Size(0, 13);
            this.LabelOutput1.TabIndex = 5;
            // 
            // LabelOutput2
            // 
            this.LabelOutput2.AutoSize = true;
            this.LabelOutput2.Location = new System.Drawing.Point(166, 128);
            this.LabelOutput2.Name = "LabelOutput2";
            this.LabelOutput2.Size = new System.Drawing.Size(0, 13);
            this.LabelOutput2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "EUR to HRK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "USD to HRK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "HRK to USD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "HRK to EUR";
            // 
            // TextInputHRKtoUSD
            // 
            this.TextInputHRKtoUSD.Location = new System.Drawing.Point(16, 246);
            this.TextInputHRKtoUSD.Name = "TextInputHRKtoUSD";
            this.TextInputHRKtoUSD.Size = new System.Drawing.Size(73, 20);
            this.TextInputHRKtoUSD.TabIndex = 10;
            this.TextInputHRKtoUSD.TextChanged += new System.EventHandler(this.TextInputHRKtoUSD_TextChanged);
            // 
            // TextInputHRKtoEUR
            // 
            this.TextInputHRKtoEUR.Location = new System.Drawing.Point(16, 196);
            this.TextInputHRKtoEUR.Name = "TextInputHRKtoEUR";
            this.TextInputHRKtoEUR.Size = new System.Drawing.Size(73, 20);
            this.TextInputHRKtoEUR.TabIndex = 9;
            this.TextInputHRKtoEUR.TextChanged += new System.EventHandler(this.TextInputHRKtoEUR_TextChanged);
            // 
            // LabelOutput4
            // 
            this.LabelOutput4.AutoSize = true;
            this.LabelOutput4.Location = new System.Drawing.Point(166, 249);
            this.LabelOutput4.Name = "LabelOutput4";
            this.LabelOutput4.Size = new System.Drawing.Size(0, 13);
            this.LabelOutput4.TabIndex = 14;
            // 
            // LabelOutput3
            // 
            this.LabelOutput3.AutoSize = true;
            this.LabelOutput3.Location = new System.Drawing.Point(166, 199);
            this.LabelOutput3.Name = "LabelOutput3";
            this.LabelOutput3.Size = new System.Drawing.Size(0, 13);
            this.LabelOutput3.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 302);
            this.Controls.Add(this.LabelOutput4);
            this.Controls.Add(this.LabelOutput3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextInputHRKtoUSD);
            this.Controls.Add(this.TextInputHRKtoEUR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelOutput2);
            this.Controls.Add(this.LabelOutput1);
            this.Controls.Add(this.TextInputUSDtoHRK);
            this.Controls.Add(this.TextInputEURtoHRK);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CurrencyCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextInputEURtoHRK;
        private System.Windows.Forms.TextBox TextInputUSDtoHRK;
        private System.Windows.Forms.Label LabelOutput1;
        private System.Windows.Forms.Label LabelOutput2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextInputHRKtoUSD;
        private System.Windows.Forms.TextBox TextInputHRKtoEUR;
        private System.Windows.Forms.Label LabelOutput4;
        private System.Windows.Forms.Label LabelOutput3;
    }
}

