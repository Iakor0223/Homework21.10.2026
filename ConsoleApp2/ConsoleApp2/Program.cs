using System;

class Program
{
    // 1. Создаем перечислимый тип данных для видов банковского счета
    enum AccountType
    {
        Current,      // Текущий
        Savings       // Сберегательный
    }

    static void Main()
    {
        // 2. Создаем переменную типа перечисления и присваиваем значение
        AccountType myAccount = AccountType.Savings;

        // 3. Выводим значение на печать
        Console.WriteLine($"Вид банковского счета: {myAccount}");
    }
}