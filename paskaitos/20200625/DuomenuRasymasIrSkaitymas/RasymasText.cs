using System;
using System.IO;

namespace DuomenuRasymasIrSkaitymas
{
	public class RasymasText : IDuomenuRasymas
	{
		public string FailoKelias => throw new NotImplementedException();

		public bool ArFailasExistuoja()
		{
			if (File.Exists(FailoKelias))
			{
				return true;
			}
			return false;
		}

		public void Rasyti(string eilute)
		{
			using (StreamWriter writer = new StreamWriter(FailoKelias))
			{

			}
		}
	}
}
