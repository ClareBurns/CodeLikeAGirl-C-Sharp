using System;

namespace Lesson_6_Activity
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //separate into 2 functions
                var continueCalculating = GiveInstructions();
                if (!continueCalculating)
                {
                    break;
                }
                var firstNumber = GetFirstNumber();
                var operation = GetOperation();
                var secondNumber = GetSecondNumber();

                //add math.round()

                completeCalculation(firstNumber, operation, secondNumber);

                Console.WriteLine("-------------------------------------------------");
            }
        }

        static Boolean GiveInstructions()
        {
            Console.WriteLine("Hello.");
            Console.WriteLine("This program acts as a calculator application that can perform basic arithmetic.");
            Console.WriteLine("If you wish to use the calculator press ENTER.");
            Console.WriteLine("If you would like to exit the program press X");
            var userInput = Console.ReadLine().Trim().ToLower();
            if (userInput == "x")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static double GetFirstNumber()
        {
            Console.Write("Please enter a number: ");
            var userInput = Console.ReadLine().Trim();
            var parseSuccess = double.TryParse(userInput, out var firstNumber);
            while (!parseSuccess)
            {
                Console.WriteLine("Error. You did not enter an number");
                Console.Write("Please enter a number: ");
                userInput = Console.ReadLine().Trim();
                parseSuccess = double.TryParse(userInput, out firstNumber);
            }
            return firstNumber;
        }

        static char GetOperation()
        {
            Console.Write("Please enter an operation: ");
            var userInput = Console.ReadLine().Trim();
            var parseSuccess = char.TryParse(userInput, out var operation);

            while (!parseSuccess)
            {
                Console.WriteLine("Error. You did not enter a character");
                Console.Write("Please enter a number: ");
                userInput = Console.ReadLine().Trim();
                parseSuccess = char.TryParse(userInput, out operation);
            }
            return operation;
        }

        static double GetSecondNumber()
        {

            Console.Write("Please enter a second number: ");
            var userInput = Console.ReadLine().Trim();
            var parseSuccess = double.TryParse(userInput, out var secondNumber);
            while (!parseSuccess)
            {
                Console.WriteLine("Error. You did not enter an number");
                Console.Write("Please enter a number: ");
                userInput = Console.ReadLine().Trim();
                parseSuccess = double.TryParse(userInput, out secondNumber);
            }
            return secondNumber;
        }

        static void completeCalculation(double firstNumber, char operation, double secondNumber)
        {
            switch (operation)
            {
                case '-':
                    Subtraction(firstNumber, secondNumber);
                    break;
                case '+':
                    Addition(firstNumber, secondNumber);
                    break;
                case '*':
                    Multiplication(firstNumber, secondNumber);
                    break;
                case '/':
                    Division(firstNumber, secondNumber);
                    break;
                case '^':
                    PowerOf(firstNumber, secondNumber);
                    break;
                default:
                    Console.WriteLine("Sorry we can not do that operation");
                    break;
            }
        }

        static void Subtraction(double firstNumber, double secondNumber)
        {
            var answer = firstNumber - secondNumber;
            //add result
            Console.WriteLine($"{firstNumber} - {secondNumber} = {answer}");
        }

        static void Addition(double firstNumber, double secondNumber)
        {
            var answer = firstNumber + secondNumber;
            Console.WriteLine($"{firstNumber} + {secondNumber} = {answer}");
        }

        static void Multiplication(double firstNumber, double secondNumber)
        {
            var answer = firstNumber * secondNumber;
            Console.WriteLine($"{firstNumber} * {secondNumber} = {answer}");
        }

        static void Division(double firstNumber, double secondNumber)
        {
            var answer = firstNumber / secondNumber;
            Console.WriteLine($"{firstNumber} / {secondNumber} = {answer}");

            //handle divide by zero error
        }

        static void PowerOf(double firstNumber, double secondNumber)
        {
            var answer = Math.Pow(firstNumber, secondNumber);
            Console.WriteLine($"{firstNumber} ^ {secondNumber} = {answer}");
        }


    }
}

//how many numbers?
//addition and subtraction might want more numbers
//division can only have 2 numbers
//make a list of numbers?