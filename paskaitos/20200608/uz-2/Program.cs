using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uz_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Kuro bako talpa:");
			double keliones_kuras = Convert.ToDouble(Console.ReadLine());
			
			Console.WriteLine("Suvartojimas lyginėmis dienomis:");
			double kuro_vartojimas = Convert.ToDouble(Console.ReadLine());

			int diena = 0;
			while (keliones_kuras > 0)
			{
				diena++;
				if (diena % 2 != 0)
				{
					keliones_kuras = keliones_kuras - (2 * kuro_vartojimas);
				}
				else
				{

					keliones_kuras = keliones_kuras - kuro_vartojimas;
				}

			}
			Console.WriteLine("Kelione truks {0} dienas.", diena);
		}
	}
}
