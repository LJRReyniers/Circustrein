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
        public Animal()
        {

        }

        public int Size { get { return size; } }

        internal class Carnivore : Animal
        {
            private Size size;

            public Carnivore(Size size)
            {
                this.size = size;
            }
        }

        internal class Herbivore : Animal
        {
            private Size size;

            public Herbivore(Size size)
            {
                this.size = size;
            }
        }
    }
}
