double[,] CreateArray(int rows, int columns)
{
    return new double[rows, columns];
}
void Fill(double[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int row = 0; row < rows; row++)
    {
        for (int column = 0; column < columns; column++)
        {
            array[row, column] = Math.Round(new Random().Next(-9900, 10000) * 0.01, 2);
        }
    }
}
void Print(double[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int row = 0; row < rows; row++)
    {
        for (int column = 0; column < columns; column++)
        {
            Console.Write($"{array[row, column],7}");
        }
        Console.WriteLine();
    }
}
void Search(double[,] array, int searchedRow, int searchedColumn)
{
    Console.WriteLine($"{array[searchedRow, searchedColumn],7}");
}
Console.WriteLine("Введи количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
if (m >= 0 && n >= 0)
{
    double[,] matrix = CreateArray(m, n);
    Fill(matrix);
    Print(matrix);
    Console.WriteLine("Введи искомую строку массива (нумерация с 0-ля)");
    int m1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введи искомый столбец массива (нумерация с 0-ля)");
    int n1 = Convert.ToInt32(Console.ReadLine());
    if (m1 <= m-1 && n1 <= n-1 && m1 >= 0 && n1 >= 0) Search(matrix, m1, n1);
    else Console.WriteLine("Такого числа в массиве нет");
}