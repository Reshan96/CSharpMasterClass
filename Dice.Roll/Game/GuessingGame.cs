using Dice.Roll.UserCommunication;

namespace Dice.Roll.Game;

class GuessingGame(Dice dice)
{
    private const int InitialTries = 3;

    public GameResult Play()
    {
        var diceRolledResult = dice.Roll();
        Console.WriteLine("Dice rolled. Guess what number it shows in {0} tries.", InitialTries);

        var triesLeft = InitialTries;

        while (triesLeft > 0)
        {
            var guess = ConsoleReader.ReadInteger("Enter number:");

            if (guess == diceRolledResult)
                return GameResult.Won;

            Console.WriteLine("Wrong number");
            triesLeft--;
        }

        return GameResult.Lost;
    }

    public static void PrintResult(GameResult result)
    {
        Console.WriteLine(result == GameResult.Won ? "You won!" : "You Lost :(");
    }

}

