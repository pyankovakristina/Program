using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Гипотеза Коллатца (3n + 1)");
        Console.WriteLine("===========================");

        Console.Write("Введите начальное число n: ");
        int n = int.Parse(Console.ReadLine());

        int steps = CollatzSteps(n);

        Console.WriteLine($"\nЧисло замен для достижения 1: {steps}");

        // Дополнительно покажем саму последовательность
        Console.WriteLine("\nПоследовательность преобразований:");
        PrintCollatzSequence(n);
    }

    // Функция, возвращающая количество замен до достижения 1
    static int CollatzSteps(int n)
    {
        if (n <= 0)
            throw new ArgumentException("Число должно быть положительным");

        int steps = 0;
        int current = n;

        while (current != 1)
        {
            if (current % 2 == 0)  // Если четное
            {
                current = current / 2;
            }
            else  // Если нечетное
            {
                current = 3 * current + 1;
            }
            steps++;
        }

        return steps;
    }

    // Дополнительная функция для вывода последовательности
    static void PrintCollatzSequence(int n)
    {
        int current = n;
        Console.Write($"{current}");

        while (current != 1)
        {
            if (current % 2 == 0)
            {
                current = current / 2;
                Console.Write($" - {current}");
            }
            else
            {
                current = 3 * current + 1;
                Console.Write($" - {current}");
            }
        }
        Console.WriteLine();
    }
}