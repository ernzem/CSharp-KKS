using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _7
{
	class Program
	{
		// 7. Parašykite programą, kuri rastų ir išvestų į ekraną visus dviženklius skaičius, 
		// kurių abu skaitmenys yra lyginiai, rastų jų kiekį ir juos susumuotų.
		// Pasitikrinkite.Jų yra 20, o jų suma yra 1080.

		static void Main(string[] args)
		{
			List<int> output = new List<int>();
			
			for (int first = 2; first <= 8; first += 2)
			{
				for (int second = 0; second <= 8; second += 2)
				{
					output.Add(Convert.ToInt32(string.Format("{0}{1}", first, second)));
				}
			}

			foreach (var item in output)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine("Total number of digits: {0}", output.Count);
			Console.WriteLine("Sum of all digits: {0}", output.Sum());
		}
	}
}
