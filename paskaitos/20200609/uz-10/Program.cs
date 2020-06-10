using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uz_10
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ivesti nautraluji skaiciu:");
			int sk = Convert.ToInt32(Console.ReadLine());

			int nat_sk = 1;
			int nat_sk_suma = 1;

			while (nat_sk_suma < sk)
			{
				nat_sk++;
				nat_sk_suma += nat_sk;
			}

			if (sk == nat_sk_suma)
			{
				Console.WriteLine("TAIP");
			}
			else if (sk != nat_sk_suma)
			{
				Console.WriteLine("NE");
			}
		}
	}
}
