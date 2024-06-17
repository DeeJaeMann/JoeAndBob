using System.ComponentModel.Design;

namespace JoeAndBob
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Create a new Guy object in a variable called joe
             * Set it's Name field to "Joe"
             * Set it's Cash field to 50
             */

            Guy joe = new Guy() { Name = "Joe", Cash = 50 };

            /* Create a new Guy object in a variable called bob
             * Set it's Name field to "Bob"
             * Set it's Cash field to 100
             */

            Guy bob = new Guy() { Name = "Bob", Cash = 100 };

            while (true)
            {
                // Call the WriteMyInfo methods for each Guy object
                joe.WriteMyInfo();
                bob.WriteMyInfo();

                Console.Write("Enter an amount: ");
                string howMuch = Console.ReadLine();

                if (howMuch == "") return;
                /* use int.TryParse to try to convert the howMuch string to an int
                 * if it was successful
                 */
                if (int.TryParse(howMuch, out int myCash))
                {
                    Console.Write("Who should give the cash: ");
                    string whichGuy = Console.ReadLine();
                    if (whichGuy == "Joe")
                    {
                        // Call the joe object's GiveCash method and save the results
                        int cashResult = joe.GiveCash(myCash);
                        // Call the bob object's ReceiveCash method with the saved results
                        bob.ReceiveCash(cashResult);
                    }
                    else if (whichGuy == "Bob")
                    {
                        // Call the bob object's GiveCash method and save the results
                        int cashResult = bob.GiveCash(myCash);
                        // Call the joe object's ReceiveCash method with the saved results
                        joe.ReceiveCash(cashResult);
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
