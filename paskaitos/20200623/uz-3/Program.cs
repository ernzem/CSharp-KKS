using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uz_3
{
	class Darbuotojas
	{
		public double Atlyginimas { get; set; }

		public virtual double atlygis()
		{
			return Atlyginimas;
		}
	}

	class ValandinisDarbuotojas : Darbuotojas
	{
		public override 
	}

	class FiksuotoUzdarbioDarbuotojas : Darbuotojas
	{

	}

	class Vadovas : Darbuotojas
	{

	}

	class ImonesValdytojas : Darbuotojas
	{

	}


	class Program
	{
		static void Main(string[] args)
		{

		}
	}
}
