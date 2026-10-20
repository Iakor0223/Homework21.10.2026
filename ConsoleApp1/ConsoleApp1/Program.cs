using System;
using System.Numerics; // Требуется для работы с комплексными числами

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Решение квадратного уравнения ax² + bx + c = 0");

        try
        {
            // Ввод коэффициентов с базовой валидацией
            Console.Write("Введите a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Введите c: ");
            double c = double.Parse(Console.ReadLine());

            SolveQuadratic(a, b, c);
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Введено неверное число.");
        }

        Console.ReadKey();
    }

    static void SolveQuadratic(double a, double b, double c)
    {
        // Случай, если a = 0 (уравнение становится линейным bx + c = 0)
        if (a == 0)
        {
            if (b != 0)
            {
                double x = -c / b;
                Console.WriteLine($"Уравнение линейное. Один корень: x = {x}");
            }
            else
            {
                if (c == 0)
                    Console.WriteLine("Уравнение имеет бесконечно много решений (0 = 0).");
                else
                    Console.WriteLine("Уравнение не имеет решений (равенство неверно).");
            }
            return;
        }

        // Вычисление дискриминанта
        double D = b * b - 4 * a * c;
        Console.WriteLine($"Дискриминант (D) = {D}");

        // Анализ дискриминанта и поиск корней
        if (D > 0)
        {
            double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            double x2 = (-b - Math.Sqrt(D)) / (2 * a);
            Console.WriteLine($"Два вещественных корня:\nx1 = {x1}\nx2 = {x2}");
        }
        else if (D == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Один вещественный корень: x = {x}");
        }
        else
        {
            // Комплексные корни (если D < 0)
            Console.WriteLine("Вещественных корней нет. Комплексные корни:");

            // Находим вещественную и мнимую части отдельно
            double realPart = -b / (2 * a);
            double imaginaryPart = Math.Sqrt(-D) / (2 * a);

            // Вывод с использованием структуры Complex (i — мнимая единица)
            Complex x1 = new Complex(realPart, imaginaryPart);
            Complex x2 = new Complex(realPart, -imaginaryPart);

            Console.WriteLine($"x1 = {x1.Real} + {x1.Imaginary}i");
            Console.WriteLine($"x2 = {x2.Real} - {Math.Abs(x2.Imaginary)}i");
        }
    }
}

