using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Musiikki
{
    // Luo projektiin luokka nimeltä Musiikkikappale
    internal class Musiikkikappale
    {
        //  Musiikkikappaleella on oliomuuttujat nimi (merkkijono) ja pituus sekunteina (kokonaisluku)
        private string kappale_nimi = "";
        private int kappale_pituus = 0;

        // olemmat asetetaan konstruktorissa public Musiikkikappale(String kappaleenNimi, int kappaleenPituus)
        public Musiikkikappale(String kappaleenNimi, int kappaleenPituus)
        {
            this.kappale_nimi = kappaleenNimi;
            this.kappale_pituus = kappaleenPituus;
        }
        // Lisää oliolle myös metodi public string Nimi(), joka palauttaa kappaleen nimen
        public string Nimi()
        {
            return this.kappale_nimi;
        }
        // Lisää oliolle metodi public int Pituus(), joka palauttaa kappaleen pituuden.
        public int Pituus()
        {
            return this.kappale_pituus;
        }
    }
}
