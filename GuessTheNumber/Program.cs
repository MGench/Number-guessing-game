using System;

// Namespace
namespace GuessTheNumber
{
    // Main Class
    class Program
    {
        static void Main(string[] args)
        {

            getAppInfo(); // calling getAppInfo method

            greetUser(); // Ask for users details

            while (true)
            {

                // int correctNumber = 7;

                // Create a new random object
                Random random = new Random();

                // Init correct number, generates between 1 - 10
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                Console.WriteLine("Guess a number between 1 - 10");

                // While guess is not true
                while (guess != correctNumber)
                {
                    // Gets users input
                    string input = Console.ReadLine();

                    // Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Prints error message by calling the method printColorMessage
                        printColorMessage(ConsoleColor.Red, "Please enter a number");

                        // Continues
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber) {
                        // Prints error message
                        printColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                // Print success message
                printColorMessage(ConsoleColor.Yellow, "Correct!, You guess the right number!");

                // Ask user to play again
                Console.WriteLine("Would you like to play again? [Y/N]");

                // Get Answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y") {
                    continue;
                } 
                else if (answer == "N") {
                    return;
                } else
                {
                    return;
                }

            }
        }

        // method for displaying app info
        static void getAppInfo() {
            // application details
            string appName = "Guess The Number";
            string appVersion = "1.0.0";
            string appAuthor = "Mustafa Genc";

            // Changing text colour
            Console.ForegroundColor = ConsoleColor.Green;

            // Prints app info
            Console.WriteLine($"{appName}: Version {appVersion} by {appAuthor}");

            // Resets text colour
            Console.ResetColor();
        }

        // method for greeting user
        static void greetUser() {
            // Ask users name
            Console.WriteLine("Please enter your name:");

            // Gets users input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello, " + inputName + " " + "Let's play a game \n");

        }

        // print colour message
        static void printColorMessage(ConsoleColor color, string message)
        {
            // Changing text colour
            Console.ForegroundColor = color;

            // Tells user its not a number
            Console.WriteLine(message);

            // Resets text colour
            Console.ResetColor();
        }
    }
}
