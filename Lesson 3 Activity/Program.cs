using System;

namespace Lesson_3_Activity
{
    class Program
    {
        static void Main(string[] args)
        {
            //calculating in monthly variable
            Console.WriteLine("Please enter your initial deposit: ");
            var initialDeposit = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your monthly interest rate (in percentage): "); 
            var monthlyInterestRate = double.Parse(Console.ReadLine());
            monthlyInterestRate = monthlyInterestRate/100; 
            Console.WriteLine("Please enter how many months you will save for: "); 
            var month = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your regular monthly deposits: "); 
            var monthlyDeposits = double.Parse(Console.ReadLine()); 
            Console.WriteLine(monthlyDeposits); 


            var savings = initialDeposit*Math.Pow((1 + monthlyInterestRate), month) 
            + (monthlyDeposits/monthlyInterestRate)*(Math.Pow((1 + monthlyInterestRate), month) - 1); 

            Console.WriteLine(savings); 
            
            //calculating in yearly variables
            Console.WriteLine("Please enter your initial deposit: ");
            initialDeposit = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your yearly interest rate (in percentage): "); 
            var yearlyInterestRate = double.Parse(Console.ReadLine());
            yearlyInterestRate = yearlyInterestRate/100; 
            Console.WriteLine("Please enter how many years you will save for: "); 
            var year = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your regular monthly deposits: "); 
            monthlyDeposits = double.Parse(Console.ReadLine()); 
            Console.WriteLine(monthlyDeposits); 


            var savings2 = initialDeposit*Math.Pow((1 + yearlyInterestRate/12), year*12) 
            + (monthlyDeposits/(yearlyInterestRate/12))*(Math.Pow((1 + yearlyInterestRate/12), year*12) - 1); 

            Console.WriteLine(savings2); 


            //var number3 = double.Parse(13); why does this not work?
            //var a = int.Parse("15.0"); why does this not work?
            // why 9 & 7, why not 9.0 and 7.0. Is 9 always an integer or can it be a double? 
            // e.g. 1.2(double) + 0.8(double) = 2(integer) or 2(double)??

        }
    }
}
