//Завдання 1
Random rand = new Random();
int size = 10;
int[] array = new int[size];

for (int i = 0; i < size; i++)
{
    array[i] = rand.Next(1, 101);
}

Console.WriteLine("Згенерований масив:");
foreach (int num in array)
{
    Console.Write(num + " ");
}
Console.WriteLine();

int max = int.MinValue;
int secondMax = int.MinValue;

foreach (int num in array)
{
    if (num > max)
    {
        secondMax = max;
        max = num;
    }
    else if (num > secondMax && num < max)
    {
        secondMax = num;
    }
}

if (secondMax == int.MinValue)
    Console.WriteLine("Другий найбільший елемент відсутній.");
else
    Console.WriteLine($"Другий найбільший елемент: {secondMax}");

//Завдання 2
int[,] matrix = {
    {5, 3, 8},
    {1, 9, 6}
};

int rows = matrix.GetLength(0);
int cols = matrix.GetLength(1);
int[] flat = new int[rows * cols];
int k = 0;

for (int i = 0; i < rows; i++)
    for (int j = 0; j < cols; j++)
        flat[k++] = matrix[i, j];

for (int i = 0; i < flat.Length - 1; i++)
    for (int j = 0; j < flat.Length - i - 1; j++)
        if (flat[j] > flat[j + 1])
        {
            int temp = flat[j];
            flat[j] = flat[j + 1];
            flat[j + 1] = temp;
        }

k = 0;
for (int i = 0; i < rows; i++)
    for (int j = 0; j < cols; j++)
        matrix[i, j] = flat[k++];

Console.WriteLine("Відсортована матриця:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
        Console.Write(matrix[i, j] + " ");
    Console.WriteLine();
}

//Завдання 3
int[] array3 = { 10, 20, 30, 40, 50 };
Console.WriteLine("Початковий масив:");
Console.WriteLine(string.Join(", ", array));

Console.Write("Введіть індекс елемента, який потрібно видалити: ");
int index = Convert.ToInt32(Console.ReadLine());

if (index < 0 || index >= array.Length)
{
    Console.WriteLine("Некоректний індекс!");
    return;
}

int[] newArray = new int[array.Length - 1];

for (int i = 0, j = 0; i < array.Length; i++)
{
    if (i == index) continue;
    newArray[j++] = array[i];
}

Console.WriteLine("Масив після видалення:");
Console.WriteLine(string.Join(", ", newArray));

Console.WriteLine(string.Join(", ", array3));
Console.WriteLine();

//Завдання 4
{
int[,] matrix4 = {
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};

int size4 = Math.Min(matrix4.GetLength(0), matrix4.GetLength(1));
int sum = 0;

for (int i = 0; i < size4; i++)
    sum += matrix[i, i];

Console.WriteLine($"Сума діагоналі: {sum}");
}