/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19-> [1, 2, 5, 7, 19]
6, 1, 33-> [6, 1, 33]*/

Console.Clear();

            int i;
            int[] a = new int[8];
            Console.WriteLine("Введите массив из 8 элементов: ");
            for (i = 0; i < 8; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < 8; i++)
            {
                Console.Write($" {a[i]} ");
            }