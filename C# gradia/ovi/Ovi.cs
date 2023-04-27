using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rakenne
{
    class Ovi       // Luo projektiin luokka nimeltä Ovi
    {               // Ovella ei ole oliomuuttujia.

        public Ovi()    // Luo sille parametriton konstruktori (tai käytä oletuskonstruktoria)
        {
        }
        public void koputa()        // Luo tämän jälkeen ovelle metodi public void koputa()
        {
            Console.WriteLine("Who's there?");      // joka kutsuttaessa tulostaa viestin "Who's there?".
        }
    }
}
