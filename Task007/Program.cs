/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6->да
7->да
1->нет*/
Console.Clear();
Console.Write("Введи цифру, обозначающую день недели: ");
int dayWeek = Convert.ToInt32(Console.ReadLine());

void CheckDayWeek(int dayWeek)
{
    if (dayWeek == 6 || dayWeek == 7)
    {
        Console.WriteLine("(Это выходной) -> да");
    }
    else if (dayWeek < 1 || dayWeek > 7)
    {
        Console.WriteLine("Мимо, попробуй еще разочек...");
    }
    else Console.WriteLine("(Это не выходной) -> нет");
}

CheckDayWeek(dayWeek);