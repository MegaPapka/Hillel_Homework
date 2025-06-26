//Генерація простих чисел
Console.Write("Enter a natural number: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number > 0)
{
    if (number == 1)
    {
        Console.WriteLine("1 is not a prime number.");
    }
    else
    {
        bool isPrime = true;

        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
        {
            Console.WriteLine("This is a prime number.");
        }
        else
        {
            Console.WriteLine("This is not a prime number.");
        }
    }

    Console.Write("Enter a natural number: ");
    number = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("You entered not natural number!");