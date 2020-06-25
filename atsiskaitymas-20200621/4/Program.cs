using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
	class Program
	{
		static void Main(string[] args)
		{
			// Parašykite kodą kuris iš 3 skaičių rastų didžiausią.
			Console.WriteLine("Įvesti pirmąjį skaičių:");
			int sk1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Įvesti antrąjį skaičių:");
			int sk2 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Įvesti trečiąjį skaičių:");
			int sk3 = Convert.ToInt32(Console.ReadLine());

			int didziausias_skaitmuo = sk1;

			if (didziausias_skaitmuo < sk2)
			{
				didziausias_skaitmuo = sk2;
			}
			if (didziausias_skaitmuo < sk3)
			{
				didziausias_skaitmuo = sk3;
			}
			Console.WriteLine("Didžiausias skaitmuo yra {0}:", didziausias_skaitmuo);

		}
	}
}
