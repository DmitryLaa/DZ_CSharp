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
void minRowSum(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int[] a = new int[columns];
    int minSum = 0;
    int sum = 0;
    int minSumRow = 1;
    for (int column = 0; column < columns; column++)
        minSum = minSum + array[0, column];
    for (int row = 1; row < rows; row++)
    {
        sum = 0;
        for (int column = 0; column < columns; column++)
            sum = sum + array[row, column];
        if (sum < minSum)
        {
            minSum = sum;
            minSumRow = row;
        }
    }
    Console.WriteLine($"{minSumRow+1} (нумерация с 1)");
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
    minRowSum(matrix);
}