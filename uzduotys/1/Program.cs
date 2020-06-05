using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
	class Program
	{
		static void Main(string[] args)
		{
			/* Parašykite programą, kuri apskaičiuotų, kiek popieriaus lapų k reikės norint nukopijuoti konspektą visos klasės mokiniams. 
			Žinoma kad klasėje yra m mokinių o konspektą sudaro n lapų. Pvz.: m=20, n=10, tai atsakymas 200. */
			
			Console.WriteLine("Įveskite konspekto lapų skaičių:");
			int n = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Įveskite konspekto lapų skaičių:");
			int m = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Viso puslapių nukopijuoti: {0}", m * n); 		
		}
	}
}
