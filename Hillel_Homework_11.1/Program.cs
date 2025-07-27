string secretWord = "собака";
char[] maskedWord = new string('_', secretWord.Length).ToCharArray();
int maxMistakes = 6;
int mistakes = 0;

HashSet<char> guessedLetters = new HashSet<char>();

Console.WriteLine("Вітаємо! Спробуйте вгадати зашифроване слово!");
Console.WriteLine($"Кількість літер у слові: {secretWord.Length}");
Console.WriteLine($"Кількість можливих невірних спроб: {maxMistakes}");

while (mistakes < maxMistakes && new string(maskedWord) != secretWord)
{
    Console.WriteLine($"\nПоточне слово: {new string(maskedWord)}");
    Console.Write("Введіть вашу літеру: ");
    string input = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(input) || input.Length != 1)
    {
        Console.WriteLine("Введіть лише одну літеру.");
        continue;
    }

    char letter = char.ToLower(input[0]);

    if (guessedLetters.Contains(letter))
    {
        Console.WriteLine("Ви вже вводили цю літеру.");
        continue;
    }

    guessedLetters.Add(letter);

    if (secretWord.Contains(letter))
    {
        List<int> positions = new List<int>();
        for (int i = 0; i < secretWord.Length; i++)
        {
            if (secretWord[i] == letter)
            {
                maskedWord[i] = letter;
                positions.Add(i + 1); // Позиції з 1
            }
        }
        Console.WriteLine($"Така літера є у слові! Позиція(ї): {string.Join(",", positions)}");
    }
    else
    {
        mistakes++;
        Console.WriteLine($"Такої літери немає! Залишилось спроб: {maxMistakes - mistakes}");
    }
}

if (new string(maskedWord) == secretWord)
{
    Console.WriteLine($"\nВітаємо, ви вгадали слово! Зашифроване слово: {secretWord}.");
}
else
{
    Console.WriteLine($"\nВи програли. Загадане слово було: {secretWord}.");
}

Console.WriteLine("Дякуємо за гру.");