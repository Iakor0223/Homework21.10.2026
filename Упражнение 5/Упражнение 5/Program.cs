using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите запрашиваемые данные для регистрации в системе.\n");

        Console.Write("Введите ваше имя: ");
        string name = Console.ReadLine();

        Console.Write("Введите ваш город: ");
        string city = Console.ReadLine();

        Console.Write("Введите ваш возраст: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Введите ваш PIN-код: ");
        int pin = int.Parse(Console.ReadLine());

        Console.WriteLine("\n--- Профиль пользователя успешно создан ---");
        Console.WriteLine($"Имя: {name}");
        Console.WriteLine($"Город: {city}");
        Console.WriteLine($"Возраст: {age}");
        Console.WriteLine($"PIN-код: {pin}");
    }
}
