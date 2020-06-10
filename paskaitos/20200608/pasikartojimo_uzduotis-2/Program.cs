using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pasikartojimo_uzduotis_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Žingsnių skaičius:");
			int zingsniai = Convert.ToInt32(Console.ReadLine());

			int plojimai = 10;
			int spragtelejimas = 5;

			Console.WriteLine("Plojimų  skaičius: {0}:", zingsniai / plojimai);
			Console.WriteLine("Spragtelejimu skaičius: {0}:", zingsniai / spragtelejimas);
		}
	}
}
