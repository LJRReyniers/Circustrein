using System;
using System.Collections.Generic;
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
		public static Dier RandomDieren(Random r)
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
		public static Dier SmallHerbivore { get => new Herbivore(Size.Small); }
		public static Dier MediumHerbivore { get => new Herbivore(Size.Medium); }
		public static Dier LargeHerbivore { get => new Herbivore(Size.Large); }
		public static Dier SmallCarnivore { get => new Carnivore(Size.Small); }
		public static Dier MediumCarnivore { get => new Carnivore(Size.Medium); }
		public static Dier LargeCarnivore { get => new Carnivore(Size.Large); }

	}
}
