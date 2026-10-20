using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Задача 5: Расчет окупаемости отпуска через Duty Free");
        Console.WriteLine("Программа определит необходимое количество бутылок для покрытия расходов.\n");

        // Тестовый пример из задания: 
        // При цене 10 и скидке 10% экономия = 1. Если отпуск стоит 500, ответ должен быть 500.
        Console.Write("Введите стандартную цену бутылки (normPrice): ");
        double normPrice = double.Parse(Console.ReadLine());

        Console.Write("Введите скидку в Duty Free в процентах (salePrice, например, 10): ");
        double salePricePercent = double.Parse(Console.ReadLine());

        Console.Write("Введите стоимость отпуска (holidayPrice): ");
        double holidayPrice = double.Parse(Console.ReadLine());

        // Расчет экономии с одной бутылки
        double savingsPerBottle = normPrice * (salePricePercent / 100.0);

        if (savingsPerBottle <= 0)
        {
            Console.WriteLine("\nОшибка: Скидка отсутствует или цена некорректна. Отпуск не окупится.");
            return;
        }

        // Округляем в меньшую сторону до целого числа, как требует условие
        int bottlesNeeded = (int)Math.Floor(holidayPrice / savingsPerBottle);

        Console.WriteLine($"\nВам необходимо купить бутылок: {bottlesNeeded}");
    }
}

