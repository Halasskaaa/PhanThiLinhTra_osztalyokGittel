using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitOsztaly
{
	internal class KemKuldetes
	{
		private string kodnev;
		private string orszag;
		private int veszelySzint;
		private int sikerEsej;

        public string Kodnev { get => kodnev; set => kodnev = value; }
        public string Orszag { get => orszag; set => orszag = value; }
        public int VeszelySzint { get => veszelySzint; set => veszelySzint = value; }
        public int SikerEsej { get => sikerEsej; set => sikerEsej = value; }
   
		public KemKuldetes(string kodnev, string orszag, int veszelySzint, int sikerEsej)
		{
			this.kodnev = kodnev;
			this.orszag = orszag;
			this.veszelySzint = veszelySzint;
			this.sikerEsej = sikerEsej;
		}
		public KemKuldetes(string kodnev, string orszag)
		{
			this.kodnev = kodnev;
			this.orszag = orszag;
			veszelySzint = 5;
			sikerEsej = 50;
		}

		public void KuldetesInditasa()
		{
            Console.WriteLine($"A {kodnev} küldetés megkezdődött.");
        }
		public int VeszelySzintNovelese(int mennyiseg)
		{
			return veszelySzint += mennyiseg;
		}
		public int SikerEsejNovelese(int szazalek)
		{
			return sikerEsej += szazalek;
		}

		public override string ToString()
		{
			return $"Kódnév: {kodnev}, Ország: {orszag}, Veszélyszint: {veszelySzint}, Siker esélye: {sikerEsej}%";
		}
	}

}
