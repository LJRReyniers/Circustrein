using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    class Train
    {
        List<Animal> animals = new List<Animal>();
        List<Wagon> wagons = new List<Wagon>();
        Wagon wagon = new Wagon();

        int point;

        public Train()
        {
            
        }

        public void Wagon_Count()
        {
            wagons.Count();
        }

        public void Wagon_Check(Wagon wagon, Animal animal)
        {
            wagon.Animal_Check(animal);
            if (wagon.New_wagon == true)
            {
                Wagon wagon1 = new Wagon();
            }
            if (animals == null)
            {
                Visualise_Train();
            }
            else
            {
                wagon.Animal_Check(animal);
            }
        }
        public void Visualise_Train()
        {

        }
    }
}
