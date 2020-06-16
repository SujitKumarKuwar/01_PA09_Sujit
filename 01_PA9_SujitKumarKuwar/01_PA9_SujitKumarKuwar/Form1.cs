using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_PA9_SujitKumarKuwar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            double AmountEntered;
            double convertedvalue;
            try
            {
                if ((rdb_USdollars.Checked == false) || (rdb_JapaneseYen.Checked = false))
                {
                    txt_convertedAmt.Text = "Select at least one type of currency to convert";
                }

                if (rdb_USdollars.Checked == true)
                {
                    AmountEntered = double.Parse(txt_amount.Text);
                    convertedvalue = AmountEntered * 0.74;

                    txt_convertedAmt.Text = convertedvalue.ToString();


                }

                if (rdb_JapaneseYen.Checked == true)
                {
                    AmountEntered = double.Parse(txt_amount.Text);
                    convertedvalue = AmountEntered * 81.97;

                    txt_convertedAmt.Text = convertedvalue.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid value.");
                txt_amount.Text = "";
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_amount.Clear();
            txt_convertedAmt.Clear();
        }
    }
}
