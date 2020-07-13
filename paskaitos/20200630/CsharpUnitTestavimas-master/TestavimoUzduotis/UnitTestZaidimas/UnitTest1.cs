using System;
using TestavimoUzduotis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Collections.Generic;

namespace UnitTestZaidimas
{
	[TestClass]
	public class TekstoZaidimas_UnitTest
	{
		[TestMethod]
		[ExpectedException(typeof(PathTooLongException))]
		public void SaugotiTeksta_Tikimasi_PathTooLongException()
		{
			TekstoZadimas tekstoZadimas = new TekstoZadimas();
			// tekstoZadimas.SaugotiTeksta("");
			
		}
	}

	public class FakeTekstoZaidimas : ITekstoZadimas
	{
		public void SaugotiTeksta(string kelias, List<string> linijos)
		{
			SaugotiTeksta;
		}
	}
}
