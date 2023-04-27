using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elaimet
{
    class Pilli         // Luo projektiin luokka nimeltä Pilli
    {
        private String _aani;   // Lisää luokalle oliomuuttuja private String _aani
        public Pilli(String pillinAani)     // Luo tämän jälkeen konstruktori public Pilli(String pillinAani), jonka avulla luodaan uusi pilli, jolle annetaan ääni
        {
            _aani = pillinAani;
        }
        public void Soi()       // Lisää pillille vielä metodi public void Soi(), joka tulostaa pillin äänen
        {
            Console.WriteLine(_aani);
        }
    }
}

