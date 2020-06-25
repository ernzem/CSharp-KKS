using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _2
{
	class Program
	{
		static void Main(string[] args)
		{
			// Parašykite funkciją, kuri konvertuotų žodinį kintamąjį “žodis” 
			// į sveikąjį skaičių ir priskirtų jį sveikajam kintamajam a.

			Console.WriteLine("Ivesti fraze \"žodis\"");
			string žodis = Console.ReadLine();
			int a = Int32.Parse(žodis);
		}
	}
}
