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

            film1.Jatszas();

			Console.WriteLine("\n" + film2.ToString());

			Console.WriteLine();
			Console.WriteLine("------------------------------------------------------------");
			Console.WriteLine();

			Karakter karakter1 = new("Myers", 100, 10000, 100000);
			Karakter karakter2 = new("Laurie Strode", 200);

            Console.WriteLine("\n" + karakter1.ToString() + "\n" + karakter2.ToString());

			karakter2.Tamadas();
			karakter1.Gyogyulas(5000);
			karakter2.Szintlepes();

            Console.WriteLine(karakter2 + "\n" + karakter1);

			Console.WriteLine();
			Console.WriteLine("------------------------------------------------------------");
			Console.WriteLine();

			Urhajo urhajo1 = new("XYZ-134", 200, 40, 65);
			Urhajo urhajo2 = new("Legion", 50);

            Console.WriteLine("\n" + urhajo1.ToString() + "\n" + urhajo2.ToString());

			urhajo2.Indulas();
			urhajo1.Tankolas(21);
			urhajo1.Landolas();

			Console.WriteLine("\n" + urhajo1.ToString() + "\n" + urhajo2.ToString());

		}
	}
}
