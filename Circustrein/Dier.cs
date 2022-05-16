using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Dier
    {
        public string Size { get; set; }

        public Dier()
        {

        }

        internal class Get_Carnivoor : Dier
        {
            private Size size;

            public Get_Carnivoor(Size size)
            {
                this.size = size;
            }
        }

        internal class Get_Herbivoor : Dier
        {
            private Size size;

            public Get_Herbivoor(Size size)
            {
                this.size = size;
            }
        }
    }
}
