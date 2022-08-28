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

Console.WriteLine("Введи количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
if (m >= 0 && n >= 0)
{
    double[,] matrix = CreateArray(m, n);
    Fill(matrix);
    Print(matrix);
}
