namespace Dice.Roll.UserCommunication;

public static class ConsoleReader
{
    public static int ReadInteger(string message)
    {
        int parsedResult;
        do
        {
            Console.WriteLine(message);
        } while (!int.TryParse(Console.ReadLine(), out parsedResult));

        return parsedResult;
    }
}