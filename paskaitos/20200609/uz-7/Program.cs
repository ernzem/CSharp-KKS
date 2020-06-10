using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uz_4
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ivesti sveika skaiciu:");
			int sk = Convert.ToInt32(Console.ReadLine());

			int org_sk = sk;
			int lyg_suma = 0;
			int nelyg_suma = 0;

			while (sk > 0)
			{
				int skaitmuo = sk % 10;
				if (skaitmuo % 2 == 0)
				{
					lyg_suma += 1;
				}
				else
				{
					nelyg_suma += 1;
				}
				sk = sk / 10;
			}

			Console.WriteLine("Skaicius {0} Nelyginiu skaiciu - {1}, lyginiu - {2}", org_sk, nelyg_suma, lyg_suma);
		}
	}
}
