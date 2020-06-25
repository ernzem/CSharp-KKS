using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uz2_fibonaci_skaiciai_masyve
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] fibonaci = new int[10];
			fibonaci[0] = 0;
			fibonaci[1] = 1;
			for (int i = 2; i < fibonaci.Length; i++)
			{
				fibonaci[i] = fibonaci[i -1] + fibonaci[i -2];
			}


			for (int i = 0; i < fibonaci.Length; i++)
			{
				Console.WriteLine(fibonaci[i]);
			}
		}
	}
}
