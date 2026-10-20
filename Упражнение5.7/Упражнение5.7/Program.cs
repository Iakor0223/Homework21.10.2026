using System;

class Program
{
    static void Main()
    {
        // Создаем массив из 20 элементов
        int[] numbers = new int[20];
        Random rand = new Random();

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(1, 100); // Случайные числа от 1 до 99
        }

        // Выводим исходный массив на экран
        Console.WriteLine("Исходный массив:");
        Console.WriteLine(string.Join(", ", numbers));
        Console.WriteLine();

        // Запрашиваем у пользователя два числа
        Console.Write("Введите первое число из массива, которое хотите переставить: ");
        int firstValue = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число из массива, которое хотите переставить: ");
        int secondValue = int.Parse(Console.ReadLine());

        // Находим индексы этих чисел в массиве
        int firstIndex = Array.IndexOf(numbers, firstValue);
        int secondIndex = Array.IndexOf(numbers, secondValue);

        // Проверяем, существуют ли оба числа в массиве
        if (firstIndex == -1 || secondIndex == -1)
        {
            Console.WriteLine("\nОшибка: Одно или оба введенных числа отсутствуют в массиве!");
            return;
        }

        // Меняем элементы местами через третью переменную
        int temp = numbers[firstIndex];
        numbers[firstIndex] = numbers[secondIndex];
        numbers[secondIndex] = temp;

        // Выводим измененный массив на экран
        Console.WriteLine("\nПолучившийся массив после обмена:");
        Console.WriteLine(string.Join(", ", numbers));
    }
}
