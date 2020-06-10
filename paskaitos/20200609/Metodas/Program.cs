using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Metodas
{
	class Program
	{
		/// <summary>
		/// Pasisveikinimo programa
		/// </summary>
		public static void Pasisveikinti()
		{
			Console.WriteLine("Hello Word");
		}

		void Metodas()
		{ 
		
		}

		static void Main(string[] args)
		{
			Pasisveikinti();
			Program p = new Program();
			p.Metodas();
			Program.Pasisveikinti();
		}
	}
}
