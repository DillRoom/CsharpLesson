// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Clear();

Console.WriteLine("Введите первую координату первой точки:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату первой точки:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью координату первой точки:");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первую координату второй точки:");
int d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату второй точки:");
int e = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью координату второй точки:");
int f = Convert.ToInt32(Console.ReadLine());

int A = a - d;
int B = b - e;
int C = c - f;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длинна отрезка {length}");