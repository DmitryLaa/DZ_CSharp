int n = Convert.ToInt32(Console.ReadLine());
if (n>0)
{
int i = 1;
while (i <= n)
{   
    if (i % 2 == 0) 
    Console.Write($"{i} ");
    i = i + 1;
}
}    
else 
{
    int i = n;
while (i <= 0)
{   
    if (i % 2 == 0) 
    Console.Write($"{i} ");
    i = i + 1;
}
}