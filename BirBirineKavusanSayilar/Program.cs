/*
    KULLANICI İKİ SAYI GİRECEK: 10 20 GİBİ
    BU SAYILARI AŞAĞIDAKİ ARTTIRIP AZALTARAK BİR BİRİNE KAVUŞTURACAĞIZ
    10 20
    11 19
    12 18
    13 17
    14 16
    15 15
*/

Console.Write("Sayı 1: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Sayı 2: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());

for (int i = sayi1, j = sayi2; i <= j; i++, j--)
{
    Console.WriteLine($"{i} {j}");
}

Console.ReadKey();