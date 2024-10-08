
// 1-20 aralığındaki sayıları yazdır
// 3ün veya 5in katları hariç

#region Yöntem 1
for (int i = 1; i <= 20; i++)
{
    if (i % 3 != 0 && i % 5 != 0)
        Console.Write(i + " ");
}
#endregion
Console.WriteLine("\r\n\r\n-----------------------\r\n");
#region Yöntem 2
for (int i = 1; i <= 20; i++)
{
    if (i % 3 == 0 || i % 5 == 0)
        continue;

    Console.Write(i + " ");
}
#endregion

Console.ReadKey();