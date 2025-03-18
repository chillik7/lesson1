using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число:");
        int number = Convert.ToInt32(Console.ReadLine());

        string numberStr = number.ToString();

        bool isOrdered = true;

        for (int i = 1; i < numberStr.Length; i++)
        {
            if (numberStr[i] < numberStr[i - 1]) 
            {
                isOrdered = false; 
                break; 
            }
        }

        if (isOrdered)
        {
            Console.WriteLine("Цифры числа упорядочены по возрастанию справа налево.");
        }
        else
        {
            Console.WriteLine("Цифры числа НЕ упорядочены по возрастанию справа налево.");
        }
    }
}

