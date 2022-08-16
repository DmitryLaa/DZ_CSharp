int a = Convert.ToInt32(Console.ReadLine());
if (a <= 0)
    Console.Write("Введи др. число A");
else
    { 
    int sum = 0;
    while (a != 0)
        {
        sum = sum + a % 10;
        a = a / 10; 
        }
    Console.Write(sum);
    }