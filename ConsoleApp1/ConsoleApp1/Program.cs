using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите длину стороны квадрата:");
        double side = Convert.ToDouble(Console.ReadLine());

        double perimeter = 4 * side;

        Console.WriteLine($"Периметр квадрата: {perimeter}");
    }
}
