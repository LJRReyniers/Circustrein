using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Wagon
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
        public void Add_Animal(Animal animal)
        {
            animals.Add(animal);
            volume = volume - point;
            animals.RemoveAt(0);
        }

        public void Animal_Check(Animal newAnimal, Carnivore carnivore)
        {
            Add_Random_Animals();
            foreach (Animal item in animals)
            {
                newAnimal.Get_Animal_Point(newAnimal);
                if (Volume - point > 0)
                {
                    if (animal_in_wagon == true)
                    {
                        if (animal_in_wagon_herbivore == true)
                        {
                            if (newAnimal.Type == 0)
                            {
                                Add_Animal(item);
                            }
                            else
                            {
                                new_wagon = true;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(carnivore.Size) < Convert.ToInt32(newAnimal.Size))
                            {
                                if (newAnimal.Type == 0)
                                {
                                    Add_Animal(item);
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
                        Add_Animal(item);
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
