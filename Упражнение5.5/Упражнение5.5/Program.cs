using System;

class Program
{
    static void Main()
    {
        // Проверка НОД для двух чисел
        int a = 72;
        int b = 96;
        Console.WriteLine($"НОД({a}, {b}) = {Getnod(a, b)}"); // Ожидается: 24

        // Проверка НОД для трех чисел
        int x = 48;
        int y = 72;
        int z = 108;
        Console.WriteLine($"НОД({x}, {y}, {z}) = {Getnod(x, y, z)}"); // Ожидается: 12
    }

    /// Вычисляет НОД
    static int Getnod(int a, int b)
    {
        // Работаем по модулю остатка от деления
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    /// метод для вычисления НОД трех чисел.
    static int Getnod(int a, int b, int c)
    {
        // Используем свойство ассоциативности: НОД(a, b, c) = НОД( НОД(a, b), c )
        return Getnod(Getnod(a, b), c);
    }
}

