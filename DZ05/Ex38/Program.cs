int n = new Random().Next(1, 6);
Console.WriteLine($"Случайное число элементо в массиве n={n}");
double[] a = new double[n];
a[0] = Math.Round((new Random().Next(-9900, 10000) * 0.01),2);
double max = a[0]; // максимальный элемент
double min = a[0]; // минимальный элемент
Console.Write($"{a[0]} ");
for (int i = 1; i < n; i = i + 1)
{
    a[i] = Math.Round((new Random().Next(-9900, 10000) * 0.01),2);
    Console.Write($"{a[i]} ");
    if (a[i] > max) max = a[i];
    if (a[i] < min) min = a[i];
}
Console.Write($"Разница между максимальным и минимальным элементами = {Math.Round((max - min),2)}");