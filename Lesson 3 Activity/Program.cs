using System;

namespace Lesson_3_Activity
{
    class Program
    {
        static void Main(string[] args)
        {
            Char[] toTrim = { '$', '%', ' ' };
            Console.WriteLine("What is your saving goal?");
            var savingsGoal = double.Parse(Console.ReadLine().Trim());
            Console.WriteLine("Please enter your initial deposit: ");
            var initialDeposit = double.Parse(Console.ReadLine().Trim(toTrim));
            double savings = 0;

            Console.WriteLine("Do you have a monthly interest rate or a yearly interest rate?");
            Console.WriteLine("For a monthly interest rate enter MONTHLY.");
            Console.WriteLine("For a yearly interest rate enter YEARLY.");
            var interestRateType = Console.ReadLine().Trim().ToLower();

            switch (interestRateType)
            {

                case "monthly":
                    Console.WriteLine("Please enter your monthly interest rate (in percentage): ");
                    var monthlyInterestRate = double.Parse(Console.ReadLine().Trim(toTrim));
                    monthlyInterestRate = monthlyInterestRate / 100;
                    Console.WriteLine("Please enter how many months you will save for: ");
                    var month = int.Parse(Console.ReadLine().Trim(toTrim));
                    Console.WriteLine("Please enter your regular monthly deposits: ");
                    var monthlyDeposits = double.Parse(Console.ReadLine().Trim(toTrim));
                    Console.WriteLine(monthlyDeposits);

                    savings = initialDeposit * Math.Pow((1 + monthlyInterestRate), month)
                    + (monthlyDeposits / monthlyInterestRate) * (Math.Pow((1 + monthlyInterestRate), month) - 1);
                    break;

                case "yearly":
                    Console.WriteLine("Please enter your yearly interest rate (in percentage): ");
                    var yearlyInterestRate = double.Parse(Console.ReadLine().Trim(toTrim));
                    yearlyInterestRate = yearlyInterestRate / 100;
                    Console.WriteLine("Please enter how many years you will save for: ");
                    var year = int.Parse(Console.ReadLine().Trim(toTrim));
                    Console.WriteLine("Please enter your regular monthly deposits: ");
                    monthlyDeposits = double.Parse(Console.ReadLine().Trim(toTrim));
                    Console.WriteLine(monthlyDeposits);

                    savings = initialDeposit * Math.Pow((1 + yearlyInterestRate / 12), year * 12)
                    + (monthlyDeposits / (yearlyInterestRate / 12)) * (Math.Pow((1 + yearlyInterestRate / 12), year * 12) - 1);
                    break;

                default:
                    Console.WriteLine("Sorry you haven't entered the interest rate time unit correctly. Please try again.");
                    break;
            }

            var savingsRounded = Math.Round(savings, 2);
            Console.WriteLine("Your calculated savings are: ");
            Console.WriteLine($"${savingsRounded}");

            var doesMeetSavingsGoal = savings >= savingsGoal;
            Console.WriteLine("Does this meet the savings Goal?");
            Console.WriteLine(doesMeetSavingsGoal);

        }
    }

}
