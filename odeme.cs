using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otobüs_bileti_rezervasyonu
{
    public partial class odeme : Form
    {
        public odeme()
        {
            InitializeComponent();
        }

        private void odeme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool control = false;

            if (textBox_cardnumber.Text.Length == 16 && textBox_cvc.Text.Length == 3)
            {
                for (int i = 0; i <= 15; i++)
                {
                    bool is_digit_card = char.IsNumber(textBox_cardnumber.Text[i]);
                    if (is_digit_card == true)
                    {

                    }
                    else
                    {
                        control = true;
                        
                    }
                }
                if (control == true)
                {
                    MessageBox.Show("Please enter your card information consisting of 16 digits.", "INFORMATION",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Your payment has been successfully made.","INFORMATION",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter a digit only card or security code.", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
