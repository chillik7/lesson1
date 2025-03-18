using System;

class Program
{
    static void Main()
    {
        double A = 0.5;
        double B = 1;
        int M = 10;

        double H = (B - A) / M;

        Console.WriteLine(" x\t\t F(x) = arccos(x)");

        for (int i = 0; i <= M; i++)
        {
            double x = A + i * H;
            double fx = Math.Acos(x); 
            Console.WriteLine($"{x:F2}\t {fx:F4}");
        }
    }
}

