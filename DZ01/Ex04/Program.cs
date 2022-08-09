int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (a >= b) 
{
    max = a;
    if (c >= max)
        max=c;
}
else 
{ 
    max = b;
    if (c >=max)
        max=c;
}   
    Console.WriteLine($"Max {max}");
