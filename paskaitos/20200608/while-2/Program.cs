using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace while_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Sugalvoti skaiciu esanti tarp 0 ir 3000:");

			bool teisingas_spejimas = false;
			int default_skaicius = 1500;
			while (teisingas_spejimas == false)
			{
				Console.WriteLine("Ar tai skaicius {0} ? \n Jei taip iveskite zodi \"taip\" \n jei skaicius didesnis ivesti \"didesnis\" \n jei skaiciuc mazesnis \"mazesnis\" ", default_skaicius);
				string ats = Convert.ToString(Console.ReadLine());
				if (ats == "didesnis")
				{
					default_skaicius++;
				}
				else if (ats == "mazesnis")
				{
					default_skaicius--;
				}
				else if (ats == "taip")
				{
					teisingas_spejimas = true;
				}
			}
			Console.WriteLine("Sugalvotas skaicius - {0}", default_skaicius);
		}
	}
}
