int cub (int n)
{
    int result = n * n * n;
    return result;
}
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i = i + 1)
Console.Write($"{cub(i)} "); 