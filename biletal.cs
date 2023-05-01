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
    public partial class biletal : Form
    {
        public biletal()
        {
            InitializeComponent();
        }

        private void biletal_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_degistir_Click(object sender, EventArgs e)
        {
            string varis = comboBox_kalkis.Text;

            string kalkis = comboBox_varis.Text;
            comboBox_kalkis.Text = kalkis;
            comboBox_varis.Text = varis;

            //To change the location of the places to go here, I assigned two parameters to each other using.
        }

        private void btn_biletara_Click(object sender, EventArgs e)
        {
            otobus otobus = new otobus();
            /*
            First, it should be checked that the selections have been made.
            If there is an unselected value, the messagebox will warn otherwise 
            it will go to the "otobus" page.
            */

            if (comboBox_varis.SelectedIndex == -1 || comboBox_kalkis.SelectedIndex == -1 || comboBox_otobus.SelectedIndex == -1 || comboBox_saat.SelectedIndex == -1)
            {
                MessageBox.Show("Please make your selections.", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                otobus.Show();
                otobus.label1.Text = "Please select a seat for the bus service of " + comboBox_otobus.Text +
                    " company between\n" + comboBox_kalkis.Text + " - " + comboBox_varis.Text + " on " + dateTimePicker1.Text
                    + " at " + comboBox_saat.Text;

                //  In this section, I transferred the information on the "biletal" page to the "otobus" page.

            }



        }
    }
}
