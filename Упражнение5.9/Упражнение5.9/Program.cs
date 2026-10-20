using System;

class Program
{
    // Перечисление для уровня ворчливости
    enum GrumpinessLevel
    {
        Низкий,
        Средний,
        Высокий,
        Экстремальный
    }

    // Структура Дед
    struct Grandfather
    {
        public string Name;
        public GrumpinessLevel Grumpiness;
        public string[] GrumblePhrases;
        public int BruisesCount;

        // Конструктор структуры
        public Grandfather(string name, GrumpinessLevel grumpiness, string[] phrases)
        {
            Name = name;
            Grumpiness = grumpiness;
            GrumblePhrases = phrases;
            BruisesCount = 0; // По умолчанию 0 синяков
        }

        /// <summary>
        /// Проверяет лексику деда на наличие запрещенных слов и начисляет синяки.
        /// </summary>
        /// <param name="badWords">Список запрещенных слов (матерных).</param>
        /// <returns>Количество полученных фингалов.</returns>
        public int CheckLinguisticsAndGetBruised(params string[] badWords)
        {
            int newBruises = 0;

            if (GrumblePhrases == null || badWords == null)
                return 0;

            // Проверяем каждую фразу деда
            foreach (string phrase in GrumblePhrases)
            {
                // Проверяем каждое запрещенное слово из списка params
                foreach (string word in badWords)
                {
                    // Проверка без учета регистра (чтобы ловило и "Слово", и "слово")
                    if (phrase.Contains(word, StringComparison.OrdinalIgnoreCase))
                    {
                        newBruises++;
                    }
                }
            }

            // Увеличиваем общее количество синяков у деда
            BruisesCount += newBruises;
            return newBruises;
        }
    }

    static void Main()
    {
        // Создаем 5 дедов с разным количеством фраз
        Grandfather[] grandfathers = new Grandfather[5]
        {
            new Grandfather("Иваныч", GrumpinessLevel.Низкий,
                new string[] { "Эх, молодежь!", "Погода плохая" }),

            new Grandfather("Петрович", GrumpinessLevel.Средний,
                new string[] { "Проститутки!", "Раньше было лучше", "Опять дороги не сделали" }),

            new Grandfather("Степаныч", GrumpinessLevel.Высокий,
                new string[] { "Гады!", "Вот блин, опять сломалось", "Что за хрень происходит", "Цены растут" }),

            new Grandfather("Михалыч", GrumpinessLevel.Экстремальный,
                new string[] { "Черти полосатые!", "Всех сажать надо!", "Ну и хрень", "Грёбаный насос!", "Тунеядцы!" }),

            new Grandfather("Палыч", GrumpinessLevel.Низкий,
                new string[] { "Где мои очки?" })
        };

        // Список "матерных/запрещенных" слов для проверки бабки
        string[] forbiddenWords = { "блин", "хрень", "грёбаный" };

        Console.WriteLine("--- Проверка дедов бабкой --- \n");

        // Бабка проверяет лексику каждого деда
        for (int i = 0; i < grandfathers.Length; i++)
        {
            // Передаем список запрещенных слов через params
            int receivedBruises = grandfathers[i].CheckLinguisticsAndGetBruised(forbiddenWords);

            Console.WriteLine($"Дед: {grandfathers[i].Name} ({grandfathers[i].Grumpiness} уровень ворчливости)");
            Console.WriteLine($"Фраз для ворчания: {grandfathers[i].GrumblePhrases.Length}");
            Console.WriteLine($"Получено фингалов за этот раз: {receivedBruises}");
            Console.WriteLine($"Всего синяков теперь: {grandfathers[i].BruisesCount}");
            Console.WriteLine(new string('-', 40));
        }
    }
}
