//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int num_first = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num_second = Convert.ToInt32(Console.ReadLine());

if (num_first == num_second)
{
    Console.WriteLine("Числа равны");
}

if (num_first > num_second)
{
    Console.WriteLine("Первое число больше");
}
else
{
    Console.WriteLine("Второе число больше");
}

