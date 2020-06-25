using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Anos_uzdavinukas
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ivesti skaiciu");
			int skaicius = Convert.ToInt32(Console.ReadLine());
			int atsakymas = 0;
			for (int i = skaicius; i > 0; i--)
			{
				// 10, 4578, 3434534, 3
				if (ArSkTvarkingas(i))
				{
					Console.WriteLine("Didziausias tvarkingas skaicius yra: " + atsakymas);
					break;
				}

			}

		}

		public static bool ArSkTvarkingas(int skaicius)
		{
			int vnt = skaicius % 10;
			int desimtys = skaicius / 10 % 10;

			skaicius /= 10;
			if (vnt >= desimtys)
			{
				// REKURSIJA
				if (skaicius >= 10)
				{
					return ArSkTvarkingas(skaicius);
				}
				else
				{
					return true;
				}
			}
			else
			{
				return false;
			}
		}
	}
}
