int reverse (int n)
{
    int i = 10000;
    int result = 0;
    while (i != 0)
    {
        result = result + (n / i) * 10000/i;
        n = n % i;
        i = i / 10;
    }
    return result;
}
int n = Convert.ToInt32(Console.ReadLine());
if (Math.Abs(n)>99999 || Math.Abs(n)<10000)
    Console.Write("Введи др. число");
    else
    {
    if (n == reverse (n))
        Console.Write("Да");
    else
        Console.Write("Нет");
    }