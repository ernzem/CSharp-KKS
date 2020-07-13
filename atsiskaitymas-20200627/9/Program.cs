
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
	class Program
	{
		// Parašykite programą, kuri išvestų visus duotojo skaičiaus n daliklius. Pasitikrinkite. 
		// Jei n = 12, tai turi būti išvesta: 1, 2, 3, 4, 6, 12.
		static void Main(string[] args)
		{
			Console.WriteLine("Ivesti skaiciu:");
			int digit = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Dalikliai:");


			for (int i = 1; i <= digit; i++)
			{
				if (digit % i == 0)
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}
