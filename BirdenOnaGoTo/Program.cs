int a = 1;

baslangic:
if (a <= 10)
{
    Console.WriteLine(a++);
    goto baslangic;
}


Console.ReadKey();
