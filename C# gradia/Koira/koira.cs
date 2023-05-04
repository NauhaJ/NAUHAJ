using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace koira
{
    public class Koira         // Luokka Koira
    {
        private int Ika;            // attribuutit
        public string Nimi;

        public Koira()          // Konstruktori ilman parametrejä
        {
            Nimi = "Haukkuli";         // aseta koiralle oletusnimi "Haukkuli" ja oletus ikä 0
            Ika = 0;
        }
        public bool AsetaKoiranika(int uusi_ika)
        {
            if (uusi_ika > 0)           // Jos ikä enemmän kuin nolla
            {
                this.Ika = uusi_ika;        // Ikä on uusi ikä
                return true;                // palauttaa arvon TRUE
            }
            else
            {
                return false;               // muuten palauttaa arvon FALSE
            }
        }
        public bool AsetaKoiranNimi(string uusiNimi)
        {
            if (uusiNimi.ToLower() != "musti")      // Jos uusi nimi ei ole musti (muutettu pieniksi kirjaimiksi)
            {
                Nimi = uusiNimi;                    // nimi on uusiNimi
                return true;                        // palauttaa TRUE
            }
            else
            {
                return false;                       // muuten palauttaa FALSE
            }
        }
        public Koira(int Ika, string Nimi)
        {
            this.Ika = Ika;
            this.Nimi = Nimi;
        }
        public string PalautaKoiranNimi()
        {
            return Nimi;
        }
        public int PalautaKoiranIka()
        {
            return Ika;
        }
        // ToString() metodi palauttaa tekstimuotoisen esityksen oliosta. Override määritteen avulla voimme korvata perityn metodin itse määritettyllä
        public override string ToString()
        {
            return ($"Koiran nimi on:{this.Nimi}, ikä {this.Ika}");
        }

    }
}