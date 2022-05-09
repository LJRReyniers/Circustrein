using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    class Trein
    {
        int id;
        int max_vol = 10;
        int punt;
        int nummer;
        int i;
        List<Trein> trein = new List<Trein>();
        List<Trein> wagons = new List<Trein>();
        Circus Circus = new Circus();

        public int Id
        {
            get { return id; }
        }
        public string DierNaam { get; set; }
        public int DierId { get; set; }
        public int DierDieet { get; set; }

        public Trein()
        {
            
        }

        public void Get_wagon(int dieet, int punt)
        {
            nummer = Circus.Count_lijst();
            while (nummer < i)
            {
                
                i++;
            }
        }
        public void Set_lijst(int naam, int dieet, int punt)
        {
            trein.Add(new Trein() { DierNaam = Convert.ToString(naam), DierId = punt, DierDieet = dieet });
            foreach (Trein aTrein in trein)
            {
                Console.WriteLine(aTrein);
            }
        }
        public void Get_indeling()
        {

        }
    }
}
