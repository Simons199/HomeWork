Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());

int i = 1;
while(i <= a)

{
if ( i % 2 == 0)

Console.Write(i + ", "); 

i++;
}
Console.WriteLine("Чётные числа от 1 до " + a);
