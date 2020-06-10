using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pasikartojimo_uzduotis_1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Įvesti primąjį skaičių:");
			double sk1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Įvesti antrąjį skaičių:");
			double sk2 = Convert.ToDouble(Console.ReadLine());

			double sandauga = 0;
			for (int i = 0; i < sk2; i++)
			{
				sandauga += sk1;
			}
			Console.WriteLine("Atsakymas: {0}", sandauga);
		}
	}
}
