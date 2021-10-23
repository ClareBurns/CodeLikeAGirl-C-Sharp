using System;

namespace Lesson_4_Activity
{
    class Program
    {
        static void Main(string[] args)
        {
            //generatoring a random number
            var randomGenerator = new Random();
            var randomNumber = randomGenerator.Next(1, 11);

            //Displaying rules to the user
            Console.WriteLine("Welcome to our guessing game!");
            Console.WriteLine("We will generate a random integer between 1 and 10!");
            Console.WriteLine("It is your job to guess what number we thought of.");
            Console.WriteLine("You will have 3 guesses.");

            for (var i = 1; ; i++)
            {
                Console.WriteLine($"Please enter guess number {i}: ");
                var userInput = Console.ReadLine().Trim();
                int userGuess;
                var parseSuccess = int.TryParse(userInput, out userGuess);

                //Checking for user input error
                while (!parseSuccess || userGuess > 10 || userGuess < 1)
                {
                    Console.WriteLine("Error. You did not enter an integer between 1 and 10!");
                    Console.WriteLine("Please guess again with an integer between 1 and 10: ");
                    userInput = Console.ReadLine().Trim();
                    parseSuccess = int.TryParse(userInput, out userGuess);
                }

                if (userGuess == randomNumber)
                {
                    Console.WriteLine("Congrats! You guessed correctly!");
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry your guess was Incorrect. Keep Guessing!");

                    //generating Hints
                    if (i == 1 || i == 4 || i == 7 || i == 10)
                    {
                        if (userGuess > randomNumber)
                        {
                            Console.WriteLine("Hint: your guess was too high!");
                        }
                        else
                        {
                            Console.WriteLine("Hint: your guess was too low!");
                        }
                    }
                    else if (i == 2 || i == 5 || i == 8)
                    {
                        if (randomNumber % 2 == 0)
                        {
                            Console.WriteLine("Hint: The number is even");
                        }
                        else
                        {
                            Console.WriteLine("Hint: The number is odd");
                        }
                    }
                    else
                    {
                        if (Math.Abs(randomNumber - userGuess) <= 2)
                        {
                            Console.WriteLine("Hint: You are hot! Within 2 figures or less.");
                        }
                        else
                        {
                            Console.WriteLine("Hint: You are cold! Outside 2 figures");
                        }
                    }
                }
            }

            //how often do we need to build?
            //okay to make an infinate loop for a for loop? 
            //good resource --> https://codeasy.net/lesson/input_validation
        }
    }
}
