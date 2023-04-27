using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
  
   Muista kommentoida toiminnalliset funktiot!

   https://msdn.microsoft.com/en-us/library/5ast78ax.aspx

    1. Luokassa Hevonen ei ole kuin yhden tyyppinen konstruktori,  parametriton konstruktori. Tutki luokkaa.
    2. Luo Hevonen -luokasta olio Main -metodissa
	3. Lisää rivi missä Tulostat olion nimi ja paino näytölle.
	4. Lisää koodiin rivit missä annetaan luodulle oliolle nimi ja paino.
    5. Tulosta olion tiedot nyt näytölle.
  
   
**/
namespace Elaimet
{
    class program
    {
        static void Main(string[] args)
        {
            //Tässä luon Hevonen luokasta olion
            Hevonen Heppa = new Hevonen();
            Heppa.Nimi = "Histamiini";
            Heppa.Paino = 89;

            //Tulosta Hevonen olion nimi ja paino
            Console.WriteLine(Heppa.Nimi + " " + Heppa.Paino);
            // Console.ReadLine();

            Kissa Katti = new Kissa();       //1. Ota Uusi Kissa-luokka Program.cs:ssä käyttöön luomalla uusi kissa-olio parametrittomalla konstruktorilla. 
            Katti.Nimi = "Miisa";           // 2. Anna sen jälkeen kissalle nimi suoraan public muuttujalla. 

            Console.WriteLine(Katti.Nimi);      // 3. Tulosta kissan nimi. 
            //Console.ReadLine();

            Katti.AsetaKissanNimi("Maisa");     // 4. Anna kissalle uusi nimi public -metodilla 

            Console.WriteLine(Katti.Nimi);      // 5.Tulosta kissan nimi.
            //Console.ReadLine();

            Console.WriteLine(Katti.PalautaKissanIka()); // 6. Tulosta kissan ikä
            // Console.ReadLine();

            Kissa Kolli = new Kissa(8,"Mauri");     // 7. Tee uusi kissa-olio ja anna ikä ja nimi konstruktorissa
            Console.WriteLine(Kolli.PalautaKissanNimi() + " on " + Kolli.PalautaKissanIka() + " vuotta vanha kokenut kettu.");
            //Console.ReadLine();
            //Console.WriteLine();

            // Pillin tulee toimia seuraavasti:

            Pilli sorsapilli = new Pilli("Kvaak");
            Pilli kukkopilli = new Pilli("Peef");
            sorsapilli.Soi();
            kukkopilli.Soi();
            sorsapilli.Soi();
            // Console.ReadLine();
            Console.WriteLine();
            // Oven tulee toimia seuraavasti:

            Ovi alexander = new Ovi();
            alexander.koputa();
            alexander.koputa();
            Console.ReadLine();




        }
    }
}
