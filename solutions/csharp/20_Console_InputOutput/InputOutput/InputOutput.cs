using System;
using System;

namespace InputOutput;
public static class InputOutput
{
    public static void Main(string[] args)
    {
        var game = new Game(1, 100);

        Console.WriteLine("Hotter/Colder - New Game Starting");
        while (true) 
        {
            Console.WriteLine(String.Format("Guess a number from {0} to {1}: ", game.Min, game.Max));
            var guess = Console.ReadLine();
            var response = game.GetResponse(guess);
            if (response == HotColdResponse.Correct) 
            {
                Console.WriteLine("Correct!");
                Console.WriteLine("Game Over");
                break;
            }
            var textResponse = response switch 
            {
                HotColdResponse.InvalidInput => "Invalid input, try again",
                HotColdResponse.RepeatGuess => "Repeated guess, try again",
                HotColdResponse.Hot => "Hot",
                HotColdResponse.Warm => "Warm",
                HotColdResponse.Cold => "Cold",
                HotColdResponse.Colder => "Colder",
                HotColdResponse.Warmer => "Warmer",
                HotColdResponse.WarmerGettingHot => "Warmer, Getting Hot!",
                _ => "Error: unexpected response",
            };
            Console.WriteLine(textResponse);
        }
    }

}