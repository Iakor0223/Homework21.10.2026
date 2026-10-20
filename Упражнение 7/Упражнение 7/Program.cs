using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Задача 4: Подсчет вхождений подстроки");

        Console.Write("Введите основную строку: ");
        string text = Console.ReadLine();

        Console.Write("Введите подстроку для поиска: ");
        string subText = Console.ReadLine();

        int count = 0;
        int index = text.IndexOf(subText);

        while (index != -1)
        {
            count++;
            // Сдвигаем указатель дальше, чтобы не зацикливаться
            index = text.IndexOf(subText, index + subText.Length);
        }

        Console.WriteLine($"\nПодстрока найдена следующее количество раз: {count}");
    }
}
