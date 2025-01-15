// See https://aka.ms/new-console-template for more information

namespace DiceRollingSimulator {
    class Program
    {
        public static void Main(string[] args)
        {
            int rolls = 0;

            WriteLine("Welcome to the Dice throwing similator!\n\nHow many dice rolls would you like to simulate?\n");

            rolls = int.Parse(ReadLine());

            WriteLine(
                "\nDICE ROLLING SIMULATION RESULTS\n\nEach \"*\" represents 1% of the total number of rolls.\n\nTotal number of rolls = " +
                rolls + ".\n");

            DiceRoller diceRoller = new DiceRoller();
            
            int[] rollCounts= diceRoller.RollDice(rolls);
            
            string[] totalAsterisks = new string[11];
            string results = "";

            for (int i = 0; i < 11; i++)
            {
                int numAsterisks = Convert.ToInt32(Math.Round((double)rollCounts[i] / ((double)rolls / 100)));
                string asterisks = "";

                for (int j = 0; j < numAsterisks; j++)
                {
                    asterisks = asterisks + "*";
                    totalAsterisks[i] = asterisks;
                }

                results = results + (i + 2) + ": " + totalAsterisks[i] + "\n";
            }

            WriteLine(results);
            WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}