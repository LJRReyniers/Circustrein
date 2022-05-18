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
		public static IEnumerable<Animal> RandomDieren(int min, int max)
		{
			List<Animal> animals = new List<Animal>();
			Random r = new Random();
			int amount = r.Next(min, max);
			int count = 0;
			while(count < amount)
			{
				Animal a = RandomDier(r);
				animals.Add(a);
				count++;
			}
			return animals.AsEnumerable();
		}
		public static Animal RandomDier(Random r)
		{
			Animal a;
			// Random size
			int randomSize = r.Next(0, 3);
			Size size = (Size)(Enum.GetValues(typeof(Size)).GetValue(randomSize));
			// Random type
			int type = r.Next(0, 2);
			if(type == 1)
			{
				a = new Animal.Carnivore(size);
			}
			else
			{
				a = new Animal.Herbivore(size);
			}
			return a;
		}
	}
}
