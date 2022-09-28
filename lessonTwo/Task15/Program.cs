// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

Console.WriteLine("Хотите, я покажу когда будут выходные ?");
Console.WriteLine("Да (1) или Нет (2)");
int ansver = Convert.ToInt32(Console.ReadLine());

if (ansver == 2) 
{
Console.WriteLine("До свидания.");
}

else if ( ansver > 2 || ansver < 1){
Console.WriteLine("Эй! Вы точно хотите унать когда выходной ? ");
}
else
{
Console.WriteLine("Выберите число обозначающее день недели:");
Console.WriteLine("Понедельник - 1");
Console.WriteLine("Вторник     - 2");
Console.WriteLine("Среда       - 3");
Console.WriteLine("Черверг     - 4");
Console.WriteLine("Пятница     - 5");
Console.WriteLine("Суббота     - 6");
Console.WriteLine("Воскресенье - 7");
int a = Convert.ToInt32(Console.ReadLine());

    if (a < 6){
    Console.WriteLine("Сожелею, сегодня не выходной(");
    }
    else if ( a > 7){
        Console.WriteLine("Вы ввели неправильное число, попробуйте позже.");
    } 

    else
    {
    Console.WriteLine("Ура, Ура !!! Выходной!!! ");
    }


}
    








