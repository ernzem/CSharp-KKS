using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uz_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ivesti skaiciu be 0 skaitmenu");
			int sk = Convert.ToInt32(Console.ReadLine());

			int sandauga = 1;

			while (sk / 10 != 0)
			{
				sandauga *= sk % 10;
				sk /= 10;
			}

			if (sk / 10 == 0)
			{
				sandauga *= sk % 10;
			}
			Console.WriteLine("Skaitmenu sandauga: {0}", sandauga);
		}
	}
}
