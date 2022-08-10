string weekends (int x)
{
    string result = "";
    if (x == 6 || x == 7)
        result = "Да";
    else 
        result = "Нет";
        return result;
}
int n = Convert.ToInt32(Console.ReadLine());
if (n<1 || n>7)
    Console.Write("Введи др. число");
else
    Console.Write(weekends (n));
