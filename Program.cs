using System;

namespace DeliverableTwo
{
    class CoinToss
    {
        private string flipCoin()
        {
            var rand = new Random();
            int flipResult = rand.Next(0, 2);
            if (flipResult == 0)
            {
                return "Heads";
            } else {
                return "Tails";
            }
        }
        static void Main(string[] args)
        {
            string headsOrTailsGuess = "";
            int numberOfFlips = 1;
            int correctCount = 0;
            CoinToss ct = new CoinToss();

            Console.Write("Guess which will have more: heads or tails? ");
            headsOrTailsGuess = Console.ReadLine();
            Console.Write("How many times shall we flip a coin? ");
            numberOfFlips = Convert.ToInt32(Console.ReadLine());
            Console.Write(Environment.NewLine);
            int origNumberOfFlips = numberOfFlips;

            while (numberOfFlips > 0)
            {
                string result = ct.flipCoin();
                Console.WriteLine(result);
                result = result.ToLower();
                if (result.Equals(headsOrTailsGuess.ToLower()))
                {
                    correctCount++;
                }
                numberOfFlips -= 1;
            }
            double percentage = (double) correctCount / origNumberOfFlips * 100;
            Console.WriteLine(Environment.NewLine + "Your guess, " + headsOrTailsGuess + ", came up " + correctCount + " time(s).");
            Console.WriteLine("That's " + percentage + "%"); 

        }
    }
}
