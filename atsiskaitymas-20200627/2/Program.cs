using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
	class Program
	{
		static void Main(string[] args)
		{
			int suma = 0;

			Console.WriteLine("Ivesti skaičių iki kurio rasti sumą nuo 1:");
			int max_sk = Convert.ToInt32(Console.ReadLine());

			for (int i = 1; i <= max_sk; i++)
			{
				suma += i;
			}

			Console.WriteLine("Skaičių nuo 1 iki {0} suma: {1}", max_sk, suma);
		}
	}
}
