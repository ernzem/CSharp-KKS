using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
	class Program
	{
		// 9. Parašykite programą, kuri išvestų visus duotojo skaičiaus n daliklius.
		// Pasitikrinkite.Jei n = 12, tai turi būti išvesta: 1, 2, 3, 4, 6, 12.
		// 10. Papildykite šią programą taip, kad ji ne tik išvestų visus duotojo skaičiaus daliklius, 
		// bet ir suskaičiuotų jų kiekį, surastų šių daliklių sumą ir sandaugą.
		static void Main(string[] args)
		{
			List<int> answer = new List<int>();
			Console.WriteLine("Ivesti skaiciu:");
			int digit = Convert.ToInt32(Console.ReadLine());

			for (int i = 1; i <= digit; i++)
			{
				if (digit % i == 0)
				{
					answer.Add(i);
				}
			}
			Console.WriteLine("Dalikliai: " + string.Join(", ", answer));
			Console.WriteLine("Dalikliu kiekis: " + answer.Count);
			Console.WriteLine("Dalikliu suma: " + answer.Sum());
			Console.WriteLine("Dalikliu sandauga: " + answer.Aggregate((a, x) => a * x));
		}
	}
}
