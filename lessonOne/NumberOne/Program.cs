// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее:
// a = 5;  b = 7   -> max = 7
// a = 2;  b = 10  -> max = 10
// a = -9; b = -3  -> max = -3


Console.Clear();

Console.WriteLine( "Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
//string input1 = Console.ReadLine();
//int number1 = int.Parse(input1);
Console.WriteLine( "Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
//string input2 = Console.ReadLine();
//int number2 = int.Parse(input2);

if (number1 > number2)
{
    Console.WriteLine($"max = {number1}, mim = {number2}");
}
else if (number1 == number2)
{
    Console.WriteLine("Числа равны");
}
else 
{
    Console.WriteLine($"max = {number2}, min = {number1}");
}


