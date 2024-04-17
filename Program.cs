using System;

class Program
{
    static void Main()
    {
        // Define and initialize a boolean variable
        bool isActive = true;

        // Perform a boolean comparison using a while statement
        // This loop continues as long as isActive is true
        while (isActive)
        {
            Console.WriteLine("The loop is active.");

            // Change the condition to false to break the loop
            isActive = false;
        }

        // Reset isActive to true for the next example
        isActive = true;

        // Perform a boolean comparison using a do-while statement
        // This loop will execute at least once
        do
        {
            Console.WriteLine("The do-while loop is active.");

            // Change the condition to false
            isActive = false;

        } while (isActive);

        Console.WriteLine("Both loops have finished executing.");
    }
}
