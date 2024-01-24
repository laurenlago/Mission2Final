using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Final
{
    internal class DiceRoller
    {
        private Random random;

        // Constructor to initialize the random number generator
        public DiceRoller()
        {
            random = new Random();
        }

        // Simulates the rolling of two dice for a specified number of times
        // Returns an array where indices 2 to 12 represent the sums of two dice rolls
        public int[] SimulateRolls(int numberOfRolls)
        {
            // Initialize an array to store the count of each possible sum
            int[] results = new int[13]; // Indices 2 to 12 represent the sums of two dice rolls.

            // Simulate rolling two dice for the specified number of times
            for (int i = 0; i < numberOfRolls; i++)
            {
                // Generate random values for two dice
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);

                // Calculate the sum of the two dice
                int sum = dice1 + dice2;

                // Increment the count for the corresponding sum
                results[sum]++;
            }

            // Return the array with counts for each sum
            return results;
        }
    }
}
