using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
	class Program
	{
		// Parašykite programą, kuri suskaičiuotų, kiek yra keturženklių skaičių, kurių pirmųjų dviejų skaitmenų suma yra lygi likusių 
		// dviejų skaitmenų sumai, ir išvestų juos į ekraną.
		// Pasitikrinkite.Jų yra 615.
		static void Main(string[] args)
		{
			List<int> answerList = new List<int>();

			for (int first = 1; first <= 9; first += 1)
			{
				for (int second = 0; second <= 9; second += 1)
				{
					for (int third = 0; third <= 9; third += 1)
					{
						for (int fourth = 0; fourth <= 9; fourth += 1)
						{
							if (first + second == third + fourth)
							{
								int intAnswer = Convert.ToInt32(string.Format("{0}{1}{2}{3}", first, second, third, fourth));
								answerList.Add(intAnswer);
							}

						}

					}
				}
			}
			Console.WriteLine("Total number of digits: {0}", answerList.Count);
		}
	}
}
