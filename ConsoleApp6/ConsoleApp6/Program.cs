using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите номер дня недели (1-7):");
        int day = Convert.ToInt32(Console.ReadLine());

        string dayName;

        switch (day)
        {
            case 1:
                dayName = "Понедельник";
                break;
            case 2:
                dayName = "Вторник";
                break;
            case 3:
                dayName = "Среда";
                break;
            case 4:
                dayName = "Четверг";
                break;
            case 5:
                dayName = "Пятница";
                break;
            case 6:
                dayName = "Суббота";
                break;
            case 7:
                dayName = "Воскресенье";
                break;
            default:
                Console.WriteLine("Ошибка: введите число от 1 до 7.");
                return;
        }

        Console.WriteLine($"День недели: {dayName}");
    }
}
