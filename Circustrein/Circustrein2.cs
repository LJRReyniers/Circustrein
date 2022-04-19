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
    public partial class Circustrein2 : Form
    {
        public Circustrein2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Enter_btn_Click(object sender, EventArgs e)
        {
            int sV = Convert.ToInt32(sVlees_txtb.Text);
            int mV = Convert.ToInt32(mVlees_txtb.Text);
            int lV = Convert.ToInt32(lVlees_txtb.Text);
            int sP = Convert.ToInt32(sPlant_txtb.Text);
            int mP = Convert.ToInt32(mPlant_txtb.Text);
            int lP = Convert.ToInt32(lPlant_txtb.Text);
        }
    }
}
