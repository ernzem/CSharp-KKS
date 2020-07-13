using System;
using TestavimoUzduotis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestSkaiciuotuvas
{
	[TestClass]
	public class Skaiciuotuvas_UnitTest
	{
		[TestMethod]
		public void Sudeti_TikimasiGautiPenkis()
		{
			// Susikuriami visi reikalingi testui kintamieji
			Skaiciuotuvas skaiciuotuvas = new Skaiciuotuvas();

			// Atliekami visi testo veiksmai
			var rezultatas = skaiciuotuvas.Sudeti(2, 3);

			// Patikrinama testo salyga
			Assert.AreEqual(5, rezultatas);
		}

		[TestMethod]
		public void Atimit_TikimasiGautiTris()
		{
			Skaiciuotuvas skaiciuotuvas = new Skaiciuotuvas();
			var rezultatas = skaiciuotuvas.Atimti(9, 3);
			Assert.AreEqual(3, rezultatas);
		}
		
		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void Atimti_TikimasiDalybaIsNulioNegalima()
		{
			Skaiciuotuvas skaiciuotuvas = new Skaiciuotuvas();
			skaiciuotuvas.Atimti(10, 0);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void PridetiLimitus_Tikimasi_X_UzApibreztoLimito()
		{
			Skaiciuotuvas skaiciuotuvas = new Skaiciuotuvas();
			skaiciuotuvas.PridetiLimitus(11, 3, 0, 10);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void PridetiLimitus_Tikimasi_Y_UzApibreztoLimito()
		{
			Skaiciuotuvas skaiciuotuvas = new Skaiciuotuvas();
			skaiciuotuvas.PridetiLimitus(8, 12, 0, 10);
		}


		[TestMethod]
		public void PridetiLimitus_TikimasiSumaDvylika()
		{
			Skaiciuotuvas skaiciuotuvas = new Skaiciuotuvas();
			var rezultatas = skaiciuotuvas.PridetiLimitus(7, 5, 0, 10);
			Assert.AreEqual(12, rezultatas);
		}
	}
}
