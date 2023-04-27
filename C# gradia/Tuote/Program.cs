using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kauppa
{
    class program
    {
        static void Main(string[] args)
        {
            Tuote kauppatuote = new Tuote("Banaani",1.1,13);    // tulostus olettaa, että tuotteen nimeksi on annettu banaani, hinnaksi on annettu 1.1, ja määräksi on annettu 13.
            kauppatuote.TulostaTuote();
            Console.ReadLine();
        }
    }
}