using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите два целых числа A и B (1 <= A, B <= 100):");
        int A = Convert.ToInt32(Console.ReadLine());
        int B = Convert.ToInt32(Console.ReadLine());

        if (A >= B || A < 1 || B > 100)
        {
            Console.WriteLine("Ошибка: A должно быть меньше B, и числа должны быть в пределах от 1 до 100.");
            return;
        }

        Console.WriteLine("Целые числа между A и B (включая A и B):");
        int count = 0;
        for (int i = A; i <= B; i++)
        {
            Console.Write(i + " ");
            count++;
        }

        Console.WriteLine($"\nКоличество чисел: {count}");
    }
}

