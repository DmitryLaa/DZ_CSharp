void second ()
{
    int n = Convert.ToInt32(Console.ReadLine());
    int k = 0;
    if (n > 999 || n < -999 || (n<100 && n>-100)) 
    Console.Write($"Введи др. число"); 
    else
    {
        k = n / 10 % 10;
        Console.Write($"Вторая цифра {k}");
    }
}
second ();
