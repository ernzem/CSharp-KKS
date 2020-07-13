using System;
using System.IO;

namespace DuomenuRasymasIrSkaitymas
{
	public interface IDuomenuRasymas
	{ 
		string failoKelias { get; }

		bool ArFailasExistuoja();

		void Rasyti(string eilute);
	}

	public interface IDuomenuSkaitymas
	{ 
		string failoKelias { get; }

		bool ArFailasEgzistuoja();

		string Skaityti();

		void RasytiNaujaFaila(string kelias, string tekstas);
		
	}

	class SkaitytiIsTxt : IDuomenuSkaitymas
	{
		public string failoKelias { get; }

		public SkaitytiIsTxt(string FailoKelias)
		{
			FailoKelias = failoKelias;
		}

		public bool ArFailasEgzistuoja(string FailoKelias)
		{
			if (System.IO.File.Exists(FailoKelias))
			{
				return true;
			}
			return false;
		}

		public void RasytiNaujaFaila(string kelias, string tekstas)
		{
			throw new NotImplementedException();
		}

		public string Skaityti(string FailoKelias)
		{
			using (StreamReader reader = new StreamReader(FailoKelias))
			{
				return reader.ReadToEnd();
			}
		}
		public void SkaitytiIrRasyti(string FailoKelias)
		{ 
		}
	}

	public class Class1
	{
	}
}
