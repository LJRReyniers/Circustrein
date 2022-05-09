using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    class Circus
    {
        List<Dier> lijst = new List<Dier>();

        int i;

        public void Get_lijst(int sV, int mV, int lV, int sP, int mP, int lP)
        {
            while (sV < i)
            {
                lijst.Add(new Dier { DierId = 1, DierDieet = "vlees", DierGrote = "klein"});
                i++;
            }
            i = 0;
            while (mV < i)
            {
                lijst.Add(new Dier { DierId = 3, DierDieet = "vlees", DierGrote = "middel" });
                i++;
            }
            i = 0;
            while (lV < i)
            {
                lijst.Add(new Dier { DierId = 5, DierDieet = "vlees", DierGrote = "groot" });
                i++;
            }
            i = 0;
            while (sP < i)
            {
                lijst.Add(new Dier { DierId = 1, DierDieet = "plant", DierGrote = "klein" });
                i++;
            }
            i = 0;
            while (mP < i)
            {
                lijst.Add(new Dier { DierId = 3, DierDieet = "plant", DierGrote = "middel" });
                i++;
            }
            i = 0;
            while (lP < i)
            {
                lijst.Add(new Dier { DierId = 5, DierDieet = "plant", DierGrote = "groot" });
                i++;
            }
            i = 0;
        }
        public int Count_lijst()
        {
            return lijst.Count();
        }
    }
}
