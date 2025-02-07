using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitOsztaly
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Konyv konyv1 = new("A Kis Herceg", "Antoine de Saint-Exupéry", 1943, 96, 2500);
			Konyv konyv2 = new("Ez még készül", "Én");

            Console.WriteLine(konyv1.ToString() + "\n" + konyv2.ToString());

			konyv1.Kezdvezmeny(20);
			konyv1.Arnoveles(1000);

            Console.WriteLine("\n" + konyv1.ToString() + "\n" + konyv1.HanyOldalMaradt(20));

            Console.WriteLine();
			Console.WriteLine("------------------------------------------------------------");
			Console.WriteLine();

			Film film1 = new("Scream 1", "Wes Craven", 111, "Horror", true);
			Film film2 = new("Once upon a silent life", "Amy Stake");

			Console.WriteLine(film1.ToString() + "\n" + film2.ToString());

			film2.HosszNovelese(20);
			film2.MufajModositas("Thriller");

			Console.WriteLine("\n" + film2.ToString());

			Console.WriteLine();
			Console.WriteLine("------------------------------------------------------------");
			Console.WriteLine();


		}
	}
}
