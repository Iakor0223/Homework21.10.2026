using System;

class Program
{
    enum AccountType { Current, Savings }

    // 1. Создаем структуру данных для банковского счета
    struct BankAccount
    {
        public string Number;      // Номер счета
        public AccountType Type;   // Тип счета
        public decimal Balance;    // Баланс
    }

    static void Main()
    {
        // 2. Создаем и заполняем переменную типа структуры
        BankAccount account;
        account.Number = "1234-5678-9012";
        account.Type = AccountType.Current;
        account.Balance = 150000.50m;

        // 3. Напечатать результат
        Console.WriteLine("Информация о счете:");
        Console.WriteLine($"Номер: {account.Number}");
        Console.WriteLine($"Тип: {account.Type}");
        Console.WriteLine($"Баланс: {account.Balance} руб.");
    }
}

