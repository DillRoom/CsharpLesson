// Функции для упрощения жизни)

// Функция подсчета цифр в числе
int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

// Функция вывода суммы цифр в числе
void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine($"сумма цифр {sum}");
}

// Заполнение рандомного массива
void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}

// Вывод массива
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

// Функция ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция возведения в степень
void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(a + " в степени " + b + " = " + result);
}

///Метод вывода натуральных чисел от N до 1:
void NumberCounter (int number)
{
    if (number < 0) Console.Write($"{number} не натуральное число");
    if (number == 0) return;
    Console.Write("{0,4}", number);
    NumberCounter (number - 1);
}

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

///Метод нахождения суммы натуральных элементов в промежутке от M до N
void GapNumberSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    GapNumberSum(numberM, numberN, sum);
}

int N =1;
int M =2;

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
