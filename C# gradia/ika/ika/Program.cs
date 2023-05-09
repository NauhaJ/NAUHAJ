using System;
using Elainluokat;

class Program
{
    static void Main(string[] args)
    {
        
        // For loopilla ratkaisu. I:n arvo nolla, vertaa onko I pienempi kuin 10. Kasvaa joka kierroksella yhdellä.
        for (int i = 0; i < 10; i++)
        {
            // luo randomista olio
            Random RNDM = new Random();
            // Kissa ja koira muuttujat muutetaan integeriksi
            int KissaRNDM = Convert.ToInt32(RNDM.Next(1,11));
            int KoiraRNDM = Convert.ToInt32(RNDM.Next(1,16));
            // Luo uusi koira-olio
            Koira koira = new Koira(KoiraRNDM,"");
            // Luo uusi kissa-olio
            Kissa kissa = new Kissa(KissaRNDM,"");

            // Tulostaa Kissan ja Koiran iät
            Console.WriteLine($"Kissan ikä on {kissa.PalautaKissanIka()} ja koiran ikä on {koira.PalautaKoiranIka()}" );

            // vertaa Koiran ja Kissan ikää
            if (koira.PalautaKoiranIka() > kissa.PalautaKissanIka())
            {
                Console.WriteLine("Koira on vanhempi");
            }
            else if (kissa.PalautaKissanIka() > koira.PalautaKoiranIka())
            {
                Console.WriteLine("Kissa on vanhempi");
            }
            else
            {
                Console.WriteLine("Koira ja Kissa ovat samanikäisiä");
            }
            
        }
    }
}

