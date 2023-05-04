using koira;

Koira Turre = new Koira();
Turre.AsetaKoiranNimi("Max");
Console.WriteLine($"Koiran nimi on: {Turre.PalautaKoiranNimi()}");
Turre.AsetaKoiranNimi("musti");
Console.WriteLine($"musti nimellä boolean totuusarvo on: {Turre.AsetaKoiranNimi("musti")}");
Console.WriteLine($"Koiran nimi on: {Turre.PalautaKoiranNimi()}");
Console.ReadLine();