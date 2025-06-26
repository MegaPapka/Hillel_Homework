//Побудова графіку зірочками
Console.Write("Enter a number: ");
int enteredNumber = Convert.ToInt32(Console.ReadLine());

for (int quantity = 1; quantity <= enteredNumber; quantity++)
{

    for (int quantiyStars = 1; quantiyStars <= quantity; quantiyStars++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}