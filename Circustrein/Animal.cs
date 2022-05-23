using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Animal
    {
        private int size;
        int point;

        public int Size { get { return size; } }
        public string Carnivore { set { } }
        public string Herbivore { set { } }

        public Animal(int size)
        {
            
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

        //public static implicit operator Animal(Carnivore v) => throw new NotImplementedException();

        //public static implicit operator Animal(Herbivore v) => throw new NotImplementedException();
    }
}
