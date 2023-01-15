using System;

namespace DotNetApp
{
    // Main Class 
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            DisplayAppInfo();

            String UserAnswer = AskUser();

            if (UserAnswer == "Y")
            {//jjjjjjj
                while (true)
                {
                    Random random = new Random();// random Obj

                    // Init correct number
                    int correctNumber = random.Next(1, 10);

                    int guess = 0;
                    string number = "";

                    Console.WriteLine("Guess a number between 1 and 10");// Take a number from the user

                    while (guess != correctNumber) // while not correct 
                    {
                        try
                        {
                            number = Console.ReadLine();
                        }
                        catch (Exception)
                        {
                            PrintColorMessage(ConsoleColor.Red, "Guess a number between 1 and 10");// Take a number from the user
                            number = Console.ReadLine();
                        }

                        if (!int.TryParse(number, out guess))// Make sure its a number and pass it to guess

                        {
                            PrintColorMessage(ConsoleColor.Red, "Please use an actual number");
                            continue;
                        }

                        guess = Int32.Parse(number);//parse number entring by the user to int and pass it to guess

                        if (guess != correctNumber) // Match guess to correct number
                        {
                            PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                        }
                    }

                    PrintColorMessage(ConsoleColor.Yellow, "CORRECT!! You guessed the correct number!");


                    Console.WriteLine("Would you play again? [Y or N]");
                    string answer = Console.ReadLine().ToUpper();


                    if (answer == "Y")
                    {
                        continue; //continue playing
                    }
                    else if (answer == "N")
                    {
                        Console.WriteLine("Thank you");
                        return;//out
                    }
                    else
                    {
                        return;//any letter 
                    }
                }
            }
            else
            {
                Console.WriteLine("Thank you");
            }
        }

        static void DisplayAppInfo()
        {
            string appName = ".Net Application using C#";
            string appVersion = "4.0.0";
            string appAuthor = "Aljawhara Albahlal";

            Console.ForegroundColor = ConsoleColor.Blue;//costomize text color
            Console.WriteLine("App Name" + appName + " Version" + appVersion + "Author" + appAuthor);//print app information
        }

        static string AskUser()//Take information from the user
        {
            string inputName = "";
            string Answer = "";

            Console.WriteLine("What is your name?");//ask the user
            try
            {
                inputName = Console.ReadLine();//take the name of user as input
            }
            catch (Exception)
            {
                PrintColorMessage(ConsoleColor.Red, "Try again");
                inputName = Console.ReadLine();//take the name of user as input
            }

            Console.WriteLine("Hello {0}, would you like to play a game? [Y or N]", inputName);
            try
            {
                Answer = Console.ReadLine().ToUpper();
            }
            catch (Exception)
            {
                PrintColorMessage(ConsoleColor.Red, "Try again");
                Answer = Console.ReadLine().ToUpper();
            }
            return Answer;
        }

        static void PrintColorMessage(ConsoleColor color, string message) //Costmize the message
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }

}
