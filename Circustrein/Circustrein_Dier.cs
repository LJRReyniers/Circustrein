using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    class Circustrein_Dier
    {
        List<Circus> lists = new List<Circus>();
        private int punt;
        
        public void Set_List(int naam, int dieet, int grote)
        {
            lists.Add(new Circus(naam,dieet,grote));
        }

        public void Get_List()
        {
            //lists.Clear();

        }
    }
}
