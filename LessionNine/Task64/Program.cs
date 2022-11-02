// Задача 64: 
// Задайте значения N и M. Напишите программу, которая выведет все чётные натуральные числа 
// в промежутке от M до N с помощью рекурсии.

// M = 1; N = 5 -> 2, 4
// M = 4; N = 8 -> 4, 6, 8

Console.Clear();

Console.WriteLine("Введите натуральное занчение N :");
Console.WriteLine("(Должно быть больше 1)");
int N = int.Parse(Console.ReadLine());
if (N < 0) {
    Console.WriteLine($"{N} не натуральное число"); 
    return;
}
Console.WriteLine("Введите натуральное занчение M :");
Console.WriteLine("(Должно быть больше N)");
int M = int.Parse(Console.ReadLine());
if (M < 0) {
    Console.WriteLine($"{M} не натуральное число");
    return;
}
if (M < N) Console.WriteLine($"Введиле другие значения {M} {N}");

Number(N,M);

Console.WriteLine();

// Нахождение чётных чисел с двумя переменными.

void Number ( int N,int M){
    N = Math.Abs(N);
    while (N <= M){
        if ( N % 2 == 0 || N == 0 ){
            Console.Write($"{N}."); 
            } 
            Number(N+1,M);
            return;
    }   
}