//Генерація фібоначчівської послідовності
Console.Write("Enter the quantit of Fiba number:");

int enteredNumber = Convert.ToInt32(Console.ReadLine());

int previousNumber = 0;
int currentNumber = 1;

Console.WriteLine("Fiba number: ");


for (int numOrder = 0; numOrder < enteredNumber; numOrder++)
{
    Console.Write(previousNumber + " ");

    int nextNumber = previousNumber + currentNumber;

    previousNumber = currentNumber;
    currentNumber = nextNumber;
}

Console.WriteLine();