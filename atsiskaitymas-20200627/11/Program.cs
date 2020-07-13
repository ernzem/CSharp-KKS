using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
	// Parašykite programą, kuri nustatytų, ar duotas skaičius n yra pirminis (turi tik du daliklius: vienetą ir patį save).
	// Pasitikrinkite.Jei n = 7, tai turi būti išvesta: skaičius 7 yra pirminis. Jei n = 15, tai turi būti išvesta: skaičius 15 yra sudėtinis.
	class Program
	{
		public static bool Prime(int digit)
		{
			for (int i = 2; i < digit; i++)
			{
				if (digit % i == 0)
				{
					return false;
				}
			}
			return true;
		}

			static void Main(string[] args)
		{
			Console.WriteLine("Ivesti skaiciu:");
			int digit = Convert.ToInt32(Console.ReadLine());
		
			if (Prime(digit))
			{
				Console.WriteLine("Skaičius {0} yra pirminis.", digit);
			}
			else
			{
				Console.WriteLine("Skaičius {0} yra sudėtinis.", digit);
			}

		}
	}
}
