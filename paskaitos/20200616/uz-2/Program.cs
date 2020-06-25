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
			Random rng = new Random();
			int skaiciuKiekis = rng.Next(15);
			List<int> skaiciuListas = new List<int>();
			int nelyg_kiekis = 0;
			int nelyg_suma = 0;
			for (int i = 0; i < skaiciuKiekis; i++)
			{
				int sk = rng.Next();
				skaiciuListas.Add(sk);
				if (sk % 2 != 0)
				{
					nelyg_kiekis += 1;
					nelyg_suma += sk;
					
				}

			}
			Console.WriteLine("Didziausias skaicius yra: " + skaiciuListas.Max());
			Console.WriteLine("Maziausias skaicius yra: " + skaiciuListas.Min());
			Console.WriteLine("Vidurkis " + skaiciuListas.Average());
			Console.WriteLine("Paskutinis skaicius " + skaiciuListas.First());
			Console.WriteLine("Pirmas skaicius " + skaiciuListas.Last());
			Console.WriteLine("Viso: " + skaiciuListas.Count);
			Console.WriteLine("");
			Console.WriteLine("Nelyginius skaiciu kiekis :" + nelyg_kiekis);
			Console.WriteLine("Skaiciu suma: " + nelyg_suma);

		}
	}
}
