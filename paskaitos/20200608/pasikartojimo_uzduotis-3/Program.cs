using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pasikartojimo_uzduotis_3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Įvesti eglutčių kiekį:");
			int kiekis = Convert.ToInt32(Console.ReadLine());
			double auksciu_suma = 0;
			for (int i = 1; i <= kiekis; i++)
			{
				Console.WriteLine("Įvesti {0} eglutės aukštį:", i);
				auksciu_suma += Convert.ToDouble(Console.ReadLine());

			}
			double vidurkis = (double)auksciu_suma / kiekis;
			Console.WriteLine(vidurkis);
		}
	}
}
