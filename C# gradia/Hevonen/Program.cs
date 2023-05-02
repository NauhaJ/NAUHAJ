using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;

/**
  
   Muista kommentoida toiminnalliset funktiot!

   https://msdn.microsoft.com/en-us/library/5ast78ax.aspx

    1. Luokassa Hevonen ei ole kuin yhden tyyppinen konstruktori,  parametriton konstruktori. Tutki luokkaa.
    2. Luo Hevonen -luokasta olio Main -metodissa
	3. Lisää rivi missä Tulostat olion nimi ja paino näytölle.
	4. Lisää koodiin rivit missä annetaan luodulle oliolle nimi ja paino.
    5. Tulosta olion tiedot nyt näytölle.
  
   
**/
namespace Elainluokat
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
            Console.ReadLine();
        }
    }
}