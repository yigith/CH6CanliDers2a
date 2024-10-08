Console.WriteLine("Zar atmak için bir tuşa basınız..");
Console.ReadKey(true);

Random rnd = new Random();

baslangic:
int zar = rnd.Next(1, 7);
Console.WriteLine("\r\nGelen zar: " + zar);

Console.WriteLine("\r\nTekrar için E, çıkmak için başka bir tuşa basınız..");
ConsoleKey tus = Console.ReadKey(true).Key;

if (tus == ConsoleKey.E)
    goto baslangic;
