using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder report = new StringBuilder();

        // Заголовок і дата
        report.AppendLine("Текстовий звіт");
        report.AppendLine($"Дата: {DateTime.Now.ToShortDateString()}");
        report.AppendLine("-----------------------------");
        report.AppendLine("Список подій:");

        Console.Write("Скільки подій ви хочете додати? ");
        if (!int.TryParse(Console.ReadLine(), out int count) || count <= 0)
        {
            Console.WriteLine("Некоректне число подій.");
            return;
        }

        for (int i = 1; i <= count; i++)
        {
            Console.Write($"Введіть подію №{i}: ");
            string input = Console.ReadLine();
            report.AppendLine($"– {input}");
        }

        report.AppendLine("-----------------------------");
        report.AppendLine("Кінець звіту.");

        Console.WriteLine("\nЗгенерований звіт:");
        Console.WriteLine(report.ToString());
    }
}
