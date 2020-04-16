using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string hrk = " kn";
                double a, b;
                a = double.Parse(TextInputEURtoHRK.Text);
                b = a * (7.76);
                LabelOutput1.Text = b.ToString() + hrk;
            }
            catch (Exception)
            {
            }
        }

        private void TextInputUSDtoHRK_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string usd = " kn";
                double a, b;
                a = double.Parse(TextInputUSDtoHRK.Text);
                b = a * (7.02);
                LabelOutput2.Text = b.ToString() + usd;
            }
            catch (Exception)
            {
            }
        }

        private void TextInputHRKtoEUR_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string eur = " eur";
                double a, b;
                a = double.Parse(TextInputHRKtoEUR.Text);
                b = a * (0.13);

                LabelOutput3.Text = b.ToString() + eur;
            }
            catch (Exception)
            {
            }
        }

        private void TextInputHRKtoUSD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string usd = "$ ";
                double a, b;
                a = double.Parse(TextInputHRKtoUSD.Text);
                b = a * (0.14);
                LabelOutput4.Text = usd + b.ToString();
            }
            catch (Exception)
            {
            }
        }

    } 
}
