Console.Write("Введіть номер числа Фібоначчі: ");
if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
{
    int result = FibonacciHelper.Fibonacci(n);
    Console.WriteLine($"Число Фібоначчі з номером {n}: {result}");
}
else
{
    Console.WriteLine("Введено некоректне число. Введіть ціле невід’ємне число.");
}