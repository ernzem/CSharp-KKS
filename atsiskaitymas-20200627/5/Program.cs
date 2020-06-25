using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5

// Parašykite programą, kuri suskaičiuotų skaičiaus n faktorialą s = 1 * 2 * ... * n.
// Pasitikrinkite.Kai n = 3, tai s = 6, o kai n = 5, tai s = 120.
  
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ivesti skaičių:");
			int sk = Convert.ToInt32(Console.ReadLine());
			int atsakymas = sk;

			for (int i = 1; i < sk; i++)
			{
				atsakymas *= (sk - i);
			}

			Console.WriteLine("Skaičiaus {0} faktorialas: {1}", sk, atsakymas);
		}
	}
}
