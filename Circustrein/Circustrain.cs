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
    public partial class Circustrain : Form
    {
        Train train = new Train();
        Wagon wagon = new Wagon();
        Animal animal = new Animal();
        Carnivore carnivore = new Carnivore();

        public Circustrain()
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
            train.Wagon_Check(wagon, animal, carnivore);
            if (train.Visualise_Train() == true)
            {
                pictureBox1.Image = Properties.Resources.Train;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.wrong;
            }
        }
    }
}
