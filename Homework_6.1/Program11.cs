//Генерація простих чисел
Console.Write("Enter a number: ");
int enteredNumber = Convert.ToInt32(Console.ReadLine());
for (int prostNumber = 1; prostNumber <= enteredNumber; prostNumber++)
{
    bool isDivisible = false;
    for (int i = 2; i < prostNumber; i++)
    {
        isDivisible = prostNumber % i == 0;
        if (isDivisible)
        {
            break;
        }
    }

    if (!isDivisible)
    {
        Console.WriteLine(prostNumber);
    }
}