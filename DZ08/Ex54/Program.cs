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
void rowOrder(int[] array)
{
    int length = array.Length;
    int t = 0;
    for (int k = length - 1; k > 0; k--)
        for (int i = 0; i < k; i++)

            if (array[i + 1] > array[i])
            {
                t = array[i];
                array[i] = array[i + 1];
                array[i + 1] = t;

            }
}
void rowOrderMatrix(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int[] a = new int[columns];
    for (int row = 0; row < rows; row++)
    {
        for (int column = 0; column < columns; column++)
            a[column] = array[row, column];
        rowOrder(a);
        for (int column = 0; column < columns; column++)
            array[row, column] = a[column];
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
    Console.WriteLine();
    rowOrderMatrix(matrix);
    Print(matrix);
}