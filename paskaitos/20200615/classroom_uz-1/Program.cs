using System.IO; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classroom_uz_1
{
	class Program
	{
		static void Main(string[] args)
		{
			var duomenys = NuskaitytiDuomenys();
			string[] miestai = new string[duomenys.Length];
			string[] valstybes = new string[duomenys.Length];
			for (int i = 0; i < duomenys.Length; i++)
			{
				AtskirtiMiestusSalis(duomenys[i], out miestai[i], out valstybes[i]);
			}
			for (int i = 0; i < duomenys.Length; i++)
			{
				Console.WriteLine(miestai[i] + " - " + valstybes[i]);
			}
		}


		private static void GautiAtsakyma(string[] vastybes)
		{
			string[] valstbiuAtranka = { valstybes[0] };
			int[] kiekisMistu = { 1 };

			for (int i = 0; i < valstybes.Length; i++)
			{ 
				
			}
		}

		private static void AtskirtiMiestusSalis(string eilute, out string miestai, out string valstybe)
		{
			var atskirti = eilute.Split(' ');
			miestai = atskirti[0];
			valstybe = atskirti[1];
		}

		private static string[] NuskaitytiDuomenys()
		{
			System.IO.StreamReader reader = new System.IO.StreamReader("miestai.txt");
			int kiekis = int.Parse(reader.ReadLine());
			string[] duomenys = new string[kiekis];
			for (int i = 0; i < kiekis; i++)
			{
				duomenys[i] = reader.ReadLine();

			}
			reader.Close();
			return duomenys;
		}
	}
}
