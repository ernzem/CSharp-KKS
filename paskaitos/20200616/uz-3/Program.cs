using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uz_3
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] vardu_masyvas = {"Tadas", "Vladas", "Matas"};

			Random rng = new Random();
			int list_size = rng.Next(1, 10);

			List<string> vardai_listas = new List<string>();
			for (int i = 0; i < list_size; i++)
			{
				vardai_listas.Add(vardu_masyvas[rng.Next(vardu_masyvas.Length)]);
			}

			foreach (string item in vardai_listas)
			{
				Console.WriteLine(item);
			}
		}
	}
}
