//Завдання 1
int[] numbers = new int[10];
Random rand = new Random();

Console.WriteLine("\nЕлементи масиву:");
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rand.Next(-10, 11); // Next(min, max) включає min, але виключає max => -10 до 10
    Console.Write($"{numbers[i]} ");
}

Console.WriteLine("\nЕлементи з парними індексами:");
for (int i = 0; i < numbers.Length; i += 2)
{
    Console.WriteLine($"\nІндекс {i} - Значення {numbers[i]}");
}

//Завдання 2
int sum = 0;
foreach (int num in numbers)
{
    sum += num;
}

Console.WriteLine($"\nСума всіх елементів: {sum}");
if (sum >= 0)
{
    Console.WriteLine("\nСума невід'ємна.");
}
else
{
    Console.WriteLine("\nСума від'ємна.");
}

//Завдання 3
int[,] table = new int[9, 9];

for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        table[i, j] = (i + 1) * (j + 1);
    }
}

for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        Console.Write($"{table[i, j],3} ");
    }
    Console.WriteLine();
}

//Завдання 4
int[,] arr = new int[5, 5];
        Random rando = new Random();

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        arr[i, j] = rand.Next(-20, 21);
    }
}

Console.WriteLine("Масив:");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write($"{arr[i, j],4}");
    }
        Console.WriteLine();
}

int max = arr[0, 0], min = arr[0, 0];
int maxRow = 0, maxCol = 0, minRow = 0, minCol = 0;

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (arr[i, j] > max)
        {
            max = arr[i, j];
            maxRow = i;
            maxCol = j;
        }
        if (arr[i, j] < min)
        {
            min = arr[i, j];
            minRow = i;
            minCol = j;
        }
    }
}

Console.WriteLine($"\nМаксимальний елемент: {max})");
Console.WriteLine($"Мінімальний елемент: {min})");
Console.WriteLine($"Координати мінімального елемента: рядок {minRow}, стовпець {minCol}");
Console.WriteLine($"Координати максимального елемента: рядок {maxRow}, стовпець {maxCol}");