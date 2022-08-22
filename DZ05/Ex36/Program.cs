int n = new Random().Next(1, 6);
Console.WriteLine($"Случайное число элементо в массиве n={n}");
int[] a = new int[n];
int sum = 0; // сумма элементов на нечетных позициях
for (int i = 0; i < n; i = i + 1)
{
    a[i] = new Random().Next(-99, 100);
    Console.Write($"{a[i]} ");
    if (i % 2 == 1) sum = sum + a[i];
}
Console.Write($"Сумма элементов на нечетных позициях = {sum}");