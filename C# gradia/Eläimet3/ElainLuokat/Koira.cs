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
    public class Koira : Elain
    {   // Koiralle oma atribuutti haukku
        public string haukku;

        // parametriton konstrukori
        public Koira() : base()
        {
            this.haukku = haukku;
        }
        // parametrillinen konstruktori
        public Koira(int Ika, string Nimi, bool lihansyoja,string haukku) : base(Ika, Nimi,lihansyoja)
        {
            this.haukku = haukku;
        }
    }
}