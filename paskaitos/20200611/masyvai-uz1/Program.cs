using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masyvai_uz1
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] masyvas = {0, 8, 7, 6, 4, 3};
			Console.WriteLine(masyvas[0]);
			Console.WriteLine(masyvas[masyvas.Length-1]);


			int[] m = new int[6];
			m[0] = 1;
			m[1] = 2;
			m[2] = 3;





			Console.WriteLine("Ivesti skaicius juos atskiriant tarpu");
			string data = Console.ReadLine();
			string[] atskirtiDuomenys = data.Split(' ');
			string dd;
			Console.WriteLine(atskirtiDuomenys.Length);
			Console.WriteLine("Iveskite viena zodi");
			string zodis = Console.ReadLine();
			char[] raides = zodis.ToCharArray();

		}

	}
}
