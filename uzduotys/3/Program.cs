using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
	class Program
	{
		static void Main(string[] args)
		{
			/*Indėlininkas į banką padėjo suma litų. Bankas moka 2proc. metinių palūkanų. Sudarykite programą dviejų metų apskaitai skaičiuoti. Ekrane išveskite palūkanas ir turimą indėlį kasmet.*/

			float palukanu_norma = 0.02f;

			Console.WriteLine("Pinigų suma:");
			double pinigai = Convert.ToDouble(Console.ReadLine());

			double palukanos1 = Math.Round(pinigai * palukanu_norma, 2);
			double indelis1 = Math.Round(pinigai + palukanos1, 2);
			Console.WriteLine("1 metai. Palūkanos: {0}Eur., turimas indėlis {1}Eur.:",palukanos1, indelis1);

			double palukanos2 = Math.Round(indelis1 * palukanu_norma);
			double indelis2 = Math.Round(indelis1 + palukanos2);
			Console.WriteLine("2 metai. Palūkanos: {0}Eur., turimas indėlis {1}Eur.:",palukanos2, indelis2);

			// FIX DATA TYPES!! USE DECIMAL INSTEAD OF DOUBLE FOR MONEY https://stackoverflow.com/questions/693372/what-is-the-best-data-type-to-use-for-money-in-c
		}
	}
}
