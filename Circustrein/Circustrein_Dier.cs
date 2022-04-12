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
        List<Circus> lijst = new List<Circus>();
        List<Trein> wagon = new List<Trein>();
        private int punt;
        private int vol;
        int a = 0;
        int b = 0;
        int c = 0;
        int d = 0;
        int e = 0;
        
        public void Set_List(int naam, int dieet, int grote)
        {
            lists.Add(new Circus(naam, dieet, grote, 0));
            Get_List(naam, dieet, grote);
        }

        public void Get_List(int naam, int dieet, int grote)
        {
            //lijst.Clear();
            for (int i = 0; i < lists.Count; i++)
            {
                Circus item = lists[i];
                if (grote == 1)
                {
                    punt = 1;
                }
                if (grote == 2)
                {
                    punt = 3;
                }
                if (grote == 3)
                {
                    punt = 5;
                }
                else
                {
                    return;
                }
            }
            lijst.Add(new Circus(naam, dieet, grote, punt));
            for (int i = 0; i < lijst.Count; i++)
            {
                Circus item = lijst[i];
                if (grote == 1 && dieet == 1)
                {
                    vol = 1;
                    wagon.Add(new Trein(vol));
                }
                if (grote == 2 && dieet == 1)
                {
                    b++;
                    if (a == 1 && b == 1)
                    {
                        vol = a + b;
                        wagon.Add(new Trein(vol));
                        b = 0;
                    }
                    else if (b ==1)
                    {
                        vol = b;
                        wagon.Add(new Trein(vol));
                        b = 0;
                    }
                }
                if (grote == 3 && dieet == 1)
                {
                    d++;
                    if (c == 3 && d == 1)
                    {
                        vol = c + d;
                        wagon.Add(new Trein(vol));
                        d = 0;
                    }
                    else if (d == 1)
                    {
                        vol = d;
                        wagon.Add(new Trein(vol));
                        d = 0;
                    }
                }
                if (grote == 1 && dieet == 2)
                {
                    e++;
                    if (e != 0 && e < 10)
                    {
                        vol = e;
                        wagon.Add(new Trein(vol));
                    }
                    e = 0;
                }
                if (grote == 2 && dieet == 2)
                {
                    c++;
                    if (c == 3 && d == 1)
                    {
                        vol = c + d;
                        wagon.Add(new Trein(vol));
                        c = 0;
                    }
                    else if (c != 0 && c < 10)
                    {
                        vol = c;
                        wagon.Add(new Trein(vol));
                        c = 0;
                    }

                }
                if (grote == 3 && dieet == 2)
                {
                    a++;
                    if (a == 2)
                    {
                        vol = a;
                        wagon.Add(new Trein(vol));
                        a = 0;
                    }
                    else if (a == 1 && b == 1)
                    {
                        vol = a + b;
                        wagon.Add(new Trein(vol));
                        a = 0;
                    }
                }
                else
                {
                    return;
                }
            }
            Console.WriteLine(wagon.Count);
        }
    }
}
