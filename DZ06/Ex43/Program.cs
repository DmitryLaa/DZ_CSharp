void point(int k1, int b1, int k2, int b2)
{
    double x = (double)(b2 - b1) / (k1 - k2);
    double y = (double)(b2*k1 - b1*k2) / (k1 - k2);
    if (k1 == k2) Console.WriteLine("Прямые не пересекаются");
    else Console.WriteLine($"Координаты точки пересечения ({Math.Round(x, 2)},{Math.Round(y, 2)})");
}
Console.WriteLine("Введи k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи b1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи k2");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи b2");
int b2 = Convert.ToInt32(Console.ReadLine());
point(k1, b1, k2, b2);