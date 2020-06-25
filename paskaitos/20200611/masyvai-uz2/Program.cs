using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masyvai_uz2
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] masyvas = new int[3];
			int maziausias = 0;
			int didziausia = 0;
			for (int i = 0; i < masyvas.Length; i++)
			{
				Console.WriteLine("Ivesti skaiciu");
				masyvas[i] = Convert.ToInt32(Console.ReadLine());
			}
			for (int i = 0; i < masyvas.Length; i++)
			{
				if (masyvas[i] < maziausias)
				{
					maziausias = masyvas[i];
				}
				if (masyvas[i] > didziausia)
					didziausia = masyvas[i];
				{

				}
			}
			Console.WriteLine(didziausia);
			Console.WriteLine(maziausias);
		}
	}
}
