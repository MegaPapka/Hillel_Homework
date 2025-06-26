//Генерація таблиці множення для конкретного числа

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int multiplication = 1; multiplication <= 10; multiplication++)
{
    int result = number * multiplication;
    Console.WriteLine($"{number} * {multiplication} = {result}");
}

Console.WriteLine("Multiplication complete");