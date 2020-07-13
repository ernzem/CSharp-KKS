using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;

namespace Parduotuve
{
	public class Parduotuve
	{
		public string Csv { get; set; }
		public char CsvSkirtukas { get; set; }
		public Dictionary<string, string> Prekes { get; set; }
		public Dictionary<string, double> Kainos { get; set; }
		public Dictionary<string, char> PrekiuDydis { get; set; }


		public Parduotuve(string csv, char csvSkirtukas)
		{
			Csv = csv;
			CsvSkirtukas = csvSkirtukas;
			Prekes = new Dictionary<string, string>();
			Kainos = new Dictionary<string, double>();
			PrekiuDydis = new Dictionary<string, char>();
		}

		public void TurimuProduktuSarasas()
		{
			using (StreamReader file = new StreamReader(Csv))
			{
				string ln;
				while ((ln = file.ReadLine()) != null)
				{
					string[] data = ln.Split(CsvSkirtukas).ToArray();
					Prekes.Add(data[0], data[1]);
					Kainos.Add(data[0], Convert.ToDouble(data[2]));
					PrekiuDydis.Add(data[0], Convert.ToChar(data[3]));

				}
			}
		}

		public void PateiktiPrekiuSarasa()
		{
			Console.WriteLine("Prekiu sarasas:\n");
			foreach (var key in Prekes.Keys)
			{
				Console.WriteLine("ID: {0}, {1} - {2}Eur", key, Prekes[key], Kainos[key]);
			}
		}

	}


	public class Krepselis : Parduotuve
	{
		public double KrepselioSuma { get; set; }
		public int SiuntimoTipas { get; set; }

		public List<char> DydziuEiliskumas { get; set; }
		public Dictionary<string, int> KrepselioTurinys { get; set; }
		public char SiuntinioDydis { get; set; }

		public Dictionary<int, double> SiuntimoKainos { get; set; }

		public Dictionary<char, double> SiuntinioDydzioKainos { get; set; }


		public Krepselis(string csv, char csvSkirtukas) : base(csv, csvSkirtukas)
		{
			KrepselioSuma = 0;
			SiuntimoTipas = 0;
			KrepselioTurinys = new Dictionary<string, int>();
			PrekiuDydis = new Dictionary<string, char>();
			SiuntimoKainos = new Dictionary<int, double>()
				{
					{1, 2.00},
					{2, 3.00},
					{3, 1.50},
					{4, 4.99}
				};
			SiuntinioDydis = ' ';
			DydziuEiliskumas = new List<char>() { ' ', 'S', 'M', 'L' };
			SiuntinioDydzioKainos = new Dictionary<char, double>()
			{
				{'S', 0.00},
				{'M', 2.50},
				{'L', 10.00}
			};
		}

		public void Pirkti()
		{
			string id = "0";
			while (id != "")
			{
				Console.WriteLine("\nPasirinkti prekę įvedant prekes id. Nurint baigti pasirinkimus spausti \"ENTER\":");
				id = Console.ReadLine();
				bool keyExists = Prekes.ContainsKey(id);
				if (id == "")
				{
					break;
				}
				else if (!keyExists)
				{
					Console.WriteLine("Neteisingai ivestas prekes {0}. Bandykite dar karta:", id);
				}
				else
				{
					Console.WriteLine("Iveskite norima kieki vienetais:");
					int kiekis = Convert.ToInt32(Console.ReadLine());
					DetiIKrepseli(id, kiekis);
					AtnaujintiSiuntosDydi(id);
				}

			}
			PridetiSiuntosDydzioMokesti();
			GautiSiuntimoPasirinkimą();
			PridetiSiuntimoMokesti();
		}

		public void DetiIKrepseli(string id, int kiekis)
		{
			bool KeyInKrepselis = KrepselioTurinys.ContainsKey(id);
			if (KeyInKrepselis)
			{
				KrepselioTurinys[id] += kiekis;
				KrepselioSuma += (Kainos[id] * kiekis);
			}
			else
			{
				KrepselioTurinys.Add(id, kiekis);
				KrepselioSuma += (Kainos[id] * kiekis);
			}

		}

		public void AtnaujintiSiuntosDydi(string id)
		{
			int PrekesDydis = DydziuEiliskumas.IndexOf(PrekiuDydis[id]);
			int DidiziausiaKrepselioPreke = DydziuEiliskumas.IndexOf(SiuntinioDydis);
			if (PrekesDydis > DidiziausiaKrepselioPreke)
			{
				SiuntinioDydis = PrekiuDydis[id];
			}
		}

		public void PridetiSiuntosDydzioMokesti()
		{
			if (SiuntinioDydis != ' ')
			{
				KrepselioSuma += SiuntinioDydzioKainos[SiuntinioDydis];
			}
		}

		public void GautiSiuntimoPasirinkimą()
		{
			Console.WriteLine("Pasirinkti siuntimo buda ivedant pasirinkimo skaiciu:");
			Console.WriteLine("1. Pastu i namus");
			Console.WriteLine("2. Per Kurjeri");
			Console.WriteLine("3. I pastomata");
			Console.WriteLine("4. Tarptautinis siuntimas");
			SiuntimoTipas = Convert.ToInt32(Console.ReadLine());
		}

		public void PridetiSiuntimoMokesti()
		{
			if (KrepselioTurinys.Count != 0)
			{
				KrepselioSuma += SiuntimoKainos[SiuntimoTipas];
			}
		}

		public void KrepselioSantrauka()
		{
			if (KrepselioTurinys.Count != 0)
			{
				Console.WriteLine("\nKrepselio Santrauka:");
				foreach (var item in KrepselioTurinys)
				{
					Console.WriteLine("{0} ({1} vnt.). Vieneto kaina: {2} Eur.",
						Prekes[item.Key],
						KrepselioTurinys[item.Key],
						Kainos[item.Key]);
				}
				Console.WriteLine("Siuntimo Kaina {0} Eur.", SiuntimoKainos[SiuntimoTipas]);
				Console.WriteLine("Siuntos dydzio Mokestis {0} Eur.", SiuntinioDydzioKainos[SiuntinioDydis]);
				Console.WriteLine("Bendra suma: {0} Eur.\n", KrepselioSuma);
			}
		}
	}

	class Program
    {
        static void Main(string[] args)
        {
            Krepselis PrekybosCentras = new Krepselis("DB-Products.csv", ',');
            PrekybosCentras.TurimuProduktuSarasas();
            PrekybosCentras.PateiktiPrekiuSarasa();
            PrekybosCentras.Pirkti();
			PrekybosCentras.KrepselioSantrauka();
        }
    }
}
