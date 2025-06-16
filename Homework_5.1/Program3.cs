Console.Write("Enter a integer number 1: ");
decimal firstNumber = Convert.ToDecimal(Console.ReadLine());

Console.Write("Enter a integer number 2: ");
decimal secondNumber  = Convert.ToDecimal(Console.ReadLine());

try
{
    Console.WriteLine(firstNumber / secondNumber);
}
catch (Exception)
{
    Console.WriteLine("Something went wrong");
}
finally
{
    Console.WriteLine("Calculation ended");
}