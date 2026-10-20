using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Задача 3: Инверсия регистра букв");
        Console.Write("Введите строку для изменения регистра символов: ");
        string input = Console.ReadLine();

        StringBuilder result = new StringBuilder();

        foreach (char c in input)
        {
            if (char.IsUpper(c))
            {
                result.Append(char.ToLower(c));
            }
            else if (char.IsLower(c))
            {
                result.Append(char.ToUpper(c));
            }
            else
            {
                result.Append(c);
            }
        }

        Console.WriteLine($"\nРезультат обработки: {result}");
    }
}
