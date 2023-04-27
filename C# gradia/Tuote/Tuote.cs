using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kauppa
{
    class Tuote         // Luo projektiin luokka Tuote, joka esittää kaupan tuotetta
    {                   // Tuotteella tulee olla hinta (double), lukumäärä (int) ja nimi (String).
        public double hinta;
        public int lukumaara;
        public string nimi;

        public Tuote(String nimiAlussa, double hintaAlussa, int maaraAlussa)        // Konstruktori public Tuote(String nimiAlussa, double hintaAlussa, int maaraAlussa) 
        {
            nimi = nimiAlussa;
            hinta = hintaAlussa;
            lukumaara = maaraAlussa;
        }
        public void TulostaTuote()          // Metodi public void TulostaTuote() joka tulostaa tuotteen tiedot
        {
            Console.WriteLine($"{nimi}, Hinta: {hinta} euroa, {lukumaara} kpl.");        // Esimerkkitulostus Banaani, hinta 1.1, 13 kpl

        }
    }
}

