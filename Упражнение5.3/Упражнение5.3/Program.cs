using System;

class Program
{
    static void Main()
    {
        // Пример 1 Успешное вычисление
        int number1 = 5;
        if (TryCalculateFactorial(number1, out long result1))
        {
            Console.WriteLine($"Факториал {number1} равен: {result1}");
        }
        else
        {
            Console.WriteLine($"При вычислении факториала {number1} произошло переполнение.");
        }

        // Пример 2 Вызов переполнения
        int number2 = 25;
        if (TryCalculateFactorial(number2, out long result2))
        {
            Console.WriteLine($"Факториал {number2} равен: {result2}");
        }
        else
        {
            Console.WriteLine($"При вычислении факториала {number2} произошло переполнение.");
        }
    }

    /// Метод вычисления факториала числа с контролем переполнения.
    static bool TryCalculateFactorial(int n, out long result)
    {
        result = 1;

        // Факториал отрицательного числа не определен
        if (n < 0)
        {
            result = 0;
            return false;
        }

        try
        {
            // Блок checked отслеживает арифметическое переполнение
            checked
            {
                for (int i = 2; i <= n; i++)
                {
                    result *= i;
                }
            }
            return true;
        }
        catch (OverflowException)
        {
            // Если в блоке checked произошло переполнение, управление передается сюда
            result = 0;
            return false;
        }
    }
}
