using System;

class Program
{
    // 1. Создаем перечислимый тип ВУЗ
    enum University { КГУ, КАИ, КХТИ }

    // 2. Создаем структуру работника
    struct Employee
    {
        public string Name;          // Имя
        public University Uni;       // ВУЗ
    }

    static void Main()
    {
        // 3. Заполняем структуру данными
        Employee worker;
        worker.Name = "Магомед Якубов";
        worker.Uni = University.КАИ;

        // 4. Распечатать данные
        Console.WriteLine($"Работник: {worker.Name}");
        Console.WriteLine($"Окончил ВУЗ: {worker.Uni}");
    }
}
