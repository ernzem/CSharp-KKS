using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_pvz
{
	class A
	{
		public string Tekstas { get; set; }
		public int Skaicius { get; set; }

		public void Metodas()
		{
			Console.WriteLine(Tekstas + Skaicius);
		}
	}

	class B : A
	{ 
		public double Elementas { get; set; }
	
	}

	class C : A
	{ 
		public char Raide { get; set; }
	}

	class D : B
	{ 
		public DateTime Šiandiena { get; set; }
	
	}
	class Program
	{
		static void Main(string[] args)
		{
			A a = new A();
			C objektas = new C();
			B ele = new B();
			objektas.Tekstas = "";
			ele.Skaicius = 99;
			a = new B() { Elementas = 657 }; 


			//Polymorphism
			A bazinesKlasesElementas = new A();
			bazinesKlasesElementas = new B();
			bazinesKlasesElementas = new C();
			bazinesKlasesElementas = new D();

			// Kastinimas
			Console.WriteLine(((B)a).Elementas)
			ManoMetodas(a);
			ManoMetodas(new D());
			ManoMetodas(ale);

		}

		private static void ManoMetodas()
	}
}
