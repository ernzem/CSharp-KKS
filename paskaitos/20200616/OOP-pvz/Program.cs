using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_pvz
{
	class Program
	{
		class Automobilis
		{
			public string Marke;
			public string Gamintojas;
			public int GamybosMetai;
			public int Rida;
			private string Spalva;


			public double RidaPerMetus()
			{
				return (double)Rida / (DateTime.Today.Year - GamybosMetai);
			}

			public Automobilis(string Gamintojas, string marke, int gamybosMetus, int Rida)
			{
				Marke = marke;
				GamybosMetai = gamybosMetus;
				this.Gamintojas = Gamintojas;
				this.Rida = Rida;
			}
		}


		static void Main(string[] args)
		{
			Automobilis auto = new Automobilis("Audi", "A4", 2005, 195000);
			Console.WriteLine(auto.Gamintojas);
				
		}
	}
}
