Console.Write("Введіть ім’я та прізвище: ");
string input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Ви ввели некоректні дані.");
    return;
}

string[] parts = input.Trim().Split(' ');

if (parts.Length < 2)
{
    Console.WriteLine("Будь ласка, введіть і ім’я, і прізвище.");
    return;
}

string firstName = parts[0];
string lastName = parts[1];

if (char.ToUpper(firstName[0]) == char.ToUpper(lastName[0]))
{
    Console.WriteLine("Прізвище починається на ту ж літеру, що ім’я.");
}
else
{
    Console.WriteLine("Прізвище не починається на ту ж літеру, що ім’я.");
}