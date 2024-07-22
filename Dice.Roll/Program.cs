
var random = new Random();
var nextNumber = random.Next(1, 7);

Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");

var userInput = Console.ReadLine();
do
{
    Console.WriteLine("Enter number:");

    if (string.IsNullOrEmpty(userInput) || !userInput.All(char.IsDigit))
    {
        Console.WriteLine("Incorrect input");
    }
    else if (int.TryParse(userInput, out int parsedResult))
    {
        if (parsedResult > 6 || parsedResult < 1)
        {
            Console.WriteLine("Wrong number");
            continue;
        }

        Console.WriteLine("You win.");
        break;
    }
    else
    {

    }

} while (expression);


Console.ReadKey();
