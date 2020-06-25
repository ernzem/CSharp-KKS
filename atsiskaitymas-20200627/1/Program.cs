using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _1

// Parašykite programą, kuri suskaičiuotų skaičių nuo 1 iki 100 sumą s = 1 + 2 + 3 ...+ 100.
// Pasitikrinkite.Atsakymas turi būti s = 5050.


{
	class Program
	{
		static void Main(string[] args)
		{
			int suma = 0;
			for (int i = 1; i <= 100; i++)
			{
				suma += i;
			}

			Console.WriteLine("Skaičių nuo 1 iki 100 suma: {0}", suma);

		}
	}
}
