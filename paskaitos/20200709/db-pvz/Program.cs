using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace db_pvz
{
	class Program
	{
		static void Main(string[] args)
		{
			string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Desktop\CSharp-Kaunas-Coding-School\paskaitos\20200709\db-pvz\Database1.mdf;Integrated Security=True";
			SqlConnection connection = new SqlConnection(connectionString);
			string querry = "INSERT INTO PREKE(Pavadinima, Kaina) Values(@Pavadinima, @Kaina)";
			SqlCommand command = new SqlCommand(querry, connection);
			Console.WriteLine("Ivesti prekes pavadinima");
			command.Parameters.AddWithValue("@Pavadinima", Console.ReadLine());
			Console.WriteLine("Ivesti prekes kaina");
			command.Parameters.AddWithValue("@Kaina", Convert.ToDouble(Console.ReadLine()));

			connection.Open();
			int result = command.ExecuteNonQuery();
			if (result < 0)
			{
				Console.WriteLine("Klaida");
			}
			else
			{
				Console.WriteLine("Uzklausa igyvendinta");
			}
			{

			}
		}
	}
	private static void NaujoIrasoGeneravimas()
	{ 
	
	}
}
