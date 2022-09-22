// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее:
// a = 5;  b = 7   -> max = 7
// a = 2;  b = 10  -> max = 10
// a = -9; b = -3  -> max = -3


Console.Clear();

Console.Write("Введите число: ");

int number = int.Parse(Console.ReadLine());

int sqr = number * number;

Console.WriteLine($"Результат квадрата чила {number} равен {sqr}");