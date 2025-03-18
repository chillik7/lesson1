using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите два целых числа A и B (A < B, 1 <= A, B <= 10):");
        int A = Convert.ToInt32(Console.ReadLine());
        int B = Convert.ToInt32(Console.ReadLine());

        if (A < 1 || B > 10 || A >= B)
        {
            Console.WriteLine("Ошибка: введите корректные значения (1 <= A < B <= 10).");
            return;
        }

        int product = 1;
        for (int i = A; i <= B; i++)
        {
            product *= i;
        }

        Console.WriteLine($"Произведение всех целых чисел от {A} до {B}: {product}");
    }
}