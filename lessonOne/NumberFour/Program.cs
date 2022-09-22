// Напишите программу, которая на вход примает число (N), а на выход показывает все четные числа от 1 до N:
// 5 -> 2,4
// 8 -> 2,4,6,8

Console.Clear();

Console.WriteLine( "Введите число: ");
int a2 = Convert.ToInt32(Console.ReadLine());
a2 = Math.Abs(a2);
int a = 1;

while (a <= a2)
{
    if (a2 % 2 == 0)
    {
       Console.Write(a2); 
    }
    a2 = a2 -1;
} 
Console.WriteLine();