// Sürekli Çift Zar At
// 6-6 Gelirse Çık
Random rnd = new Random();
int a, b;

while (true)
{
    a = rnd.Next(1, 7);
    b = rnd.Next(1, 7);
    Console.WriteLine("{0}-{1}", a, b);
    Thread.Sleep(100); // 100ms uyut

    if (a == 6 && b == 6)
        break;
}

Console.ReadKey();