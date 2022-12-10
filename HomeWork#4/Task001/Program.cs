/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5-> 243(3⁵)
2, 4-> 16*/

Console.Clear();

int num1 = ReadInt("Введите число: ");
int num2 = ReadInt("Введите степень: ");
Stepen(num1, num2);

void Stepen(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


