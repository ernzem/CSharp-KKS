using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uz_DienuTemperaturos
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ivesti visas temperaturas kurias norite fiksuoti per tarpa");
			var duomenys = Console.ReadLine().Split(' ');
			var suma = 0;
			int[] temperaturos = new int[duomenys.Length];
			for (int i = 0; i < temperaturos.Length; i++)
			{
				temperaturos[i] = int.Parse(duomenys[i]);
			}

			for (int i = 0; i < temperaturos.Length; i++)
			{
				if (temperaturos[i] < temperaturos.Average())
				{
					suma += temperaturos[i];
				}

			}

			Console.WriteLine("Temperaturu vidurkis: " + temperaturos.Average());
			Console.WriteLine("Didziausia temperatura: " + temperaturos.Max());
			Console.WriteLine("Maziausia temperatura: " + temperaturos.Min());
			Console.WriteLine("Mazesniu nei vidurkis yra:" + suma);
		}
	}
}
