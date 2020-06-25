using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
// Parašykite programą, kuri suskaičiuotų skaičių nuo m iki n sumą s = m + (m + 1) + ... + n.
// Pasitikrinkite.Kai m = 5, n = 10, tai s = 45.
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ivesti pradinį eilės skaičių:");
			int min_sk = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Ivesti paskutinį eilės skaičių:");
			int max_sk = Convert.ToInt32(Console.ReadLine());

			int suma = 0;
			for (int i = min_sk; i <= max_sk; i++)
			{
				suma += i;
			}

			Console.WriteLine("Skaičių eilės nuo {0} iki {1} suma: {2}", min_sk, max_sk, suma);

		}
	}
}
