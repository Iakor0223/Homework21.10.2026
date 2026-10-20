using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Вывод максимальных и минимальных значений для встроенных типов:\n");

        Console.WriteLine($"int – {int.MaxValue} – {int.MinValue}");
        Console.WriteLine($"short – {short.MaxValue} – {short.MinValue}");
        Console.WriteLine($"long – {long.MaxValue} – {long.MinValue}");
        Console.WriteLine($"float – {float.MaxValue} – {float.MinValue}");
        Console.WriteLine($"double – {double.MaxValue} – {double.MinValue}");
        Console.WriteLine($"byte – {byte.MaxValue} – {byte.MinValue}");
    }
}
