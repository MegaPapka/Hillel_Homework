Console.Write("Enter a integer number 1: ");
decimal firstNumber = Convert.ToDecimal(Console.ReadLine());

Console.Write("Enter a integer number 2: ");
decimal secondNumber  = Convert.ToDecimal(Console.ReadLine());

try
{
    if (secondNumber == 0)
        throw new DivisionByZeroException();
    else
        Console.WriteLine(firstNumber / secondNumber);
}
catch (DivideByZeroException)
{
    Console.WriteLine("You cannot divide by zero");
}
catch (Exception)
{
    Console.WriteLine("Something went wrong");
}
finally
{
    Console.WriteLine("Calculation ended");
}

public class DivisionByZeroException : Exception
{
    public DivisionByZeroException() : base()
    {
        
    }
}