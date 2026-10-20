using System;

class Program
{
    static void Main()
    {
        int number = 5;
        try
        {
            // Вычисляем факториал рекурсивно
            long result = CalculateFactorialRecursive(number);
            Console.WriteLine($"Рекурсивный факториал {number} равен: {result}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (OverflowException)
        {
            Console.WriteLine($"Ошибка: произошло переполнение при вычислении факториала {number}.");
        }
    }

    static long CalculateFactorialRecursive(int n)
    {
        // Факториал отрицательного числа не существует
        if (n < 0)
        {
            throw new ArgumentException("Число должно быть неотрицательным.", nameof(n));
        }
        // Базовый случай рекурсии: 0! = 1 и 1! = 1
        if (n == 0 || n == 1)
        {
            return 1;
        }
        // Рекурсия
        checked
        {
            return n * CalculateFactorialRecursive(n - 1);
        }
    }
}
