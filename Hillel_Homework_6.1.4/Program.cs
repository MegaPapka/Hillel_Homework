//Перевірка паролю
Console.WriteLine("The password must contain at least 8 characters, 1 digit, and 1 special character (!, @, #).");

bool isPasswordValid = false;

while (!isPasswordValid)
{
    Console.Write("Enter your password: ");
    string password = Console.ReadLine();

    bool hasAtLeast8Chars = password.Length >= 8;
    bool hasDigit = false;
    bool hasSpecialChar = false;
    string specialCharacters = "!@#";

    for (int i = 0; i < password.Length; i++)
    {
        char symbol = password[i];

        if (symbol >= '0' && symbol <= '9')
        {
            hasDigit = true;
        }
        if (specialCharacters.Contains(symbol))
        {
            hasSpecialChar = true;
        }
    }

    isPasswordValid = hasAtLeast8Chars && hasDigit && hasSpecialChar;

    if (!isPasswordValid)
    {
        Console.WriteLine("The password does not meet the requirements:");
        if (!hasAtLeast8Chars)
        {
            Console.WriteLine("It must be at least 8 characters long.");
        }
        if (!hasDigit)
        {
            Console.WriteLine("It must contain at least one digit.");
        }
        if (!hasSpecialChar)
        {
            Console.WriteLine("It must include one of the following characters: !, @, #.");
        }
    }
}

Console.WriteLine("Password accepted.");