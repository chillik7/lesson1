using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение x:");
        double x = Convert.ToDouble(Console.ReadLine());
        double y;

        if (x >= 4 && x <= 6)
        {
            y = x;
        }
        else if (x > 6)
        {
            y = 3 * x + 4 * Math.Pow(x, 2);
        }
        else
        {
            Console.WriteLine("Ошибка: x должен быть >= 4.");
            return;
        }

        Console.WriteLine($"Значение функции y: {y}");
    }
}
