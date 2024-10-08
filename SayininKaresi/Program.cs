int sayi;
bool sonuc;


do
{
    Console.Write("Sayı: ");
    sonuc = int.TryParse(Console.ReadLine(), out sayi);
} while (!sonuc);

Console.WriteLine("Karesi: " + sayi * sayi);
Console.ReadKey();