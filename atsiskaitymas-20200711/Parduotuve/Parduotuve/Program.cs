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
