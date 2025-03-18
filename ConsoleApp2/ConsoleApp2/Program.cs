using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите трехзначное число:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 100 || number > 999)
        {
            Console.WriteLine("Ошибка: введите корректное трехзначное число.");
            return;
        }

        int digit1 = number / 100;
        int digit2 = (number / 10) % 10;
        int digit3 = number % 10;

        int sum = digit1 + digit2 + digit3;
        bool isEven = sum % 2 == 0;

        Console.WriteLine($"Сумма цифр: {sum}");
        Console.WriteLine($"Высказывание истинно: {isEven}");
    }
}
