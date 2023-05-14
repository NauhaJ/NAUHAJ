using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ElainLuokat;

namespace Elainluokat
{
    // Perii Elain-luokan ominaisuudet Kissa-luokalle 
    public class Kissa : Elain
    {
        public Kissa() : base() // parametriton konstruktori
        { 

        }
        // parametrillinen konstruktori
        public Kissa(int Ika, string Nimi, bool lihanSyoja) : base(Ika, Nimi, lihanSyoja)
        {

        }
        // Kissalle metodi kehrää
        public void kehraa()
        {
            Console.WriteLine("Kissa sanoo: hrrr");
        }
    }
}