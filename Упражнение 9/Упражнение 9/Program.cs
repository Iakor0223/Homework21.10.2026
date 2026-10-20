using System;

// Структура напитка
struct Drink
{
    public string Name;          // Наименование типа напитка
    public double AlcoholPercent; // Процент спирта (например, 40.0 для водки)
}

// Структура студента
struct Student
{
    public string LastName;       // Фамилия
    public string FirstName;      // Имя
    public string Id;             // Идентификатор
    public DateTime BirthDate;    // Дата рождения
    public char AlcoholCategory;  // Категория алкоголизма (a, b, c, d)
    public double VolumeDrank;    // Объем выпитой жидкости (в литрах или мл)
    public Drink FavoriteDrink;   // Студент пьет один вид напитка
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Задача 6: Анализ объемов потребления алкоголя студентами");
        Console.WriteLine("Создание базы данных из 5 студентов и подсчет общей статистики.\n");

        // 1. Создаем доступные напитки
        Drink beer = new Drink { Name = "Пиво", AlcoholPercent = 5.0 };
        Drink wine = new Drink { Name = "Вино", AlcoholPercent = 12.0 };
        Drink vodka = new Drink { Name = "Водка", AlcoholPercent = 40.0 };

        // 2. Создаем массив из 5 студентов с разными параметрами
        Student[] students = new Student[5]
        {
            new Student { LastName = "Якубов", FirstName = "Магомед", Id = "ST001", BirthDate = new DateTime(2008, 2, 23), AlcoholCategory = 'a', VolumeDrank = 2.5, FavoriteDrink = beer },
            new Student { LastName = "Юсупов", FirstName = "Аюб", Id = "ST002", BirthDate = new DateTime(2004, 11, 23), AlcoholCategory = 'b', VolumeDrank = 1.0, FavoriteDrink = wine },
            new Student { LastName = "Багандов", FirstName = "Руслан", Id = "ST003", BirthDate = new DateTime(2008, 11, 18), AlcoholCategory = 'c', VolumeDrank = 0.5, FavoriteDrink = vodka },
            new Student { LastName = "Казавкаев", FirstName = "Хасболат", Id = "ST004", BirthDate = new DateTime(2008, 10, 14), AlcoholCategory = 'd', VolumeDrank = 0.0, FavoriteDrink = beer },
            new Student { LastName = "Темерханов", FirstName = "Гамзат", Id = "ST005", BirthDate = new DateTime(2007, 9, 30), AlcoholCategory = 'a', VolumeDrank = 1.5, FavoriteDrink = vodka }
        };

        double totalVolume = 0;       // Общий объем всей жидкости
        double totalPureAlcohol = 0;  // Общий объем чистого спирта

        // 3. Считаем параметры для каждого студента
        Console.WriteLine("Список студентов и их показатели:");
        foreach (var student in students)
        {
            double pureAlcohol = student.VolumeDrank * (student.FavoriteDrink.AlcoholPercent / 100.0);
            totalVolume += student.VolumeDrank;
            totalPureAlcohol += pureAlcohol;

            Console.WriteLine($"- {student.LastName} {student.FirstName} (Кат. {student.AlcoholCategory}): выпил {student.VolumeDrank} л. напитка '{student.FavoriteDrink.Name}' (чистый спирт: {pureAlcohol:F3} л.)");
        }

        // 4. Считаем итоговые проценты
        double totalAlcoholPercent = totalVolume > 0 ? (totalPureAlcohol / totalVolume) * 100.0 : 0;

        Console.WriteLine($"Общий объем выпитой жидкости: {totalVolume:F2} л.");
        Console.WriteLine($"Общий объем чистого алкоголя: {totalPureAlcohol:F3} л.");
        Console.WriteLine($"Общий процент алкоголя от общего количества жидкости: {totalAlcoholPercent:F2}%");
    }
}
