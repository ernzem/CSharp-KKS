using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uz_1
{
	class Gyvunas
	{
		public string Vardas { get; set; }
		public int Amzius { get; set; }
		private string Spalva { get; set; }
		protected double Greitis { get; set; }



		public Gyvunas(string vardas)
		{
			Vardas = vardas;
		}

		public Gyvunas(int amzius)
		{ 
		
		}

		//Virtualus metodas
		public virtual void VirtualusMetodas()
		{
			Console.WriteLine("Iskiveciamas virtualus metodas");
		}
	}

	class Suo : Gyvunas
	{
		public Suo(string var) : base(var)
		{
			Greitis = 10;
		}
	}

	class Kate : Gyvunas
	{
		public Kate(string var) : base(var)
		{

		}
		public override void VirtualusMetodas()
		{
			Console.WriteLine("Nauja zinute");
		}
	}

	class Ozys : Gyvunas

	{
		public Ozys(string var) : base(var)
		{

		}
	}

	class Dramblys : Gyvunas

	{
		public Dramblys(string var) : base(var)
		{

		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			List<Gyvunas> gyviai = new List<Gyvunas>();
			gyviai.Add(new Suo() { Vardas = "Reksiukas" });
			gyviai.Add(new Kate() { Vardas = "Kaciukas" });
			gyviai.Add(new Ozys() { Vardas = "Oziukas" });
			gyviai.Add(new Dramblys() { Vardas = "Drambliukas" });

			foreach (var item in gyviai)
			{
				Console.WriteLine(item.Vardas);
			}
			
		}
	}
}
