using System;

namespace Raha
{
    class program
    {
        static void Main(string[] args)
        {
            Velka laina = new Velka(1000, 5);       // Luodaan uusi olio LAINA
            laina.TulostaSaldo();                   // tulosta Saldo
            laina.OdotaVuosi();
            laina.TulostaSaldo();                   // tulosta uusi Saldo
            Console.Read();
        }
    }
}

