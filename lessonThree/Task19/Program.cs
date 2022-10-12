// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Давайте проверим, является ли ваше число палиндромом.");
Console.WriteLine("Введите пятизначное число:");
int num = Convert.ToInt32(Console.ReadLine());

int a = (num % 100000) /10000;
int b = (num % 10000) /1000;
int c = (num % 1000) /100;
int d = (num % 100) /10;
int f = (num % 10);

if(a == f && b == d)
{
    Console.WriteLine("Поздравляю! Ваше число - палиндром. ");
}
else
{
    Console.WriteLine("Не повезло(");
    Console.WriteLine("Попробуйте другое число.");
}


