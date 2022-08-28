int count(int[] b)
{
    int result = 0; // кол-во чисел > 0   
    for (int i = 0; i < b.Length; i = i + 1)
        if (b[i] > 0) result = result + 1;
    return result;
}
int m = new Random().Next(1, 6);
Console.WriteLine($"Случайное число элементов m={m}, введи элементы");
int[] a = new int[m];
for (int i = 0; i < m; i = i + 1)
    a[i] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Количество чисел > 0: {count(a)}");
