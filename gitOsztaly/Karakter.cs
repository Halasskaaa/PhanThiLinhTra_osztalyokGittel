using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitOsztaly
{
	internal class Karakter
	{
		private string nev;
		private int szint;
		private int eletero;
		private int ero;

		public string Nev { get => nev; set => nev = value; }
		public int Szint { get => szint; set => szint = value; }
		public int Eletero { get => eletero; set => eletero = value; }
		public int Ero { get => ero; set => ero = value; }

		public Karakter(string nev, int szint, int eletero, int ero)
		{
			this.nev = nev;
			this.szint = szint;
			this.eletero = eletero;
			this.ero = ero;
		}

		public Karakter(string nev, int ero)
		{
			this.nev = nev;
			szint = 1;
			eletero = 100;
			this.ero = ero;
		}

		public void Tamadas()
		{
			Console.WriteLine($"{nev} {ero} erővel támad.");
		}
		public int Gyogyulas(int mennyiseg)
		{
			return eletero += mennyiseg;
		}
		public void Szintlepes()
		{
			szint += 1;
			ero += 10;
			eletero += 100;
		}

		public override string ToString()
		{
			return $"Karakter neve:	{nev}, Szintje: {szint}, HP-ja: {eletero}, Ereje: {ero}";
		}
	}
}
