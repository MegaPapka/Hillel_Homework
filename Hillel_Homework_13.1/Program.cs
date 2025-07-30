using System;
using System.Collections.Generic;

class Program
{
    class ToDoItem
    {
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
    }

    static List<ToDoItem> toDoList = new List<ToDoItem>();

    static void Main()
    {
        string choice;

        do
        {
            Console.WriteLine("\nTo-Do List");
            Console.WriteLine("1. Додати справу");
            Console.WriteLine("2. Показати всі справи");
            Console.WriteLine("3. Позначити справу як виконану");
            Console.WriteLine("4. Видалити справу");
            Console.WriteLine("5. Завантажити список справ");
            Console.WriteLine("0. Вийти");
            Console.Write("Ваш вибір: ");
            choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ShowTasks();
                    break;
                case "3":
                    MarkAsDone();
                    break;
                case "4":
                    DeleteTask();
                    break;
                case "5":
                    LoadTasks();
                    break;
                case "0":
                    Console.WriteLine("Дякуємо за користування!");
                    break;
                default:
                    Console.WriteLine("Некоректний вибір.");
                    break;
            }

        } while (choice != "0");
    }

    static void AddTask()
    {
        Console.Write("Введіть назву справи: ");
        string title = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(title))
        {
            Console.WriteLine("Назва справи не може бути порожньою.");
            return;
        }

        toDoList.Add(new ToDoItem { Title = title, IsCompleted = false });
        Console.WriteLine("Справу додано.");
    }

    static void ShowTasks()
    {
        if (toDoList.Count == 0)
        {
            Console.WriteLine("📭 Список справ порожній.");
            return;
        }

        Console.WriteLine("📋 Список справ:");
        for (int i = 0; i < toDoList.Count; i++)
        {
            var item = toDoList[i];
            string status = item.IsCompleted ? "[✓]" : "[ ]";
            Console.WriteLine($"{i + 1}. {status} {item.Title}");
        }
    }

    static void MarkAsDone()
    {
        ShowTasks();
        if (toDoList.Count == 0) return;

        Console.Write("Введіть номер справи для позначення як виконаної: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= toDoList.Count)
        {
            toDoList[index - 1].IsCompleted = true;
            Console.WriteLine("Справу позначено як виконану.");
        }
        else
        {
            Console.WriteLine("Невірний номер справи.");
        }
    }

    static void DeleteTask()
    {
        ShowTasks();
        if (toDoList.Count == 0) return;

        Console.Write("Введіть номер справи для видалення: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= toDoList.Count)
        {
            toDoList.RemoveAt(index - 1);
            Console.WriteLine("Справу видалено.");
        }
        else
        {
            Console.WriteLine("Невірний номер справи.");
        }
    }

    static void LoadTasks()
    {
        if (toDoList.Count == 0)
            Console.WriteLine("Список справ порожній.");
        else
            ShowTasks();
    }
}
