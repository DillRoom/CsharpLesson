// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

Console.WriteLine( "Введите проверяемое число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 99){
    Console.WriteLine("Третья цифра заданного числа:" + a.ToString()[2]);
}
else{
    Console.WriteLine("Третьего числа нет(");
}
