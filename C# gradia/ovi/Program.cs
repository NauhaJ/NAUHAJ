using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rakenne
{
    class program
    {
        static void Main(string[] args)
        {
            Ovi alexander = new Ovi();      // Luodaan uusi olio
            alexander.koputa();             // Kutsuu metodia
            alexander.koputa();
            Console.ReadLine();             // lukee rivit
        }
    }
}

