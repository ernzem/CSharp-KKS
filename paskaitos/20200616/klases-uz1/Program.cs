using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klases_uz1
{
	class Program
	{
		class Vartotojas
		{
			public string Vardas;
			public string Pavarde;
			public string Email;
			public DateTime GimimoData;
			public string Slaptazodis;
			public int PrisijungimuSkaicius;

			public Vartotojas(string vardas, string pavarde, string email, DateTime gimimodata, string slaptazodis, int prisijungimu_skaicius)
			{
				Vardas = vardas;
				Pavarde = pavarde;
				Email = email;
				GimimoData = gimimodata;
				Slaptazodis = slaptazodis;
				PrisijungimuSkaicius = prisijungimu_skaicius;
			}
		}
		static void Main(string[] args)
		{
		}
	}
}
