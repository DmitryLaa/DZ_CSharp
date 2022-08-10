void third (int k)
{
    int m = k;
    int i = 1;
    while (m < 0 || m > 0)
    {
        m = m/10;
        i = i * 10;
    }
    m = ((k * 1000) / i) % 10;
    if (m > 0) 
        Console.Write($"Третья цифра {m}");
    else
        Console.Write($"Третья цифра {-m}");
}
int n = Convert.ToInt32(Console.ReadLine());
if (n<100 && n>-100)
    Console.Write("Третьей цифры нет");
else
    third (n);
