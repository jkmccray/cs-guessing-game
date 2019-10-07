using System;

namespace GuessingGame
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Please choose a difficulty (easy, medium, or hard):");
      string difficulty = Console.ReadLine().ToLower();

      Random randomNumberGenerator = new Random();
      int secretNumber = randomNumberGenerator.Next(1, 101);

      int numGuesses = 0;

      if (difficulty == "easy")
      {
        numGuesses = 8;
      }
      else if (difficulty == "medium")
      {
        numGuesses = 6;

      }
      else if (difficulty == "hard")
      {
        numGuesses = 4;
      }
      else if (difficulty == "cheater")
      {
        string guess = "";
        int intGuess = 0;
        while (intGuess != secretNumber)
        {
          Console.Write($"Your guess> ");
          guess = Console.ReadLine();
          intGuess = int.Parse(guess);
          if (intGuess == secretNumber)
          {
            Console.WriteLine("You got it right");
          }
          else if (intGuess > secretNumber)
          {
            Console.WriteLine("Your guess was too high");
          }
          else
          {
            Console.WriteLine("Your guess was too low");
          }
        }
      }
      else
      {
        Console.WriteLine("Please choose easy, medium, or hard. Run the program again.");
      }

      if (numGuesses > 0)
      {
        Console.WriteLine("Please guess a number");
      }

      for (int i = 0; i < numGuesses; i++)
      {
        Console.Write($"Your guess ({numGuesses - i})> ");
        string guess = Console.ReadLine();
        int intGuess = int.Parse(guess);
        if (intGuess == secretNumber)
        {
          Console.WriteLine("You got it right");
          break;
        }
        else if (intGuess > secretNumber)
        {
          Console.WriteLine("Your guess was too high");
        }
        else //intGuess must be less than secretNumber
        {
          Console.WriteLine("Your guess was too low");
        }
      }

    }
  }
}
