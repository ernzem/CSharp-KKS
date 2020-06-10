using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uz_11
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ivesti sveika skaiciu:");
			int sk = Convert.ToInt32(Console.ReadLine());
			string ats = "PIRMINIS";
			for (int i = 2; i < sk; i++)
			{
				if (sk % i == 0)
				{
					ats = "SUDETINIS";
					break;
				}
			}
			Console.WriteLine("Skaicius {0}", ats);
		}


	}
}
