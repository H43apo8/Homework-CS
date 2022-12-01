// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int max;
Console.WriteLine("Введите последовательно три числа:");
int num_first = Convert.ToInt32(Console.ReadLine());
int num_second = Convert.ToInt32(Console.ReadLine());
int num_third = Convert.ToInt32(Console.ReadLine());

max = num_first;

if ( num_second > max )
{
    max = num_second;
}

if ( num_third > max )
{
    max = num_third;
}

Console.WriteLine("наибольшее число: " + max);