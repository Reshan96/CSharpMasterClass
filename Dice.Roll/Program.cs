using Dice.Roll.Game;

var ranodm = new Random();
var dice = new Dice.Roll.Game.Dice(ranodm);
var guessingGame = new GuessingGame(dice);

var gameResult = guessingGame.Play();
GuessingGame.PrintResult(gameResult);

Console.ReadKey();