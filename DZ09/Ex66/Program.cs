void NaturalSum(int m, int n)
{
    if ((m < 0 && n < 0) || (n < m))
        Console.Write("Ошибка ввода, повтори");
    else
    {
        int sum = 0;
        for (int i = m; i <= n; i++)
            if (i > 0) sum = sum + i;
        Console.WriteLine(sum);
    }
}
Console.WriteLine("Введи m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи n (такое что =>m)");
int n = Convert.ToInt32(Console.ReadLine());
NaturalSum(m, n);