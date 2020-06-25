using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace masyvai_uz3
{
	class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			string path = "";

			using (OpenFileDialog ofd = new OpenFileDialog())
			{
				ofd.Filter = "*.txt | *.txt";
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					path = ofd.FileName;
				}
			}

				StreamReader reader = new StreamReader(path);
			string[] kandidatai = reader.ReadLine().Split(' ');
			reader.Close();
			int maxRaidziuKiekis = 0;
			int laimetojas = -1;
			for (int l = 0; l < kandidatai.Length; l++)
			{
				int raides = KiekisUnikaliuRaidziu(kandidatai[l].ToLower().ToCharArray());
				if (raides > maxRaidziuKiekis)
				{
					maxRaidziuKiekis = raides;
					laimetojas = l;
				}
			}
			Console.WriteLine("Laimetojas - {0} ", kandidatai[laimetojas]);
		}



		public static int KiekisUnikaliuRaidziu(char[] raides)
		{
			int kiekisUnikaliuRaidziu = 0;
			for (int i = 0; i < raides.Length; i++)
			{
				bool unikaliRaide = true;
				for (int j = 0; j < raides.Length; j++)
				{
					if (raides[i] == raides[j])
					{
						unikaliRaide = false;
						break;
					}
				}

				if (unikaliRaide)
				{
					kiekisUnikaliuRaidziu++;	
				}
			}
			return kiekisUnikaliuRaidziu;
		}


	}
}
