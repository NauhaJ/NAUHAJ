using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raha
{
    class Velka                                     // Luo projektiin luokka Velka
    {
        private double _saldo = 0.0;                  // jolla on double-tyyppiset oliomuuttujat _saldo ja _korkoProsentti
        private double _korkoProsentti = 0.0;

        public Velka(double saldoAlussa, double korkoProsentti)         // Saldo ja korkokerroin annetaan konstruktorin parametrina public Velka(double saldoAlussa, double korkoProsentti).
        {
            _saldo = saldoAlussa;
            _korkoProsentti = korkoProsentti;
        }
        public void TulostaSaldo()                  // Luo luokalle myös metodit public void TulostaSaldo()
        {
            Console.WriteLine($"Lainaa on {_saldo} euroa.");
        }
        public void OdotaVuosi()                    // public void OdotaVuosi()                
        {
            _saldo = _saldo * (1 +(_korkoProsentti / 100));         // Lasketaan korkoprosentilla uusi saldo
        }
    }
}
