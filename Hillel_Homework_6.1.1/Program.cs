// Рахуєм середні бабкі по работнікам
decimal zagalniBabki = 0;
int robotniki = 0;

for (robotniki = 1; robotniki <= 5; robotniki++)
{
    Console.Write($"Enter a zarplata robotnika {robotniki}: ");
    decimal zarplata = Convert.ToDecimal(Console.ReadLine());
    zagalniBabki += zarplata;
}

Console.WriteLine($"Middle zarplata robotnikiv: {zagalniBabki / robotniki}");