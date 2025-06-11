string day1 = "Monday", day;
string day2 = "Tuesday";
string day3 = "Wednesday";
string day4 = "Thursday";
string day5 = "Friday";
string day6 = "Saturday";
string day7 = "Sunday";

Console.Write("Enter a integer between 1 and 7: ");
int dayOfWeek = Convert.ToInt16(Console.ReadLine());

switch (dayOfWeek)
{
    case 1:
        day = day1;
        break;
    case 2: 
        day = day2; 
        break;
    case 3:
        day = day3;
        break;
    case 4:
        day = day4;
        break;
    case 5:
        day = day5;
        break;
    case 6:
        day = day6;
        break;
    case 7:
        day = day7;
        break;
    default:
        day = "Error, entered integer is not between 1 and 7";
        break;
}

Console.WriteLine(day);