using System;

class Program
{
    static void Main()
    {
        int M = 1; // Начальное значение промежутка
        int N = 10; // Конечное значение промежутка

        Console.WriteLine($"Натуральные числа от {M} до {N}:");
        PrintNaturalNumbers(M, N);
    }

    static void PrintNaturalNumbers(int start, int end)
    {
        if (start > end)
        {
            return;
        }

        Console.WriteLine(start);
        PrintNaturalNumbers(start + 1, end);
    }
}