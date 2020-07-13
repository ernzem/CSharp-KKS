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
			Console.WriteLine("Ivesti skaiciu:");
			int sk = Convert.ToInt32(Console.ReadLine());
			if (sk != 0)
			{
				Uzmigimas(sk)
			}
			else
			{
				Console.WriteLine("NEMIGA");
			}
		}

		private static void Uzmigimas(int sk, int[] masyvas)
		{
			int i = 1;
			while (masyvas.Sum() != 10)
			{
				int tempSk = sk * ++i;

				while (tempSk > 0)
				{
					if (masyvas[tempSk%10] != 1 )
					{
						masyvas[tempSk % 10] = 1;
					}
					tempSk /= 10;
				}
			}
			Console.WriteLine(sk* i);
		}
	}
}
