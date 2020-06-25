using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
	class Program
	{
		static void Main(string[] args)
		{
			// Parašykite programą kuri turėtų prekių sąrašą
			// (sąrašą sugalvokite patys, sąraše turėtų būti bent 7 prekės.) 
			// programa turi sudaryti pirkinių sąrašą
			// ir pateikti kokia bus pilna apsipirkimo suma.

			double pieno_kaina = 1.05;
			double kavos_kaina = 4.99;
			double duonos_kaina = 1.29;
			double sviesto_kaina = 1.00;
			double surio_kaina = 2.29;
			double varskes_kaina = 3.00;
			double surelio_kaina = 0.70;

			Console.WriteLine("Pasirinkti produktus. Kiekvieną pasirinkimą atskirti tarpu:");
			Console.WriteLine("1 - Pienas {0} Eur", pieno_kaina);
			Console.WriteLine("2 - Kava {0} Eur", kavos_kaina);
			Console.WriteLine("3 - Duona {0} Eur", duonos_kaina);
			Console.WriteLine("4 - Sviestas {0} Eur", sviesto_kaina);
			Console.WriteLine("5 - Sūris {0} Eur", surio_kaina);
			Console.WriteLine("6 - Varškė {0} Eur", varskes_kaina);
			Console.WriteLine("7 - Sūrelis {0} Eur", surelio_kaina);

			char[] pasirinkimas = Console.ReadLine().ToCharArray();
			Console.WriteLine("\n\nPirkinių sąrašas:\n");
			double suma = 0;

			for (int i = 0; i < pasirinkimas.Length; i++)
			{

				switch (pasirinkimas[i])
				{
					case '1':
						Console.WriteLine(" - Pienas {0} Eur", pieno_kaina);
						suma += pieno_kaina;
						break;

					case '2':
						Console.WriteLine(" - Kava {0} Eur", kavos_kaina);
						suma += kavos_kaina;
						break;

					case '3':
						Console.WriteLine(" - Duona {0} Eur", duonos_kaina);
						suma += duonos_kaina;
						break;

					case '4':
						Console.WriteLine(" - Sviestas {0} Eur", sviesto_kaina);
						suma += sviesto_kaina;
						break;

					case '5':
						Console.WriteLine(" - Sūris {0} Eur", surio_kaina);
						suma += surio_kaina;
						break;

					case '6':
						Console.WriteLine(" - Varškė {0} Eur", varskes_kaina);
						suma += varskes_kaina;
						break;

					case '7':
						Console.WriteLine("7 - Sūrelis {0} Eur", surelio_kaina);
						suma += surelio_kaina;
						break;

					default:
						Console.WriteLine("Neatpažintas elementas");
						break;
				}
			}
			Console.WriteLine("\nIš viso: {0} Eur\n", suma);
		}
	}
}
