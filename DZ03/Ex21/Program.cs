int [] a = new int [3];
int [] b = new int [3];
int i = 0;
while (i != 3)
{
    a [i] = Convert.ToInt32(Console.ReadLine());
    i = i + 1;
}
i = 0;
while (i != 3)
{
    b [i] = Convert.ToInt32(Console.ReadLine());
    i = i + 1;
}
double length = 0;
for (i=0; i < 3; i = i + 1)
length = length + (a[i]-b[i])*(a[i]-b[i]);
Console.WriteLine(Math.Round(Math.Sqrt(length),2));