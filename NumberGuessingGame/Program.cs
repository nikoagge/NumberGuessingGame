using System;

namespace NumberGuessingGame
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random randomInstance = new Random();
            int winningNumber = randomInstance.Next(0, 13);
            bool win = false;

            do
            {
                Console.Write("Guess a number inbetween 0 and 13: ");
                string inputNumberStringFormat = Console.ReadLine();
                int inputNumberIntFormat = int.Parse(inputNumberStringFormat);

                if (inputNumberIntFormat > winningNumber)
                {
                    Console.WriteLine("Too high! Guess lower...");
                } else if (inputNumberIntFormat < winningNumber)
                {
                    Console.WriteLine("Go low! Guess higher...");
                } else if (inputNumberIntFormat == winningNumber)
                {
                    Console.WriteLine("You won!");
                    win = true;
                }
                Console.WriteLine();
            } while (win == false);

            Console.WriteLine("Thanks for playing! Press any key to finish...");
            Console.ReadKey(true);
        }
    }
}
