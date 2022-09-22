//Напишите программу, которая на вход принимает три числа и выдает максимальное из этих числе:
// 2,3,7   -> 7
// 44,5,78 -> 78
// 22,3,9  -> 22

Console.Clear();

Console.WriteLine( "Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine( "Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine( "Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c)
{
    Console.WriteLine("Максимальное число = " + a);
}

else if (b > c)
{
    Console.WriteLine("Максимальное число = " + b);
}
else
{
    Console.WriteLine("Максимальное число = " + c);
}
