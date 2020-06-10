using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodai_su_grazinimu_uz_1
{
	class Program
	{

		public static string RomSkaicius(int sk)
		{
			int ssk = sk;
			string rom = "";
			while (ssk > 0)
			{
				int skaitmuo = ssk % 10;
				if (skaitmuo == 1)
				{ 
					
				}
			}	
			
				
				return Convert.ToString(rom);
		}



		static void Main(string[] args)
		{
			Console.WriteLine("Ivesti skaiciu");
			int sk = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine(RomSkaicius(sk));
		}
	}
}
