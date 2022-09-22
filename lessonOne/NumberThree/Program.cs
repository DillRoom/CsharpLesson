//Напишите программу, которая на вход принимает число и выдает, является ли это число четным ? : 
//  4 -> Да
// -3 -> Нет
//  7 -> Нет

Console.Clear();

Console.WriteLine( "Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
{
    Console.WriteLine($"Четное {a}");
}
else
{
    Console.WriteLine($"Нечетное {a}");
}
