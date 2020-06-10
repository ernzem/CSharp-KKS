using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uz1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("rėžio pradžia:");
			int min = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("rėžio pabaiga:");
			int max = Convert.ToInt32(Console.ReadLine());

			int suma = 0;
			int kiekis = 0;
			while (min != max+1)
			{
				suma += min;
				kiekis += 1;
				min++;
			}

			Console.WriteLine("Vidurkis: {0}", suma/kiekis);
		}
	}
}
