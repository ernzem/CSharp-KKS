using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
