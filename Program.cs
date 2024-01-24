using Mission2Final;
// Name: Lauren Melo
//Section: 3
//Description: My code simulates the rolling of two six-sided dice for a user-specified number of rolls
class DiceSimulator
{
    static void Main()
    {
        // Create an instance of the SimulationManager class
        SimulationManager simulationManager = new SimulationManager();

        Console.WriteLine("Welcome to the dice throwing simulator!");

        // Prompt user for the number of dice rolls to simulate
        Console.Write("How many dice rolls would you like to simulate? ");
        int numberOfRolls;

        // Input validation: Ensure a positive integer is entered
        while (!int.TryParse(Console.ReadLine(), out numberOfRolls) || numberOfRolls <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            Console.Write("How many dice rolls would you like to simulate? ");
        }

        // Run the simulation and display the results
        int[] results = simulationManager.RunSimulation(numberOfRolls);
        simulationManager.DisplayResults(numberOfRolls, results);

        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}

