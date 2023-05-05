using maksuKortti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Paaohjelma
{
    public static void Main(String[] args)
    {
        Maksukortti kortti1 = new Maksukortti(50);
        Console.WriteLine(kortti1);
        kortti1.syoEdullisesti();
        Console.WriteLine(kortti1);
        kortti1.syoMaukkaasti();
        kortti1.syoEdullisesti();
        Console.WriteLine(kortti1);
        Maksukortti kortti2 = new Maksukortti(5);
        Console.WriteLine(kortti2);
        kortti2.syoMaukkaasti();
        Console.WriteLine(kortti2);
        kortti2.syoMaukkaasti();
        Console.WriteLine(kortti2);
        Maksukortti kortti3 = new Maksukortti(10);
        Console.WriteLine(kortti3);
        kortti3.LataaRahaa(15);
        Console.WriteLine(kortti3);
        kortti3.LataaRahaa(10);
        Console.WriteLine(kortti3);
        kortti3.LataaRahaa(200);
        Console.WriteLine(kortti3);

        Maksukortti kortti = new Maksukortti(10);
        Console.WriteLine("Pekka: " + kortti);
        kortti.LataaRahaa(-15);
        Console.WriteLine("Pekka: " + kortti);
        Maksukortti pekanKortti = new Maksukortti(20);
        Maksukortti matinKortti = new Maksukortti(30);
        pekanKortti.syoMaukkaasti();
        matinKortti.syoEdullisesti();
        Console.WriteLine($" Pekan {pekanKortti}");
        Console.WriteLine($" Matin {matinKortti}");
        pekanKortti.LataaRahaa(20);
        matinKortti.syoMaukkaasti();
        Console.WriteLine($" Pekan {pekanKortti}");
        Console.WriteLine($" Matin {matinKortti}");
        pekanKortti.syoEdullisesti();
        pekanKortti.syoEdullisesti();
        matinKortti.LataaRahaa(50);
        Console.WriteLine($" Pekan {pekanKortti}");
        Console.WriteLine($" Matin {matinKortti}");

        Console.ReadLine();



    }
}