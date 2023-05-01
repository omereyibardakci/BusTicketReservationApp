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
    public partial class otobus : Form
    {
        public otobus()
        {
            InitializeComponent();
        }

        public void green_seat(Button s)
        {
            // The seat chosen by the customer will be green.
            // If he gives up, he will go back to his old self.
            if (s.BackColor == Color.Green)
            {
                s.BackColor = Color.Empty;
                for (int i = 0; i < groupBox_seats.Controls.Count; i++)
                {
                    groupBox_seats.Controls[i].Enabled = true;

                }
                s.Enabled = true;
            }
            else if (s.BackColor == Color.Red)
            {
                MessageBox.Show("You bought this seat", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for (int i = 0; i < groupBox_seats.Controls.Count; i++)
                {
                    groupBox_seats.Controls[i].Enabled = false;

                }
                s.Enabled = true;

                s.BackColor = Color.Green;

            }
            text(s);
        }


        public void text(Button b)
        {
            //dataGridView1.Rows.Add(b.Text);
            textBox_seatno.Text = b.Text;
        }


        private void otobus_Load(object sender, EventArgs e)
        {
            textBox_seatno.Visible = false;
            btn_pay.Visible = false;

            button3.BackColor = Color.Red;
            button7.BackColor = Color.Red;
            button11.BackColor = Color.Red;
            button16.BackColor = Color.Red;
            button17.BackColor = Color.Red;
            button21.BackColor = Color.Red;
            dataGridView1.Rows.Add(3, "ali", "çalışkan", "0538*****11", "145******68", "man");
            dataGridView1.Rows.Add(7, "zeynep", "sert", "0545*****47", "201******42", "woman");
            dataGridView1.Rows.Add(11, "kıvanç", "parlak", "0537*****44", "189******06", "man");
            dataGridView1.Rows.Add(16, "ihsan", "ateş", "0507*****09", "354******86", "man");
            dataGridView1.Rows.Add(17, "meltem", "ateş", "0537*****37", "171******20", "man");
            dataGridView1.Rows.Add(21, "furkan", "yılmaz", "0531*****17", "209******84", "man");


        }


        public void seat()
        {
            //If the customer chooses the selected seats, he will send notification with this method.
            MessageBox.Show("This Seat is FULL!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            seat();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            seat();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            seat();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            seat();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            seat();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            seat();
        }








        private void button1_Click(object sender, EventArgs e)
        {
            green_seat(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            green_seat(button2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            green_seat(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            green_seat(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            green_seat(button6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            green_seat(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            green_seat(button9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            green_seat(button10);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            green_seat(button12);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            green_seat(button13);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            green_seat(button14);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            green_seat(button15);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            green_seat(button18);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            green_seat(button19);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            green_seat(button20);
        }




        private void btn_add_Click(object sender, EventArgs e)
        {
            string koltuk_no = textBox_seatno.Text;
            string name = textBox_name.Text;
            string surname = textBox_surname.Text;
            string phone = textBox_phone.Text;
            string tc = textBox_tc.Text;
            string gender;

            if (checkBox_man.Checked)
            {
                gender = "man";
            }
            else
            {
                gender = "woman";
            }


            // It checks that the phone number and TR ID number consist of 11 digits and only numbers.
            bool control = false;
            if (textBox_tc.Text.Length == 11 && textBox_phone.Text.Length == 11)
            {

                for (int i = 0; i < 11; i++)
                {
                    bool is_digit_tc = char.IsNumber(textBox_tc.Text[i]);
                    bool is_digit_phone = char.IsNumber(textBox_phone.Text[i]);
                    if (is_digit_tc == true && is_digit_phone == true)
                    {

                    }
                    else
                    {
                        control = true;
                        //it contains characters.
                    }
                }
                if (control == true)
                {
                    MessageBox.Show("Please enter your TC number or phone number consisting of only words.", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tc = tc.Substring(0, 3) + "******" + tc.Substring(tc.Length - 2);
                    phone = phone.Substring(0, 4) + "*****" + phone.Substring(phone.Length - 2);
                    dataGridView1.Rows.Add(koltuk_no, name, surname, phone, tc, gender);

                    // Makes the purchased seat red and inaccessible.

                    for (int i = 0; i < groupBox_seats.Controls.Count; i++)
                    {
                        if (groupBox_seats.Controls[i].Enabled == true)
                        {
                            groupBox_seats.Controls[i].BackColor = Color.Red;
                            groupBox_seats.Controls[i].Enabled = false;
                            i++;

                        }
                        groupBox_seats.Controls[i].Enabled = true;

                    }

                    // After saving, it cleans the inside of the textboxes.

                    for (int i = 0; i < groupBox_information.Controls.Count; i++)
                    {
                        if (groupBox_information.Controls[i] is TextBox)
                        {
                            groupBox_information.Controls[i].Text = String.Empty;
                        }
                    }

                    btn_pay.Visible = true;


                }
            }
            else
            {
                MessageBox.Show("Please enter your TC number consisting of 11 digits or your phone number.", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //for (int i = 0; i < groupBox_seats.Controls.Count; i++)
            //{
            //    if (groupBox_seats.Controls[i].Enabled == true)
            //    {
            //        groupBox_seats.Controls[i].BackColor = Color.Red;
            //        groupBox_seats.Controls[i].Enabled = false;
            //        i++;

            //    }
            //    groupBox_seats.Controls[i].Enabled = true;

            //}

            //for (int i = 0; i < groupBox_information.Controls.Count; i++)
            //{
            //    if (groupBox_information.Controls[i] is TextBox)
            //    {
            //        groupBox_information.Controls[i].Text = String.Empty;
            //    }
            //}




        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            odeme odeme = new odeme();
            this.Hide();
            odeme.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            green_seat(button22);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            green_seat(button23);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            green_seat(button24);
        }
    }
}
