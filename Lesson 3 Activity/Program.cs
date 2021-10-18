using System;

namespace Lesson_3_Activity
{
    class Program
    {
        static void Main(string[] args)
        {
            Char[] toTrim = { '$', '%', ' ' };

            //calculating in monthly variables
            Console.WriteLine("Please enter your initial deposit: ");
            var initialDeposit = double.Parse(Console.ReadLine().Trim(toTrim));
            Console.WriteLine("Please enter your monthly interest rate (in percentage): ");
            var monthlyInterestRate = double.Parse(Console.ReadLine().Trim(toTrim));
            monthlyInterestRate = monthlyInterestRate / 100;
            Console.WriteLine("Please enter how many months you will save for: ");
            var month = int.Parse(Console.ReadLine().Trim(toTrim));
            Console.WriteLine("Please enter your regular monthly deposits: ");
            var monthlyDeposits = double.Parse(Console.ReadLine().Trim(toTrim));
            Console.WriteLine(monthlyDeposits);

            var savings = initialDeposit * Math.Pow((1 + monthlyInterestRate), month)
            + (monthlyDeposits / monthlyInterestRate) * (Math.Pow((1 + monthlyInterestRate), month) - 1);

            var savingsGoal = 2000;
            var doesMeetSavingsGoal = savings >= savingsGoal;


            var savingsRounded = Math.Round(savings, 2);
            Console.WriteLine("Your calculated savings are: ");
            Console.WriteLine($"${savingsRounded}");
            Console.WriteLine("Does this meet the savings Goal?");
            Console.WriteLine(doesMeetSavingsGoal);

            //calculating in yearly variables
            Console.WriteLine("Please enter your initial deposit: ");
            initialDeposit = double.Parse(Console.ReadLine().Trim(toTrim));
            Console.WriteLine("Please enter your yearly interest rate (in percentage): ");
            var yearlyInterestRate = double.Parse(Console.ReadLine().Trim(toTrim));
            yearlyInterestRate = yearlyInterestRate / 100;
            Console.WriteLine("Please enter how many years you will save for: ");
            var year = int.Parse(Console.ReadLine().Trim(toTrim));
            Console.WriteLine("Please enter your regular monthly deposits: ");
            monthlyDeposits = double.Parse(Console.ReadLine().Trim(toTrim));
            Console.WriteLine(monthlyDeposits);

            var savings2 = initialDeposit * Math.Pow((1 + yearlyInterestRate / 12), year * 12)
            + (monthlyDeposits / (yearlyInterestRate / 12)) * (Math.Pow((1 + yearlyInterestRate / 12), year * 12) - 1);

            var savings2Rounded = Math.Round(savings2, 2);
            Console.WriteLine("Your calculated savings are: ");
            Console.WriteLine($"${savings2Rounded}");


        }
    }
}
