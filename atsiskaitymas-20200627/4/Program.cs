using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4

// Vaikui gimus tėvas padovanojo 5 litus.Kiekvienais kitais metais gimtadienio proga padovanodavo tiek litų, kiek jam sueidavo metų.
// Parašykite programą, kuri suskaičiuotų, kiek jis turės litų, kai jam sueis n metų.
// Pasitikrinkite. Kai n = 16, tai s = 141.
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ivesti vaiko metus:");
			int metai = Convert.ToInt32(Console.ReadLine());
			int pinigu_suma = 5;

			for (int k = 1; k <= metai; k++)
			{
				pinigu_suma += k;
			}

			Console.WriteLine("Pinigų suma po {0} metų: {1}",metai , pinigu_suma);
		}
	}
}
