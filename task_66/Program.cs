using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите начальное значение (M): ");
        int M = int.Parse(Console.ReadLine());

        Console.Write("Введите конечное значение (N): ");
        int N = int.Parse(Console.ReadLine());

        int sum = GetSumOfNaturalNumbers(M, N);
        Console.WriteLine($"Сумма натуральных чисел от {M} до {N}: {sum}");
    }

    static int GetSumOfNaturalNumbers(int start, int end)
    {
        int sum = 0;

        for (int i = start; i <= end; i++)
        {
            sum += i;
        }

        return sum;
    }
}