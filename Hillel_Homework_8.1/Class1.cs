using System;

namespace Hillel_Homework_8._1;

public class Class1
{
//Завдання 5
class Program
{
    enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    static void Main()
    {
        Console.Write("Введіть кількість днів: ");
        int days;
        while (!int.TryParse(Console.ReadLine(), out days) || days < 0)
        {
            Console.Write("Введіть невід’ємне ціле число: ");
        }

        int resultIndex = days % 7;
        DayOfWeek resultDay = (DayOfWeek)resultIndex;

        Console.WriteLine($"День через {days} днів від понеділка: {resultDay}");
    }
}
}
