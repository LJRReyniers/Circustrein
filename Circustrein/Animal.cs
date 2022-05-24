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
        private Enum size;
        int point;
        string animalType;

        public IEnumerable<Animal> Size { get { return (IEnumerable<Animal>)size; } }
        public string Carnivore { get; set; }
        public string Herbivore { get; set; }
        public int Type { get; }

        public Animal()
        {
            if (Type == 0)
            {
                animalType = Carnivore;
            }
            else if (Type == 1)
            {
                animalType = Herbivore;
            }
            
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
