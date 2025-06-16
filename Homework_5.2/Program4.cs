Console.Write("Enter number: ");

try
{
    string input = Console.ReadLine();
    decimal number = Convert.ToDecimal(input);
    
    Console.WriteLine($"The number is: {number}");
}
catch (Exception)
{
    Console.WriteLine("Entered not number");
}
finally
{
    Console.WriteLine("Calculation ended");
}