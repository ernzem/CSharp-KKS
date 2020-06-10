using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uz_9
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ivesti pirmaji skaiciu:");
			int sk = Convert.ToInt32(Console.ReadLine());

			int org_sk = sk;
			int skaitmuo = 0;

			while (sk > 0)
			{
				skaitmuo = sk % 10;
				sk = sk / 10;
			}

			Console.WriteLine("Ivesti antraji skaiciu:");
			int sk2 = Convert.ToInt32(Console.ReadLine());

			int org_sk2 = sk2;
			int skaitmuo2 = 0;

			while (sk2 > 0)
			{
				skaitmuo2 = sk2 % 10;
				sk2 = sk2 / 10;
			}

			Console.WriteLine("Skaiciu {0} ir {1} pirmu skaitmenu suma {2}", org_sk, org_sk2, skaitmuo + skaitmuo2);
		}
	}
}
