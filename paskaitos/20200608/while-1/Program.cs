using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ivesti skaiciu:");
			int skaicius = Convert.ToInt32(Console.ReadLine());
			double suma = 0;
			while (skaicius > 0)
			{
				if (skaicius % 2 == 0)
				{
					suma += skaicius;
				
				}
				Console.WriteLine(skaicius--);
			}
			Console.WriteLine("Lyginiu skaiciu suma: {0}", suma);
		}
	}
}
