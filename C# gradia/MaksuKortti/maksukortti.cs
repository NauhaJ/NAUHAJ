using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maksuKortti
{
    // tehdään luokka Maksukortti
    public class Maksukortti
    {
        private double saldo;
        public Maksukortti(double alkusaldo)
        {
            this.saldo = alkusaldo;
        }
        // Metodin syoEdullisesti tulisi vähentää kortin saldoa 2.60 eurolla
        public void syoEdullisesti()
        {
            // luodaan muuttuja aterianhinta ja annetaan aterialle hinta
            double edullinen_hinta = 2.6;

            this.saldo = (this.saldo - edullinen_hinta);
        }

        // metodin syoMaukkaasti tulisi vähentää kortin saldoa 4.60 eurolla
        public void syoMaukkaasti()
        {
            // luodaan muuttuja aterianhinta ja annetaan aterialle hinta
            double maukas_hinta = 4.6;
            // verrataan onko saldoa enempi kuin aterian hinta 4.6
            if (this.saldo > maukas_hinta )
            {
                this.saldo = (this.saldo - maukas_hinta);
            }
        //    // Jos menee negatiiviseksi niin palauttaa olemassa olevan saldon
        //    else
        //    {
        //        this.saldo = this.saldo;
        //    }
        }
        public void LataaRahaa(double saldo)
        {
            if (saldo > 0)
            {
                this.saldo = saldo + this.saldo;
            }
        }

        
        public override string ToString()
        {
            return ($"Kortilla on rahaa {this.saldo} euroa");
        }
    }
}
