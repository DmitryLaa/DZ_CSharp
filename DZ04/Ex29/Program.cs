int n = new Random().Next(2,9);
Console.WriteLine($"n={n}");
int [] a = new int [n];
for (int i = 0; i < n; i = i + 1)
    {
    a[i]=new Random().Next(0,100);
    Console.Write($"{a[i]} ");
    }