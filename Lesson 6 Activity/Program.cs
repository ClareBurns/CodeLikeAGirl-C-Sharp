using System;

namespace Lesson_6_Activity
{
    class Program
    {
        static void Main(string[] args)
        {
            while (string)
                var firstNumber = GetFirstNumber();
            var operation = GetOperation();
            var secondNumber = GetSecondNumber();

            Console.WriteLine(firstNumber * secondNumber);


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

            var operationCheck = true;

            while (!parseSuccess || !operationCheck)
            {
                Console.WriteLine("Error. You did not enter an operation");
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
    }
}
