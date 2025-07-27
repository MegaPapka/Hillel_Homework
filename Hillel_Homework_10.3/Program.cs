Console.Write("Введіть рядок зі словами, розділеними комами: ");
string input = Console.ReadLine();

string cleaned = input.Replace(" ", "");

Console.WriteLine("Результат без пробілів:");
Console.WriteLine(cleaned);