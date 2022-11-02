// Задача 68: 
// Задайте значения M и N. 
// Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.

// M = 28; N = 7 -> 7

Console.Clear();


Console.WriteLine("Введите натуральное занчение M :");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное занчение N :");
int M = Convert.ToInt32(Console.ReadLine());

NODFunction(M,N);


// вызов функции наибольшего общего делителя.
void NODFunction(int m, int n)
{
    Console.Write(NOD(m, n)); 
}

// функция наибольшего общего делителя.
int NOD(int m, int n)
{
    while (M != N)
    {
        if (N > M)
        {
        return NOD(N = N - M, M);
        }
        else
        {
        return (NOD(N, M = M - N));
        }
    }
    return N; 
}       







