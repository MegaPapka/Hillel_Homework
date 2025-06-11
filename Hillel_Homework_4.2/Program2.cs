using System.Numerics;

Console.Write("Enter a integer number 1: ");
decimal firstNumber = Convert.ToDecimal(Console.ReadLine());

Console.Write("Enter a integer number 2: ");
decimal secondNumber  = Convert.ToDecimal(Console.ReadLine());

decimal resultPlus = firstNumber + secondNumber;
decimal resultMinus = firstNumber - secondNumber;
decimal resultMultiply = firstNumber * secondNumber;
decimal resultDivide = firstNumber / secondNumber;

Console.Write("Enter a mathematical operation (+ - * or /): ");
string mathOperation = Console.ReadLine();

switch (mathOperation)
{
    case "+":
        Console.WriteLine(resultPlus);
        break;
    case "-":
        Console.WriteLine(resultMinus);
        break;
    case "*":
        Console.WriteLine(resultMultiply);
        break;
    case "/":
        Console.WriteLine(resultDivide);
        break;
    default:
        Console.WriteLine("Error, enter please a mathematical operation (+ - * or /)");
        break;
}