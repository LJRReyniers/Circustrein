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

        //public void Animal_Check(Animal animal)
        //{
        //    foreach (Animal item in animals)
        //    {
        //        wagon.Get_Animal_Point(animal);
        //        if (wagon.Volume - point > 0)
        //        {
        //            if (wagon.Volume != 0)
        //            {
                        
        //            }
        //            else
        //            {
        //                animals.Add(item);
        //            }
        //        }
        //        else
        //        {
        //            Wagon wagon = new Wagon();
        //        }
        //    }
        //}
    }
}
