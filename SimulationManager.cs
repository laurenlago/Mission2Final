using Mission2Final;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Final
{
    internal class SimulationManager
    {
        // Runs the dice rolling simulation for a specified number of rolls
        // Returns an array with counts for each sum of two dice rolls
        public int[] RunSimulation(int numberOfRolls)
        {
            // Create an instance of the DiceRoller class
            DiceRoller diceRoller = new DiceRoller();

            // Use DiceRoller to simulate rolls and return the results
            return diceRoller.SimulateRolls(numberOfRolls);
        }

        // Displays the results of the dice rolling simulation
        public void DisplayResults(int numberOfRolls, int[] results)
        {
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {numberOfRolls}.\n");

            // Display the histogram for each possible sum
            for (int i = 2; i <= 12; i++)
            {
                // Calculate the percentage and display '*' accordingly
                int percentage = results[i] * 100 / numberOfRolls;
                Console.WriteLine($"{i}: {new string('*', percentage)}");
            }
        }
    }
}

