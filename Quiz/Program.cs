

Console.WriteLine("Türkiye'nin başkenti neresidir?");

Console.Write("Cevap: ");
string cevap =  Console.ReadLine();

// cevap yanlış oldukça tekrar et
while (cevap.ToLower() != "ankara")
{
    Console.WriteLine("Yanlış cevap :( Tekrar deneyiniz!");

    Console.Write("Cevap: ");
    cevap = Console.ReadLine();
}

Console.WriteLine("Tebrikler! Doğru cevap :)");
Console.ReadKey();