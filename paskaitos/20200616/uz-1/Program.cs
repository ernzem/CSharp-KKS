using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uz_1
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rng = new Random();
			int kiekReikiaSkaiciu = rng.Next(21);
			List<int> Pazymiai = new List<int>();
			for (int i = 0; i < kiekReikiaSkaiciu ; i++)
			{
				Pazymiai.Add(rng.Next(1, 11));
			}
			Console.WriteLine("Didziausias skaicius yra:" + Pazymiai.Max());
			Console.WriteLine("Maziausias skaicius yra:" + Pazymiai.Min());
			Console.WriteLine("Vidurikis" + Pazymiai.Average());
			Console.WriteLine("Paskutinis pazymys" + Pazymiai.First());
			Console.WriteLine("Pirmas pazymys" + Pazymiai.Last());
			Console.WriteLine("Viso:" + Pazymiai.Count);
		}
	}
}
