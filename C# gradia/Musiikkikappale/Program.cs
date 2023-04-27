using Musiikki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musiikki
{
    class Program
    {
        static void Main(string[] args)
        {
            Musiikkikappale garden = new Musiikkikappale("In The Garden", 10910);
            Console.WriteLine($"Kappaleen { garden.Nimi()} pituus on { garden.Pituus()} sekuntia.");
            Musiikkikappale metallica = new Musiikkikappale("Enter Sandman", 12345);
            Console.WriteLine($"Kappaleen {metallica.Nimi()} pituus on {metallica.Pituus()} sekuntia.");

        }
    }
}