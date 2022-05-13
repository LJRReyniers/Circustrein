using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class God
    {
		public static IEnumerable<Dier> RandomDieren(int min, int max)
		{
			List<Dier> dieren = new List<Dier>();
			Random r = new Random();
			int amount = r.Next(min, max);
			int count = 0;
			while(count < amount)
			{
				Dier a = RandomDier(r);
				dieren.Add(a);
				count++;
			}
			return dieren.AsEnumerable();
		}
		public static Dier RandomDier(Random r)
		{
			Dier a;
			// Random size
			int randomSize = r.Next(0, 3);
			Size size = (Size)(Enum.GetValues(typeof(Size)).GetValue(randomSize));
			// Random type
			int type = r.Next(0, 2);
			if(type == 1)
			{
				a = new Carnivore(size);
			}
			else
			{
				a = new Herbivore(size);
			}
			return a;
		}
	}
}
