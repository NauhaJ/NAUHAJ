using ElainLuokat;
using System.Runtime.CompilerServices;

namespace Elainluokat
{
    class program
    {
        static void Main(string[] args)
        {
            ////Tässä luon Hevonen luokasta olion
            //Hevonen Heppa = new Hevonen();
            //Heppa.Nimi = "Histamiini";
            //Heppa.Paino = 89;

            ////Tulosta Hevonen olion nimi ja paino
            //Console.WriteLine(Heppa.Nimi + " " + Heppa.Paino);

            ////Luodaan uusi kissa-olio parametrittomalla konstruktorilla. 
            //Kissa Kissa1 = new Kissa();

            //// Tulosta kissan nimi
            //Console.WriteLine($"Kissan nimi alussa {Kissa1.PalautaKissanNimi()}.");

            //// Tulosta kissan ikä
            //Console.WriteLine($"Kissan ikä alussa {Kissa1.PalautaKissanIka()}.");

            //// uusi kissa-olio ja anna ikä ja nimi konstruktorissa
            //Kissa Kolli = new Kissa(8, "Mauri");

            //// Tulostaa Kollin nimen ja iän
            //Console.WriteLine(Kolli.PalautaKissanNimi() + " on " + Kolli.PalautaKissanIka() + " vuotta vanha kokenut kissa.");

            //// Annetaan Kollille negatiivinen ika konsturkorissa
            //Kolli.AsetaKissanIka(-1);

            //// tulostaa boolean totuusarvon
            //Console.WriteLine($"Negatiivisella iällä boolean totuusarvo on: {Kolli.AsetaKissanIka(-1)}");

            //// Annetaan Kollille uusi ika
            //Kolli.AsetaKissanIka(18);

            //// Tulostaa Kollin nimen ja ian
            //Console.WriteLine($"{Kolli.PalautaKissanNimi()} on {Kolli.PalautaKissanIka()} on vuotta.");

            //// Luodaan uusi olio katti
            //Kissa katti = new Kissa();

            //// Annetaan nimeksi Anneli
            //katti.AsetaKissanNimi("Anneli");

            //// Tulostaa katti kissan nimen
            //Console.WriteLine($"Katti kissan nimi on nyt {katti.PalautaKissanNimi()}.");

            //// asetetaan nimeksi Hilda ja tulostaa boolean totuusarvon
            //Console.WriteLine($"Hilda nimellä boolean totuusarvo on: {katti.AsetaKissanNimi("Hilda")}");

            //// Override ToString()
            //Console.WriteLine(Kolli);
            //Koira Turre = new Koira();
            //Turre.AsetaKoiranNimi("Max");
            //Console.WriteLine($"Koiran nimi on: {Turre.PalautaKoiranNimi()}");
            //Turre.AsetaKoiranNimi("musti");
            //Console.WriteLine($"musti nimellä boolean totuusarvo on: {Turre.AsetaKoiranNimi("musti")}");
            //Console.WriteLine($"Koiran nimi on: {Turre.PalautaKoiranNimi()}");
            //Console.ReadLine();

            // Uusi Elain olio
            Elain Elain1 = new Elain();
            Elain1.AsetaElaimenNimi("Martta");
            Elain1.AsetaElaimenIka(8);
            Console.WriteLine($"Eläimen ikä on {Elain1.PalautaElaimenIka()} ja nimi on {Elain1.PalautaElaimenNimi()}.");
            Elain1.AsetaOnlihanSyoja(false);
            Console.WriteLine($"Eläin on lihansyöjä True vai False: {Elain1.PalautaOnLihansyoja()}");
            
            
        }
    }
}
