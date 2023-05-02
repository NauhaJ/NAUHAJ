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
        //Maksukortti kortti = new Maksukortti(50);
        //Console.WriteLine(kortti);
        //kortti.syoEdullisesti();
        //Console.WriteLine(kortti);
        //kortti.syoMaukkaasti();
        //kortti.syoEdullisesti();
        //Console.WriteLine(kortti);
        //Maksukortti kortti = new Maksukortti(5);
        //Console.WriteLine(kortti);
        //kortti.syoMaukkaasti();
        //Console.WriteLine(kortti);
        //kortti.syoMaukkaasti();
        //Console.WriteLine(kortti);
        //Maksukortti kortti = new Maksukortti(10);
        //Console.WriteLine(kortti);
        //kortti.LataaRahaa(15);
        //Console.WriteLine(kortti);
        //kortti.LataaRahaa(10);
        //Console.WriteLine(kortti);
        //kortti.LataaRahaa(200);
        //Console.WriteLine(kortti);

        //Maksukortti kortti = new Maksukortti(10);
        //Console.WriteLine("Pekka: " + kortti);
        //kortti.LataaRahaa(-15);
        //Console.WriteLine("Pekka: " + kortti);
        Maksukortti pekanKortti = new Maksukortti(20);
        Maksukortti matinKortti = new Maksukortti(30);
        pekanKortti.syoMaukkaasti();
        matinKortti.syoEdullisesti();
        Console.WriteLine($" Pekalla on rahaa {pekanKortti}");
        Console.WriteLine($" Matilla on rahaa {matinKortti}");
        pekanKortti.LataaRahaa(20);
        matinKortti.syoMaukkaasti();
        Console.WriteLine($" Pekalla on rahaa {pekanKortti}");
        Console.WriteLine($" Matilla on rahaa {matinKortti}");
        pekanKortti.syoEdullisesti();
        pekanKortti.syoEdullisesti();
        matinKortti.LataaRahaa(50);
        Console.WriteLine($" Pekalla on rahaa {pekanKortti}");
        Console.WriteLine($" Matilla on rahaa {matinKortti}");

        Console.ReadLine();



    }
}