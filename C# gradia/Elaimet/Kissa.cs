using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elaimet
{
    class Kissa
    {
        private int Ika;
        public string Nimi;

        public Kissa()
        {
            Nimi = "";
            Ika = 15;
        }
        public Kissa(int Ika, string Nimi)
        {
            this.Ika = Ika;
            this.Nimi = Nimi;
        }
        public void  AsetaKissanNimi(string Nimi)
        {
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

    }
}

