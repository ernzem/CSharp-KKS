using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uz_1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ivesti sveika skaiciu:");
			int sk = Convert.ToInt32(Console.ReadLine());

			double suma = 0;
			while (sk == 0)
			{
				Console.WriteLine("Skaicius 0 netinka.Ivesti kita sveika skaiciu:");
				sk = Convert.ToInt32(Console.ReadLine());
			}
			
			while (sk / 10 != 0)
			{
				suma += sk % 10;
				sk = sk / 10;
			}

			if (sk / 10 == 0)
			{
				suma += sk % 10;
			}
			Console.WriteLine("Skaitmenu suma: {0}", suma);

		}
	}
}
