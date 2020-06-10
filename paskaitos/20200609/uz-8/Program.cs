using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uz_8
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ivesti sveika skaiciu:");
			int sk = Convert.ToInt32(Console.ReadLine());

			int org_sk = sk;
			int skaitmuo = 0;

			while (sk > 0)
			{
				skaitmuo = sk % 10;
				sk = sk / 10;
			}

			Console.WriteLine("Skaicius {0} pirmas skaitmuo {1}", org_sk, skaitmuo);
		}
	}
}
