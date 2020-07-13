using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parduotuve;


namespace UnitTestProject1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void DetiIKrepseli_VienaPrekeVienasVienetas_Tikimasi_4Eur99Cnt()
		{
			// Inicijuoti klases
			Krepselis Shop = new Krepselis(@"UnitTesting-DB-Products.csv", ',');
			Shop.TurimuProduktuSarasas();

			// Testo veiksmai
			Shop.DetiIKrepseli("1", 1);

			// palyginti reiksmes
			Assert.AreEqual(4.99, Shop.KrepselioSuma);
		}

		[TestMethod]
		public void DetiIKrepseli_DuVienetai_Tikimasi_9Eur98Cnt()
		{
			// Inicijuoti klases
			Krepselis Shop = new Krepselis(@"UnitTesting-DB-Products.csv", ',');
			Shop.TurimuProduktuSarasas();

			// Testo veiksmai
			Shop.DetiIKrepseli("1", 2);

			// palyginti reiksmes
			Assert.AreEqual(9.98, Shop.KrepselioSuma);
		}

		[TestMethod]
		public void DetiIKrepseli_DuTokiePatysPasirinkimaiSkirtingiKiekiai_Tikimasi_14Eur97Cnt()
		{
			// Inicijuoti klases
			Krepselis Shop = new Krepselis(@"UnitTesting-DB-Products.csv", ',');
			Shop.TurimuProduktuSarasas();

			// Testo veiksmai
			Shop.DetiIKrepseli("1", 1);
			Shop.DetiIKrepseli("1", 2);

			// palyginti reiksmes
			Assert.AreEqual(14.97, Shop.KrepselioSuma);
		}

		[TestMethod]
		public void DetiIKrepseli_DuTokiePatysPasirinkimaiTokiePatysKiekiai_Tikimasi_9Eur98Cnt()
		{
			// Inicijuoti klases
			Krepselis Shop = new Krepselis(@"UnitTesting-DB-Products.csv", ',');
			Shop.TurimuProduktuSarasas();

			// Testo veiksmai
			Shop.DetiIKrepseli("1", 1);
			Shop.DetiIKrepseli("1", 1);

			// palyginti reiksmes
			Assert.AreEqual(9.98, Shop.KrepselioSuma);
		}

		[TestMethod]
		public void DetiIKrepseli_DuSkirtingiPasirinkimaiTokiepatysKiekiai_Tikimasi_5Eur19Cnt()
		{
			// Inicijuoti klases
			Krepselis Shop = new Krepselis(@"UnitTesting-DB-Products.csv", ',');
			Shop.TurimuProduktuSarasas();

			// Testo veiksmai
			Shop.DetiIKrepseli("1", 1);
			Shop.DetiIKrepseli("2", 1);

			// palyginti reiksmes
			Assert.AreEqual(5.19, Shop.KrepselioSuma);
		}

		[TestMethod]
		public void DetiIKrepseli_DuSkirtingiPasirinkimaiSkirtingiKiekiai_Tikimasi_10Eur18Cnt()
		{
			// Inicijuoti klases
			Krepselis Shop = new Krepselis(@"UnitTesting-DB-Products.csv", ',');
			Shop.TurimuProduktuSarasas();

			// Testo veiksmai
			Shop.DetiIKrepseli("1", 2);
			Shop.DetiIKrepseli("2", 1);

			// palyginti reiksmes
			Assert.AreEqual(10.18, Shop.KrepselioSuma);
		}

		[TestMethod]
		public void AtnaujintiSiuntosDydi_PrekesPasirinkimas_S_Tikimasi_S_Dydis()
		{
			// Inicijuoti klases
			Krepselis Shop = new Krepselis(@"UnitTesting-DB-Products.csv", ',');
			Shop.TurimuProduktuSarasas();

			// Testo veiksmai
			Shop.AtnaujintiSiuntosDydi("1");

			// palyginti reiksmes
			Assert.AreEqual('S', Shop.SiuntinioDydis);
		}

		[TestMethod]
		public void AtnaujintiSiuntosDydi__PrekesPasirinkimas_S_KaiKrepselisM_Tikimasi_M_Dydis()
		{
			// Inicijuoti klases
			Krepselis Shop = new Krepselis(@"UnitTesting-DB-Products.csv", ',');
			Shop.TurimuProduktuSarasas();

			// Testo veiksmai
			Shop.SiuntinioDydis = 'M';
			Shop.AtnaujintiSiuntosDydi("1");

			// palyginti reiksmes
			Assert.AreEqual('M', Shop.SiuntinioDydis);
		}

		[TestMethod]
		public void IvertintiSiuntosDydi_TusciasKrepselis_Tikimasi_0Eur00Cnt()
		{
			// Inicijuoti klases
			Krepselis Shop = new Krepselis(@"UnitTesting-DB-Products.csv", ',');
			Shop.TurimuProduktuSarasas();

			// Testo veiksmai
			Shop.SiuntinioDydis = ' ';
			Shop.PridetiSiuntosDydzioMokesti();

			// palyginti reiksmes
			Assert.AreEqual(0.00, Shop.KrepselioSuma);
		}

		[TestMethod]
		public void IvertintiSiuntosDydi_KrepselisM_Tikimasi_2Eur50Cnt()
		{
			// Inicijuoti klases
			Krepselis Shop = new Krepselis(@"UnitTesting-DB-Products.csv", ',');
			Shop.TurimuProduktuSarasas();

			// Testo veiksmai
			Shop.SiuntinioDydis = 'M';
			Shop.PridetiSiuntosDydzioMokesti();

			// palyginti reiksmes
			Assert.AreEqual(2.50, Shop.KrepselioSuma);
		}

		[TestMethod]
		public void PridetiSiuntimoMokesti_KrepselisTuscias_Tikimasi_0Eur00Cnt()
		{
			// Inicijuoti klases
			Krepselis Shop = new Krepselis(@"UnitTesting-DB-Products.csv", ',');
			Shop.TurimuProduktuSarasas();

			// Testo veiksmai
			Shop.SiuntimoTipas = 2;
			Shop.PridetiSiuntimoMokesti();

			// palyginti reiksmes
			Assert.AreEqual(0.00, Shop.KrepselioSuma);
		}

		[TestMethod]
		public void PridetiSiuntimoMokesti_PrekeKrepselyje_Tikimasi_7Eur99Cnt()
		{
			// Inicijuoti klases
			Krepselis Shop = new Krepselis(@"UnitTesting-DB-Products.csv", ',');
			Shop.TurimuProduktuSarasas();

			// Testo veiksmai
			Shop.DetiIKrepseli("1", 1);
			Shop.SiuntimoTipas = 2;
			Shop.PridetiSiuntimoMokesti();

			// palyginti reiksmes
			Assert.AreEqual(7.99, Shop.KrepselioSuma);
		}
	}
}
