using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klaidos
{
	class Program
	{
		class ManoKlase
		{
			public void MetodasA(int skaicius)
			{
				if (skaicius == 0)
				{
					throw new ArgumentException("asdasdasd");
				}
			}
		}
		static void Main(string[] args)
		{
			try
			{

				int skaicius = 0;
				ManoKlase mano = new ManoKlase();
				mano.MetodasA(skaicius);
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message);
			}
			finally
			{
				Console.WriteLine("Pabaiga programos");
			}

		}
	}
}
