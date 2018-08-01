using System;

// Namespace
namespace NumberGuess
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {

            GetAppInfo();

            GreetUser();

            while (true)
            {

                // Init set correct number
                //int correctNumber = 7;

                // create a new random object
                Random random = new Random();

                // Init set correct number
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // while guess is not correct
                while (guess != correctNumber)
                {
                    // get users input
                    string input = Console.ReadLine();

                    // make sure it's a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print message
                        PrintColorMessage(ConsoleColor.Red, "Please use a number");

                        //Keep going
                        continue;
                    }

                    //cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print message
                        PrintColorMessage(ConsoleColor.Red, "Please try again");
                    }
                } // End while

                // Output success message

                // Print message
                PrintColorMessage(ConsoleColor.Yellow, "Correct");

                //Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                //get answer
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y"){
                    continue;
                }else if(answer == "N") {
                    return;
                } else {
                    return;
                }

            }

        }  //end Main


        static void GetAppInfo(){

            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "AL Winsley";
            // change text color
            Console.ForegroundColor = ConsoleColor.Blue;

            // write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
         

        } // end GetAppInfo();

        static void GreetUser(){
            // reset text color
            Console.ResetColor();

            // ask user name
            Console.WriteLine("What is your name?");

            // get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game!", inputName);

        } // End GreetUser()

        static void PrintColorMessage(ConsoleColor color, string message){
            // change text color
            Console.ForegroundColor = cor.Red;

            // tell user it's not a number
            Console.WriteLine(message);

            // reset text color
            Console.ResetColor();

        } // End PrintColorMessage


    }
}
