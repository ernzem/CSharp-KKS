using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace uz_romeniski_skaiciai
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ivesti skaiciu");
			int sk = Convert.ToInt32(Console.ReadLine());

			int tukst = sk / 1000;
			int simtai = sk / 100 % 10;
			int desimtys = sk / 10 % 10;
			int vienetai = sk % 10;


			string ats = RomSkaiciai(tukst);
			ats += RomSkaiciai(simtai);
			ats += RomSkaiciai(desimtys);
			ats += RomSkaiciai(vienetai, "I", "V", "X");
			Console.WriteLine(ats);
		}

		public static string RomSkaiciai(int sk, string vnt, string penki, string desimt)
		{
			// 1 - I
			// 2 - II  = > 1 + 1
			// 3 - III  = > 2 + 1
			// 4 - IV
			// 5 - V
			// 6 - VI  = > 5 + 1
			// 7 - VII = > 5 + 2
			// 8 - VIII = > 5 + 3
			// 9 - IX

			if (sk == 4)
			{
				return "IV";
			}
			else if (sk == 9)
			{
				return "IX";
			}
			else
			{
				string atsakymas = "";
				int arReikia5 = sk / 5;
				if (arReikia5 == 1)
				{
					atsakymas += "V";
				}
				int vienetuSkaicius = sk % 5;
				for (int i = 0; i < vienetuSkaicius; i++)
				{
					atsakymas += "I";
				}
				return atsakymas;
			}
		}
	}
}
