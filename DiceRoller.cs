namespace DiceRollingSimulator
{
    public class DiceRoller
    {
        public int[] RollDice(int r)
        {
            int userRolls = r;
            int[] totalRolls = new int[11];

            for (int i = 1; i <= userRolls; i++)
            {
                int dice1Value = 0;
                int dice2Value = 0;
                int finalRollValue = 0;

                Random dice1 = new Random();
                dice1Value = dice1.Next(1, 7); // Generates a number between 1 and 100 (inclusive)
                Random dice2 = new Random();
                dice2Value = dice2.Next(1, 7);

                finalRollValue = dice1Value + dice2Value;

                if (finalRollValue == 2)
                {
                    totalRolls[0]++;
                }
                else if (finalRollValue == 3)
                {
                    totalRolls[1]++;
                }
                else if (finalRollValue == 4)
                {
                    totalRolls[2]++;
                }
                else if (finalRollValue == 5)
                {
                    totalRolls[3]++;
                }
                else if (finalRollValue == 6)
                {
                    totalRolls[4]++;
                }
                else if (finalRollValue == 7)
                {
                    totalRolls[5]++;
                }
                else if (finalRollValue == 8)
                {
                    totalRolls[6]++;
                }
                else if (finalRollValue == 9)
                {
                    totalRolls[7]++;
                }
                else if (finalRollValue == 10)
                {
                    totalRolls[8]++;
                }
                else if (finalRollValue == 11)
                {
                    totalRolls[9]++;
                }
                else if (finalRollValue == 12)
                {
                    totalRolls[10]++;
                }
                else
                {

                }
            }

            return totalRolls;
        }
    }
}