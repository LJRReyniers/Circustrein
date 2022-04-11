using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    class Circus
    {
        private int naam;
        private int dieet;
        private int grote;
        private int punt;

        public int Id
        {
            get { return naam; }
        }

        public int Punt
        {
            get { return punt; }
        }

        public Circus(int a, int b, int c)
        {
            naam = a;
            dieet = b;
            grote = c;
        }
    }
}
