﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace gitOsztaly
{
	internal class Urhajo
	{
		private string nev;
		private int sebesseg;
		private int utaskapacitas;
		private int uzemanyagSzint;

		public string Nev { get => nev; set => nev = value; }
		public int Sebesseg { get => sebesseg; set => sebesseg = value; }
		public int Utaskapacitas { get => utaskapacitas; set => utaskapacitas = value; }
		public int UzemanyagSzint { get => uzemanyagSzint; set => uzemanyagSzint = value; }

		public Urhajo(string nev, int sebesseg, int utaskapacitas, int uzemanyagSzint)
		{
			this.nev = nev;
			this.sebesseg = sebesseg;
			this.utaskapacitas = utaskapacitas;
			this.uzemanyagSzint = uzemanyagSzint;
		}
		public Urhajo(string nev, int utaskapacitas)
		{
			this.nev = nev;
			sebesseg = 0;
			this.utaskapacitas = utaskapacitas;
			uzemanyagSzint = 100;
		}

		public void Indulas()
		{
			sebesseg += 100;
			uzemanyagSzint -= 5;
		}
		public int Tankolas(int mennyiseg)
		{
			return uzemanyagSzint += mennyiseg;
		}
		public int Landolas()
		{
			return sebesseg = 0;
		}


		public override string ToString()
		{
			return $"Az űrhajó neve: {nev}, sebessége: {sebesseg}, utaskapacitása: {utaskapacitas}, üzemanyag szintje: {uzemanyagSzint}";
		}
	}
}
