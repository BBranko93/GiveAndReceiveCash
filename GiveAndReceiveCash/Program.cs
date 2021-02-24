using System;

namespace GiveAndReceiveCash
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Guy object in a variable called joe
            // Sets its Name field to "Joe"
            // Sets its Cash field to 500
            Guy joe = new Guy() { Cash = 500, Name = "Joe" };

            // Create a new Guy object in a variable called bob
            // Sets its Name field to "Bob"
            // Sets its Cash field to 1000
            Guy bob = new Guy() { Cash = 1000, Name = "Bob" };

            while (true)
            {
                // Call the WriteMyInfo methods for each Guy object
                joe.WriteMyInfo();
                bob.WriteMyInfo();
                Console.Write("Enter an amount: ");
                string howMuch = Console.ReadLine();
                if (howMuch == "") return;

                //Use int.TryParse to try to convert the howMuch string to an int
                // if it was successful
                if (int.TryParse(howMuch, out int amount))
                {
                    Console.Write("Who should give the cash: ");
                    string whichGuy = Console.ReadLine();
                    if (whichGuy == "Joe")
                    {
                        // Call the joe object's GiveCash method and save the results
                        int cashGiven = joe.GiveCash(amount);
                        // Call the bob object's ReceiveCash method with the saved results
                        bob.ReceiveCash(cashGiven);
                    }
                    else if (whichGuy == "Bob")
                    {
                        // Call the bob object's GiveCash method and save the results
                        int cashGiven = bob.GiveCash(amount);
                        // Call the joe object's ReceiveCash method woth the saved results
                        joe.ReceiveCash(cashGiven);
                    }
                    else
                    {
                        Console.WriteLine("Please enter 'Joe' or 'Bob'");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an amount (or a blank line to exit).");
                }
            }
        }
    }
}
