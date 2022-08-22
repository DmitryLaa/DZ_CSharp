int n = new Random().Next(1, 11);
Console.WriteLine($"Случайное число элементо в массиве n={n}");
int[] a = new int[n];
int Quantity = 0; // кол-во четных элементов
for (int i = 0; i < n; i = i + 1)
{
    a[i] = new Random().Next(100, 1000);
    Console.Write($"{a[i]} ");
    if (a[i] % 2 == 0) Quantity = Quantity + 1;
}
Console.Write($"Количество четных = {Quantity}");