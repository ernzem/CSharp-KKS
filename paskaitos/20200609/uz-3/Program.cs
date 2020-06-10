using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uz_3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ivesti sveika skaiciu:");
			int sk = Convert.ToInt32(Console.ReadLine());

			double skaitmenu_kiekis = 0;
			while (sk / 10 != 0)
			{
				skaitmenu_kiekis += 1;
				sk = sk / 10;
			}

			if (sk / 10 == 0)
			{
				skaitmenu_kiekis += 1;
			}
			Console.WriteLine("Skaitmenu kiekis: {0}", skaitmenu_kiekis);
		}
	}
}
