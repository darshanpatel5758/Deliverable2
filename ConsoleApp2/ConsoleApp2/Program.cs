using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            int correctCount = 0;
            int tails = 0;
            int heads = 0;

            Console.Write("Guess which will have more: heads or tails?");
            string headsOrTailsGuess = Console.ReadLine();

            Console.WriteLine("How many times shall we flip a coin?");
            int numberOfFlips = Convert.ToInt32(Console.ReadLine());

            while (correctCount < numberOfFlips)
            {
                Random rnd = new Random();
                int result = rnd.Next(0, 2);
                if (result == 1)
                {
                    Console.WriteLine("Tails!");
                    tails = tails + 1;
                    correctCount = correctCount + 1;

                }
                else if (result == 0)
                {
                    Console.WriteLine("Heads!");
                    heads = heads + 1;
                    correctCount = correctCount + 1;
                }
            }

            if (headsOrTailsGuess.Contains("tails"))
            {
                Console.WriteLine("Your guess," + headsOrTailsGuess + ", came up " + tails + " time(s).");
                tails = tails * 100 / correctCount;
                Console.WriteLine("That's " + tails + "%");
            }
            else
            {
                Console.WriteLine("Your guess," + headsOrTailsGuess + ", came up " + heads + " time(s).");
                heads = heads * 100 / correctCount;
                Console.WriteLine("That's " + heads + "%");
            }
        }
    }
}
