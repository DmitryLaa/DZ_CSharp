static int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
     if ((m != 0) && (n == 0))
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}
Console.WriteLine("Введи m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи n (такое что =>m)");
int n = Convert.ToInt32(Console.ReadLine());
if (m < 0 || n < 0)
    Console.Write("Ошибка ввода, повтори");
else Console.Write(Akkerman(m, n));
Console.WriteLine();
