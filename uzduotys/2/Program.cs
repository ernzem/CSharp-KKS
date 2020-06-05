using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
	class Program
	{
		static void Main(string[] args)
		{
			/* Žinomi kambario matmenys –ilgis ir plotis. Abu dydžiai sveikieji skaičiai. 
			 * Reikia apskaičiuoti, kokią pinigų sumą reiks mokėti už plyteles, skirtas kambario grindims kloti, jei plytelių vieno kvadrato kaina yra kaina litų. 
			 * Plytelių reikia pirkti 5 proc. daugiau galimiems nuostoliams padengti.*/

			Console.WriteLine("Įvesti kambario ilgį:");
			int ilgis = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Įvesti kambario plotį:");
			int plotis = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Įvesti plytelių kaina:");
			double kv_kaina = Convert.ToDouble(Console.ReadLine());

			double atsarga = 0.05f;

			double bendra_kaina = Math.Round(ilgis * plotis * kv_kaina * (1 + atsarga), 2);
			Console.WriteLine("Plytelių kaina: {0} Eur.", bendra_kaina);

		}
	}
}
