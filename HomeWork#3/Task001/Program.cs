/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/
Console.Clear();
Console.WriteLine("Введите 5ти значное число: ");
string num = Console.ReadLine();
int l = num.Length;

if (l == 5)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine($"Палиндром - {num}");
    }
    else
    {
        Console.WriteLine($"Не палиндром - {num}");
    }
}
else
{
    Console.WriteLine($"ОШИБКА ввода: {num} не 5тизначное");
}
