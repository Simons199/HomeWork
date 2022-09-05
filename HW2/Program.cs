Console.WriteLine("введите первое число");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе число");
int numB = Convert.ToInt32(Console.ReadLine());

if (numA > numB)
{
    Console.WriteLine("число: " + numA + " больше чем: " + numB);
}
else
{
    Console.WriteLine("число: " + numB + " больше чем: " + numA);
}
return;