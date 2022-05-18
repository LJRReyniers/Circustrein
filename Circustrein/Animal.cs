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
        public string Size { get; set; }

        public Animal()
        {

        }

        internal class Get_Carnivoor : Animal
        {
            private Size size;

            public Get_Carnivoor(Size size)
            {
                this.size = size;
            }
        }

        internal class Get_Herbivoor : Animal
        {
            private Size size;

            public Get_Herbivoor(Size size)
            {
                this.size = size;
            }
        }
    }
}
