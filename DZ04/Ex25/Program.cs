int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (b <= 0)
    Console.Write("Введи др. число B после повтора ввода A");
else
    {
    int c = 1;
    for (int i = 1; i <= b; i = i + 1)
        c = c * a; 
    Console.Write(c);
    }