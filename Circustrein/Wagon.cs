using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    class Wagon
    {
        List<Dier> dieren = new List<Dier>();

        private int volume;
        int punt;
        bool past_dier = false;
        bool veilig_voor_dier = false;
        bool carnivoor_aan_boord = false;
        bool herbivoor_aan_boord = false;
        bool groter_aan_boord = false;
        bool kleiner_aan_boord = false;

        public Wagon()
        {
            volume = 10;
        }

        public int Volume { get { return volume; } }

        public void Dier_Toevoegen(Dier dier)
        {
            dieren.Add(dier);
        }
        public void Past_Dier(Dier dier)
        {
            int grote = Convert.ToInt32(dier.Size);
            if (grote == 1)
            {
                punt = 1;
            }
            if (grote == 2)
            {
                punt = 3;
            }
            if (grote == 3)
            {
                punt = 5;
            }
            if (Volume - punt > 0)
            {
                past_dier = true;
            }
            else
            {
                past_dier = false;
            }
        }
        public void Veilig_voor_Dier(Dier dier)
        {

        }
        public void Carnivoor_aan_Boord()
        {

        }
        public void Herbivoor_aan_Boord()
        {

        }
        public void Groter_aan_Boord(Size size)
        {

        }
        public void Kleiner_aan_Boord(Size size)
        {

        }
    }
}
