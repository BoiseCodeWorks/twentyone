using System;

namespace twentyone
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Console.WriteLine(@"Let's play a game: 
            ");
      bool playing = true;
      while (playing)
      {
        int hand = 0;
        bool activeGame = true;
        while (activeGame)
        {
          Random random = new Random();
          hand += random.Next(1, 11);
          if (hand > 21)
          {
            System.Console.WriteLine($" {hand} YOU BUST!");
            activeGame = false;

          }
          else
          {
            Console.WriteLine($"You will start at {hand} choose to 'hit' or 'stay'");
            string choice = Console.ReadLine().ToLower();
            if (choice == "stay")
            {
              if (hand > 16 && hand < 22)
              {
                Console.WriteLine("Winner Winner Chicken Dinner!");
                activeGame = false;
              }
              else
              {
                Console.WriteLine("Game Over: No Cigar");
              }
            }
            else if (choice != "hit")
            {
              System.Console.WriteLine("Get out of my Casino");
              activeGame = false;
            }
            else
            {
              System.Console.WriteLine("Good Choice!");
            }

          }
        }
        System.Console.WriteLine("Play Again?");
        string again =Console.ReadLine();
        
      }

    }
  }
}
