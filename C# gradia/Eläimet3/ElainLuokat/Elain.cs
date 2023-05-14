using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ElainLuokat
{
    public class Elain
    {
        private int Ika;            // attribuutit
        public string Nimi;
        private bool OnLihanSyoja;              // on joko True tai False

        public Elain()          // Konstruktori ilman parametrejä
        {
            this.Nimi = "";         // aseta oletusnimi ja oletus ikä
            this.Ika = 0;
            this.OnLihanSyoja = true;
        }
        public Elain(int Ika, string Nimi, bool lihansyoja)   // Parametrillinen Konstruktori
        {
            this.Ika = Ika;
            this.Nimi = Nimi;
            this.OnLihanSyoja= lihansyoja;
        }
        public void AsetaElaimenIka(int uusi_ika)
        {
            if (uusi_ika > 0)           // Jos ikä suurempi kuin nolla
            {
                this.Ika = uusi_ika;        // Ikä on uusi ikä
            }
            else
            {
                Console.WriteLine("Ikä ei voi olla Negatiivinen!");
            }
        }
        public void AsetaElaimenNimi(string uusiNimi)
        {
            this.Nimi = uusiNimi;

        }
        public int PalautaElaimenIka()
        {
            return Ika;
        }
        public string PalautaElaimenNimi()
        {
            return Nimi;
        }
        public void AsetaOnlihanSyoja(bool lihansyoja)
        {
            
            this.OnLihanSyoja = lihansyoja;
        }
        public bool PalautaOnLihansyoja()
        {
            return this.OnLihanSyoja;
        }

    }
}