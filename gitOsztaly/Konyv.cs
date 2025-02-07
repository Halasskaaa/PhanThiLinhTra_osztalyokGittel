using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitOsztaly
{
	internal class Konyv
	{
		private string cim;
		private string szerzo;
		private int kiadasEve;
		private int oldalszam;
		private int ar;
		
		// konyv.Cim - A saját könyv.Cia = "A sajt"
		// konyv.Cim = "Cim"
		public string Cim { get => cim; set => cim = value; }
		public string Szerzo { get => szerzo; set => szerzo = value; }
		public int KiadasEve { get => kiadasEve; set => kiadasEve = value; }
		public int Oldalszam { get => oldalszam; set => oldalszam = value; }
		public int Ar { get => ar; set => ar = value; }

		public Konyv(string cim, string szerzo, int kiadasEve, int oldalszam, int ar)
		{
			this.cim = cim;
			this.szerzo = szerzo;
			this.kiadasEve = kiadasEve;
			this.oldalszam = oldalszam;
			this.ar = ar;
		}
			
		public Konyv(string cim, string szerzo)
		{
			this.cim = cim;
			this.szerzo = szerzo;
			kiadasEve = DateTime.Now.Year;
			ar = 3000;
		}

		public void Arnoveles(int osszeg)
		{
			ar += osszeg;
		}
		public void Kezdvezmeny(double szazalek)
		{
			int csokkentes = Convert.ToInt16(ar * (szazalek/ 100));
		}
		public int HanyOldalMaradt(int elolvasott)
		{
			return oldalszam - elolvasott;
		}

		public override string ToString()
		{
			return $"Címe: {cim}, Szerző: {szerzo}, Oldalszám: {oldalszam}, Ár: {ar}";
		}
	}

}
