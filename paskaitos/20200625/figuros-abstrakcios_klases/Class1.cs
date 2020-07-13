using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuros_abstrakcios_klases
{
	abstract class Figura
	{
		public abstract double Plotas();
		public abstract double Perimetras();
	}

	class Trikampis : Figura
	{
		public double c { get; set; }
		public double a { get; set; }
		public double b { get; set; }

		public override double Plotas()
		{
			return (a * b) / 2;
		}
		public override double Perimetras()
		{
			return (a + b +c);
		}

	}

	class Staciakampis : Figura
	{
		public double a { get; set; }
		public double b { get; set; }

		public override double Plotas()
		{
			return a * b;
		}

		public override double Perimetras()
		{
			return a + b + a + b;
		}

	}

}
