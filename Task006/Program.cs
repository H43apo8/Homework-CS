// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645-> 5
//78->третьей цифры нет
//32679 -> 6
Console.Clear();
Console.Write("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());
string txt = Convert.ToString(num);
if (txt.Length > 2)
{
    Console.WriteLine("3я цифра = " + txt[2]);
}
else
{
    Console.WriteLine("3й цифры нет");
}