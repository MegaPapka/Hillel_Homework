//Калькулятор оплати праці за годину
int workedHours = 1;

while (workedHours > 0)
{
    Console.Write("Enter a number of worked hours: ");
    workedHours = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter a number of money per hour: ");
    int moneyPerHour = Convert.ToInt32(Console.ReadLine());

    int totalMoney = workedHours * moneyPerHour;
    Console.Write($"Total money earned: {totalMoney} USDT");

    Console.WriteLine();
}

Console.WriteLine("You don`t rabotal today. No money for you(");