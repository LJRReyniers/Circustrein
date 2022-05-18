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

        private int volume;
        int point;
        bool does_animal_fit = false;
        bool safe_for_animal = false;
        bool carnivore_on_board = false;
        bool herbivore_on_board = false;
        bool bigger_animal_on_board = false;
        bool smaller_animal_on_board = false;

        public Wagon()
        {
            volume = 10;
        }

        public int Volume { get { return volume; } }

        public void Add_Animal(Animal dier)
        {
            animals.Add(dier);
        }
        public void Does_Animal_Fit(Animal animal)
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
            if (Volume - point > 0)
            {
                does_animal_fit = true;
            }
            else
            {
                does_animal_fit = false;
            }
        }
        public void Safe_For_Animal(Animal animal)
        {
            if (animals.Count == 0)
            {
                safe_for_animal = true;
            }
        }
        public void Carnivore_On_Board()
        {
            if (animals.Count == 0)
            {
                carnivore_on_board = false;
            }
        }
        public void Herbivore_On_Board()
        {
            if (animals.Count == 0)
            {
                herbivore_on_board = false;
            }
        }
        public void Bigger_Animal_On_Board(Size size)
        {
            if (animals.Count == 0)
            {
                bigger_animal_on_board = false;
            }
        }
        public void Smaller_Animal_On_Board(Size size)
        {
            if (animals.Count == 0)
            {
                smaller_animal_on_board = false;
            }
        }
    }
}
