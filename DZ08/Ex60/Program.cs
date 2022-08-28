int[,,] CreateArray(int rows, int columns, int levels)
{
    return new int[rows, columns, levels];
}
void Fill(int[,,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int levels = array.GetLength(2);
    int counter = -1;
    int[] check = new int[rows * columns * levels];

    for (int row = 0; row < rows; row++)
    {
        for (int column = 0; column < columns; column++)
        {
            for (int level = 0; level < levels; level++)
            {
                array[row, column, level] = new Random().Next(-99, 100);
                counter = counter + 1;
                check[counter] = array[row, column, level];
                for (int i = 0; i < counter; i++)
                    if (array[row, column, level] == check[i])
                    {
                        level--;
                        counter--;
                        break;
                    }
            }
        }
    }
}
void Print(int[,,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int levels = array.GetLength(2);

    for (int level = 0; level < levels; level++)
    {
        for (int row = 0; row < rows; row++)
        {
            Console.WriteLine();
            for (int column = 0; column < columns; column++)
                Console.Write($" {array[row, column, level],3}({row},{column},{level})");
        }
    }
}
Console.WriteLine("Введи количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи количество уровней");
int k = Convert.ToInt32(Console.ReadLine());
if (m >= 0 && n >= 0 && k >= 0)
{
    int[,,] matrix = CreateArray(m, n, k);
    Fill(matrix);
    Print(matrix);
}