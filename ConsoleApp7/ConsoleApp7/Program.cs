using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите два целых числа A и B (A <= B):");
        int A = Convert.ToInt32(Console.ReadLine());
        int B = Convert.ToInt32(Console.ReadLine());

        if (A > B)
        {
            Console.WriteLine("Ошибка: A должно быть меньше или равно B.");
            return;
        }

        Console.WriteLine("Используя for:");
        for (int i = B; i >= A; i--)
        {
            Console.WriteLine($"{i}^3 = {Math.Pow(i, 3)}");
        }

        Console.WriteLine("\nИспользуя while:");
        int j = B;
        while (j >= A)
        {
            Console.WriteLine($"{j}^3 = {Math.Pow(j, 3)}");
            j--;
        }

        Console.WriteLine("\nИспользуя do-while:");
        int k = B;
        do
        {
            Console.WriteLine($"{k}^3 = {Math.Pow(k, 3)}");
            k--;
        } while (k >= A);
    }
}
