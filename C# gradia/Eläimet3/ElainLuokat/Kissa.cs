using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ElainLuokat;

namespace Elainluokat
{
    public class Kissa         // Luokka Kissa
    {
        private int Ika;            // attribuutit
        public string Nimi;

        public Kissa()          // Konstruktori ilman parametrejä
        {
            Nimi = "Miuku";         // aseta kissalle oletusnimi "Miuku" ja oletus ikä 0
            Ika = 0;
        }
        public bool AsetaKissanIka(int uusi_ika)
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
        public bool AsetaKissanNimi(string uusiNimi)
        {
            if (uusiNimi.ToLower() != "hilda")      // Jos uusi nimi ei ole hilda (muutettu pieniksi kirjaimiksi)
            {
                Nimi = uusiNimi;                    // nimi on uusiNimi
                return true;                        // palauttaa TRUE
            }
            else
            {
                return false;                       // muuten palauttaa FALSE
            }
        }
        public Kissa(int Ika, string Nimi)
        {
            this.Ika = Ika;
            this.Nimi = Nimi;
        }
        public string PalautaKissanNimi()
        {
            return Nimi;
        }
        public int PalautaKissanIka()
        {
            return Ika;
        }
        // ToString() metodi palauttaa tekstimuotoisen esityksen oliosta. Override määritteen avulla voimme korvata perityn metodin itse määritettyllä
        public override string ToString()
        {
            return ($"Kissan nimi on:{this.Nimi}, ikä { this.Ika}");
        }

    }
}