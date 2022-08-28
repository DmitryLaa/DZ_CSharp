int[,] CreateArray(int rows, int columns)
{
    return new int[rows, columns];
}
void Fill(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int row = 0; row < rows; row++)
    {
        for (int column = 0; column < columns; column++)
        {
            array[row, column] = new Random().Next(-9, 10);
        }
    }
}
void Print(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int row = 0; row < rows; row++)
    {
        for (int column = 0; column < columns; column++)
        {
            Console.Write($"{array[row, column],4}");
        }
        Console.WriteLine();
    }
}
void MathAverage(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int column = 0; column < columns; column++)
    {
        double columnAverage = 0;
        for (int row = 0; row < rows; row++)
            columnAverage = columnAverage + array[row, column];
        Console.Write($"{Math.Round(columnAverage / rows, 2)} ");
    }
}
Console.WriteLine("Введи количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
if (m >= 0 && n >= 0)
{
    int[,] matrix = CreateArray(m, n);
    Fill(matrix);
    Print(matrix);
    MathAverage(matrix);
}