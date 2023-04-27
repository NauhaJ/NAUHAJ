using Elaimet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elaimet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Luodaan uusi kissa-olio parametrittomalla konstruktorilla. 
            Kissa Kissa1 = new Kissa();

            // Tulosta kissan nimi
            Console.WriteLine($"Kissan nimi alussa {Kissa1.PalautaKissanNimi()}.");

            // Tulosta kissan ikä
            Console.WriteLine($"Kissan ikä alussa {Kissa1.PalautaKissanIka()}.");

            // uusi kissa-olio ja anna ikä ja nimi konstruktorissa
            Kissa Kolli = new Kissa(8, "Mauri");

            // Tulostaa Kollin nimen ja iän
            Console.WriteLine(Kolli.PalautaKissanNimi() + " on " + Kolli.PalautaKissanIka() + " vuotta vanha kokenut kissa.");

            // Annetaan Kollille negatiivinen ika konsturkorissa
            Kolli.AsetaKissanIka(-1);

            // tulostaa boolean totuusarvon
            Console.WriteLine($"Negatiivisella iällä boolean totuusarvo on: {Kolli.AsetaKissanIka(-1)}");

            // Annetaan Kollille uusi ika
            Kolli.AsetaKissanIka(18);

            // Tulostaa Kollin nimen ja ian
            Console.WriteLine($"{Kolli.PalautaKissanNimi()} on {Kolli.PalautaKissanIka()} on vuotta.");

            // Luodaan uusi olio katti
            Kissa katti = new Kissa();

            // Annetaan nimeksi Anneli
            katti.AsetaKissanNimi("Anneli");

            // Tulostaa katti kissan nimen
            Console.WriteLine($"Katti kissan nimi on nyt {katti.PalautaKissanNimi()}.");

            // asetetaan nimeksi Hilda ja tulostaa boolean totuusarvon
            Console.WriteLine($"Hilda nimellä boolean totuusarvo on: {katti.AsetaKissanNimi("Hilda")}");

            // Override ToString()
            Console.WriteLine(Kolli);
            Console.ReadLine();
        }
    }
}
