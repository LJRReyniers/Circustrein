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
        List<Animal> animals = new List<Animal>();
        Wagon wagon = new Wagon();

        private int volume;
        int point;

        public Wagon()
        {
            volume = 10;
        }

        public int Volume { get { return volume; } }

        public void Add_Random_Animals()
        {
            God.RandomDieren(0, 10);
        }
        public void Get_Animal_Point(Animal animal)
        {
            int size = Convert.ToInt32(animal.Size);
            if (size == 1)
            {
                point = 1;
            }
            if (size == 2)
            {
                point = 3;
            }
            if (size == 3)
            {
                point = 5;
            }
        }
        public void Animal_Check(Animal animal)
        {
            foreach (Animal item in animals)
            {
                Get_Animal_Point(animal);
                if (Volume - point > 0)
                {
                    if (wagon == null)
                    {
                        animals.Add(item);
                    }
                    else
                    {

                    }
                }
                else
                {
                    Wagon wagon = new Wagon();
                }
            }
        }
    }
}
