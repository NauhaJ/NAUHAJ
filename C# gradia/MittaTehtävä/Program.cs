using MittaTehtävä;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MittaTehtävä
{
    class Program
    {
        static void Main(string[] args)
        {
            // luodaan mittari1 olio
            Mittari mittari1 = new Mittari();

            // huomaa huutomerkki joka muuttaa totuusarvon päinvastaiseksi. Silmukka kiertää koodilohkon läpi niin kauan kuin määritetty ehto täyttyy
            while (!mittari1.Taynna())          
            {
                Console.WriteLine($"Ei täynnä! Mitta: {mittari1.Mitta()}");
                // kasvattaa arvoa yhdellä joka kierroksella
                mittari1.Lisaa();
            }
            // Hypätään silmukasta pois ja tulostaa ilmoituksen ja mitan arvon
            Console.WriteLine($"Täynnä! Mitta: {mittari1.Mitta()}");
            // vähentää yhdellä 
            mittari1.Vahenna();
            // Tulostaa nykyisen mitan arvon
            Console.WriteLine($"Ei täynnä! Mitta: {mittari1.Mitta()}");
            Console.ReadLine();
        }
    }
}