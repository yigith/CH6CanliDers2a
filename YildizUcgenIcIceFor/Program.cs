
for (int i = 1; i <= 10; i++)
{
    #region satırın içeriğini oluşturur
    for (int j = 0; j < i; j++)
    {
        Console.Write("* ");
    }
    #endregion

    Console.WriteLine(); 
}


Console.ReadKey();