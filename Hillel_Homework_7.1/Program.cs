// Хрестики-нулики
Console.WriteLine("Game Start!");

// Ініціалізація змінних для перемоги
bool peremoga1 = false;
bool peremoga2 = false;

// Ініціалізація змінних для ігрового поля
char firstValue = '1';
char secondValue = '2';
char thirdValue = '3';
char fourthValue = '4';
char fifthValue = '5';
char sixValue = '6';
char sevenValue = '7';
char eightValue = '8';
char nineValue = '9';

// Цикл гри
for (int gameTurn = 0; gameTurn < 9; gameTurn++)
{
    // Відображення ігрового поля
    Console.WriteLine();
    Console.WriteLine($"{firstValue} | {secondValue} | {thirdValue}");
    Console.WriteLine("---------");
    Console.WriteLine($"{fourthValue} | {fifthValue} | {sixValue}");
    Console.WriteLine("---------");
    Console.WriteLine($"{sevenValue} | {eightValue} | {nineValue}");

    // Перевірка на перемогу для гравця 1
    if (peremoga1 = firstValue == 'X' && secondValue == 'X' && thirdValue == 'X' || fourthValue == 'X' && fifthValue == 'X' && sixValue == 'X' || sevenValue == 'X' && eightValue == 'X' && nineValue == 'X')
    {
        Console.WriteLine();
        Console.WriteLine("Game Over! Player 1 wins!");
        break;
    }
    else if (peremoga1 = firstValue == 'X' && fourthValue == 'X' && sevenValue == 'X' || secondValue == 'X' && fifthValue == 'X' && eightValue == 'X' || thirdValue == 'X' && sixValue == 'X' && nineValue == 'X')
    {
        Console.WriteLine();
        Console.WriteLine("Game Over! Player 1 wins!");
        break;
    }
    else if (peremoga1 = firstValue == 'X' && fifthValue == 'X' && nineValue == 'X' || thirdValue == 'X' && fifthValue == 'X' && sevenValue == 'X')
    {
        Console.WriteLine();
        Console.WriteLine("Game Over! Player 1 wins!");
        break;
    }

    // Перевірка на перемогу гравця 2
    if (peremoga2 = firstValue == 'O' && secondValue == 'O' && thirdValue == 'O' || fourthValue == 'O' && fifthValue == 'O' && sixValue == 'O' || sevenValue == 'O' && eightValue == 'O' && nineValue == 'O')
    {
        Console.WriteLine();
        Console.WriteLine("Game Over! Player 2 wins!");
        break;
    }
    else if (peremoga2 = firstValue == 'O' && fourthValue == 'O' && sevenValue == 'O' || secondValue == 'O' && fifthValue == 'O' && eightValue == 'O' || thirdValue == 'O' && sixValue == 'O' && nineValue == 'O')
    {
        Console.WriteLine();
        Console.WriteLine("Game Over! Player 2 wins!");
        break;
    }
    else if (peremoga2 = firstValue == 'O' && fifthValue == 'O' && nineValue == 'O' || thirdValue == 'O' && fifthValue == 'O' && sevenValue == 'O')
    {
        Console.WriteLine();
        Console.WriteLine("Game Over! Player 2 wins!");
        break;
    }

    // Перемикання гравців
    if (gameTurn % 2 == 0)
    {
        Console.WriteLine();
        Console.Write("Player 1's turn (X): ");
        char player1Move = Console.ReadKey().KeyChar;
        Console.WriteLine();

        // Перевірка на правильність введення числа для гравця 1
        if (player1Move < '1' || player1Move > '9')
        {
            Console.WriteLine();
            Console.WriteLine("Invalid move! Please choose a number between 1 and 9.");
            gameTurn--;
            continue;
        }

        // Перевірка на зайнятість клітинки для гравця 1
        if (firstValue == 'X' && player1Move == '1' || secondValue == 'X' && player1Move == '2' || thirdValue == 'X' && player1Move == '3' || fourthValue == 'X' && player1Move == '4' || fifthValue == 'X' && player1Move == '5' || sixValue == 'X' && player1Move == '6' || sevenValue == 'X' && player1Move == '7' || eightValue == 'X' && player1Move == '8' || nineValue == 'X' && player1Move == '9')
        {
            Console.WriteLine();
            Console.WriteLine("This cell is already occupied! Please choose another cell.");
            gameTurn--;
            continue;
        }
        else if (firstValue == 'O' && player1Move == '1' || secondValue == 'O' && player1Move == '2' || thirdValue == 'O' && player1Move == '3' || fourthValue == 'O' && player1Move == '4' || fifthValue == 'O' && player1Move == '5' || sixValue == 'O' && player1Move == '6' || sevenValue == 'O' && player1Move == '7' || eightValue == 'O' && player1Move == '8' || nineValue == 'O' && player1Move == '9')
        {
            Console.WriteLine();
            Console.WriteLine("This cell is already occupied! Please choose another cell.");
            gameTurn--;
            continue;
        }

        // Запис значення гравця 1 в ігрове поле
        if (player1Move == '1')
        {
            firstValue = 'X';
        }
        else if (player1Move == '2')
        {
            secondValue = 'X';
        }
        else if (player1Move == '3')
        {
            thirdValue = 'X';
        }
        else if (player1Move == '4')
        {
            fourthValue = 'X';
        }
        else if (player1Move == '5')
        {
            fifthValue = 'X';
        }
        else if (player1Move == '6')
        {
            sixValue = 'X';
        }
        else if (player1Move == '7')
        {
            sevenValue = 'X';
        }
        else if (player1Move == '8')
        {
            eightValue = 'X';
        }
        else if (player1Move == '9')
        {
            nineValue = 'X';
        }

    }
    else
    {
        Console.WriteLine();
        Console.Write("Player 2's turn (O): ");
        char player2Move = Console.ReadKey().KeyChar;
        Console.WriteLine();

        // Перевірка на правильність введення числа для гравця 2
        if (player2Move < '1' || player2Move > '9')
        {
            Console.WriteLine();
            Console.WriteLine("Invalid move! Please choose a number between 1 and 9.");
            gameTurn--;
            continue;
        }

        // Перевірка на зайнятість клітинки для гравця 2
        if (firstValue == 'O' && player2Move == '1' || secondValue == 'O' && player2Move == '2' || thirdValue == 'O' && player2Move == '3' || fourthValue == 'O' && player2Move == '4' || fifthValue == 'O' && player2Move == '5' || sixValue == 'O' && player2Move == '6' || sevenValue == 'O' && player2Move == '7' || eightValue == 'O' && player2Move == '8' || nineValue == 'O' && player2Move == '9')
        {
            Console.WriteLine();
            Console.WriteLine("This cell is already occupied! Please choose another cell.");
            gameTurn--;
            continue;
        }
        else if (firstValue == 'X' && player2Move == '1' || secondValue == 'X' && player2Move == '2' || thirdValue == 'X' && player2Move == '3' || fourthValue == 'X' && player2Move == '4' || fifthValue == 'X' && player2Move == '5' || sixValue == 'X' && player2Move == '6' || sevenValue == 'X' && player2Move == '7' || eightValue == 'X' && player2Move == '8' || nineValue == 'X' && player2Move == '9')
        {
            Console.WriteLine();
            Console.WriteLine("This cell is already occupied! Please choose another cell.");
            gameTurn--;
            continue;
        }

        // Запис значення гравця 2 в ігрове поле
        if (player2Move == '1')
        {
            firstValue = 'O';
        }
        else if (player2Move == '2')
        {
            secondValue = 'O';
        }
        else if (player2Move == '3')
        {
            thirdValue = 'O';
        }
        else if (player2Move == '4')
        {
            fourthValue = 'O';
        }
        else if (player2Move == '5')
        {
            fifthValue = 'O';
        }
        else if (player2Move == '6')
        {
            sixValue = 'O';
        }
        else if (player2Move == '7')
        {
            sevenValue = 'O';
        }
        else if (player2Move == '8')
        {
            eightValue = 'O';
        }
        else if (player2Move == '9')
        {
            nineValue = 'O';
        }
    }

}

// Перевірка на нічию
if (peremoga1 != true && peremoga2 != true)
{
    Console.WriteLine();
    Console.WriteLine("Game Over! It's a draw!");
}