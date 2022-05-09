using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    class Wagon
    {
        List<Wagon> dieren = new List<Wagon>();
        Circus Circus = new Circus();
        //int nummer = Circus.Count_lijst();
        int max_vol = 10;
        int volume;
        bool Past_dier;
        bool Niet_opgegeten;
        bool Plaatsen_dier;

        public int DierId { get; }
        public string DierDieet { get; }
        public string DierGrote { get; }

        public void Dier_plaatsen()
        {
            if (volume != max_vol && volume + DierId < max_vol)
            {
                Past_dier = true;
            }
            else Past_dier = false;
            if (volume == 0)
            {
                Niet_opgegeten = true;
            }
            else Niet_opgegeten = false;
            if (Past_dier == true && Niet_opgegeten == true)
            {
                Plaatsen_dier = true;
            }
            else Plaatsen_dier = false;
        }
    }
}
