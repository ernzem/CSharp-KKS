using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uz_1
{
    class ValstybesIrKiekiai
    {
        public string[] Miestai;
        public string[] Valstybes;

        public ValstybesIrKiekiai(string[] miestai, string[] valstybes)
        {
            Miestai = miestai;
            Valstybes = valstybes;
        }

        public List<string> Gauti_Unikaliu_Valstybiu_Sarasa()
        {
            List<string> Skirtingos_Valstybes = new List<string>(); 
			foreach (var valstybe in Valstybes)
			{
                if (!Skirtingos_Valstybes.Contains(valstybe))
                {
                    Skirtingos_Valstybes.Add(valstybe);
                }
			}
            return Skirtingos_Valstybes;
        }

        public List<int> Valstybiu_Kiekiai(List<string> Skirtingos_Valstybes)
        {
            List<int> Kiekis = new List<int>();
            for (int i = 0; i < Skirtingos_Valstybes.Count; i++)
            {
                Kiekis.Add(0);
                foreach (var valstybe in Valstybes)
                {
                    if (Skirtingos_Valstybes[i] == valstybe)
                    {
                        Kiekis[i]++;
                    }
                }
            }
            return Kiekis;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var duomenys = NuskaitytiDuomenys();
            string[] miestai = new string[duomenys.Count];
            string[] valstybes = new string[duomenys.Count];
            for (int i = 0; i < duomenys.Count; i++)
            {
                AtskirtiDuomenuEilute(duomenys[i], out miestai[i], out valstybes[i]);
            }

            for (int i = 0; i < duomenys.Count; i++)
            {
                Console.WriteLine(miestai[i] + " - " + valstybes[i]);
            }

            ValstybesIrKiekiai ats = new ValstybesIrKiekiai(miestai, valstybes);
            List<string> Skirtingos_Valstybes = ats.Gauti_Unikaliu_Valstybiu_Sarasa();
            List<int> Kiekiai = ats.Valstybiu_Kiekiai(Skirtingos_Valstybes);

            for (int i = 0; i < Skirtingos_Valstybes.Count; i++)
            {
                Console.WriteLine("Valstybeje {0} yra {1} miestu", Skirtingos_Valstybes[i], Kiekiai[i]);
            }

        }




        private static void AtskirtiDuomenuEilute(string eilute, out string miesta, out string valstybe)
        {
            var atskirti = eilute.Split(' ');
            miesta = atskirti[0];
            valstybe = atskirti[1];
        }

        private static List<string> NuskaitytiDuomenys()
        {
            System.IO.StreamReader reader = new System.IO.StreamReader("miestai.txt");
            List<string> duomenys = new List<string>();
            while (reader.Peek() >= 0)
            {
                duomenys.Add(reader.ReadLine());
            }
            reader.Close();
            return duomenys;
        }
    }
}
