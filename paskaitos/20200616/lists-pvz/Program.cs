using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lists_pvz
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> pavadinimas = new List<int>();

			pavadinimas.Add(5);
			pavadinimas.Add(5);
			pavadinimas.Add(6);
			pavadinimas.Add(25);

			foreach (int elementasSarase in pavadinimas)
			{
				Console.WriteLine(elementasSarase);
			}
			pavadinimas.Remove(5); // pasalina pirma rasta penketa.

			foreach (int elementasSarase in pavadinimas)
			{
				Console.WriteLine(elementasSarase);
			}

			pavadinimas.Clear();
		}
	}
}
