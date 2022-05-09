using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circustrein
{
    public partial class Circustrein : Form
    {
        public Circustrein()
        {
            InitializeComponent();
        }

        int dieet = 0;
        int grote = 0;
        int punt;
        //Trein Trein = new Trein();
        Dier Circus = new Dier();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dieet = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dieet = 2;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            grote = 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            grote = 2;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            grote = 3;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circus.Get_punt(Convert.ToInt32(textBox1.Text), dieet, grote);
            //Trein.Set_lijst(Convert.ToInt32(textBox1.Text), dieet, grote, punt);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
