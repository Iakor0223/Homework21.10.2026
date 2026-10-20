using System;

class Program
{
    static void Main()
    {
        // Выведем первые 10 чисел Фибоначчи для проверки
        Console.WriteLine("Первые 10 чисел ряда Фибоначчи:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"F({i}) = {GetFibonacci(i)}");
        }
    }

    /// Рекурсивный метод для вычисления n-го числа Фибоначчи.
    static int GetFibonacci(int n)
    {
        // Защита от некорректного ввода
        if (n <= 0)
        {
            throw new ArgumentException("Номер элемента должен быть натуральным числом (больше 0).", nameof(n));
        }

        // Базовые случаи рекурсии: первый и второй элементы ряда равны 1
        if (n == 1 || n == 2)
        {
            return 1;
        }

        // Рекурсивный шаг по формуле
        return GetFibonacci(n - 1) + GetFibonacci(n - 2);
    }
}
