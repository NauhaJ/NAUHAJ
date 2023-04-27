using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MittaTehtävä
{
    // Luo projektiin luokka Mittari
    internal class Mittari
    {
        // Mittarilla on oliomuuttuja private int _mitta 
        private int _mitta = 0;

        // parametriton konstruktori (asettaa muuttujan mitta alkuarvoksi 0)
        public Mittari()
        {
            _mitta = 0;
        }

        // Metodi public void Lisaa() kasvattaa oliomuuttujan _mitta arvoa yhdellä. Ei kasvata arvoa yli viiden
        public void Lisaa()
        {
            if (_mitta < 5)
            {
                _mitta++;       // Kasvattaa _mitta arvoa yhdellä
            }
        }
        // Metodi public void Vahenna() vähentää oliomuuttujan _mitta arvoa yhdellä. Ei vähennä arvoa negatiiviseksi
        public void Vahenna()
        {
            if ( _mitta > 0)
            {
                _mitta--;       // Vähentää _mitta arvoa yhdellä
            }
            
        }
        // Metodi public int Mitta() palauttaa oliomuuttujan _mitta arvon
        public int Mitta()
        {
            return _mitta;          // palauttaa _mitta arvon
        }
        //Metodi public boolean Taynna() palauttaa true mikäli oliomuuttujan _mitta on viisi, palauttaa muulloin false.
        public bool Taynna()
        {
            if (_mitta == 5)        // Jos mitta on sama kuin viisi 
            {
                return true;        // palauta TRUE
            }
            else                    
            { 
                return false;       // muuten palauttaa FALSE
            }

        }

    }
}
