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
        bool animal_in_wagon = false;
        bool new_wagon = false;
        bool animal_in_wagon_herbivore = false;

        public Wagon()
        {
            volume = 10;
        }

        public int Volume { get { return volume; } }
        public bool Animal_in_wagon { get { return animal_in_wagon; } }
        public bool New_wagon { get { return new_wagon; } }
        public bool Animal_in_wagon_herbivore { get { return animal_in_wagon_herbivore; } }

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
            Add_Random_Animals();
            foreach (Animal item in animals)
            {
                Get_Animal_Point(animal);
                if (Volume - point > 0)
                {
                    if (animal_in_wagon == true)
                    {
                        if (animal_in_wagon_herbivore == true)
                        {
                            if (animal == Animal.Herbivore)
                            {
                                animals.Add(item);
                                volume = volume - point;
                                animals.RemoveAt(0);
                            }
                            else
                            {
                                new_wagon = true;
                            }
                        }
                        else
                        {
                            if (Animal.Size < animal.Size)
                            {
                                if (animal == Animal.Herbivore)
                                {
                                    animals.Add(item);
                                    volume = volume - point;
                                    animals.RemoveAt(0);
                                }
                                else
                                {
                                    new_wagon = true;
                                }
                            }
                            else
                            {
                                new_wagon = true;
                            }
                        }
                    }
                    else
                    {
                        animals.Add(item);
                        volume = volume - point;
                        animals.RemoveAt(0);
                    }
                }
                else
                {
                    new_wagon = true;
                }
            }
        }
    }
}
