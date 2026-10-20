using System;

class Program
{
    static void Main()
    {
        // Переменная для произведения должна быть инициализирована перед передачей по ref
        long product = 1;
        double average;

        // Вызываем метод, передавая числа через запятую благодаря ключевому слову params
        long sum = CalculateStats(ref product, out average, 2, 3, 4, 5);

        Console.WriteLine($"Сумма элементов (return): {sum}");
        Console.WriteLine($"Произведение элементов (ref): {product}");
        Console.WriteLine($"Среднее арифметическое (out): {average:F2}");
    }

   
    /// Вычисляет сумму, произведение и среднее арифметическое элементов.
    static long CalculateStats(ref long product, out double average, params int[] numbers)
    {
        // если передан пустой набор чисел
        if (numbers == null || numbers.Length == 0)
        {
            product = 0;
            average = 0;
            return 0;
        }

        long sum = 0;
        product = 1;

        foreach (int num in numbers)
        {
            sum += num;
            product *= num;
        }

        // Вычисляем среднее арифметическое
        average = (double)sum / numbers.Length;

        return sum;
    }
}
