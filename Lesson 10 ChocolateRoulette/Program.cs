using System;
using System.Collections.Generic;
using Lesson_10_ChocolateRoulette.Models;

namespace Lesson_10_ChocolateRoulette
{
    class Program
    {
        static void Main(string[] args)
        {
            //create chocolate box
            var chocolateBox = new List<Chocolate> {
                new Chocolate(),
                new Chocolate(),
                new Chocolate(),
                new Chocolate(),
                new ChilliChocolate(),
                new Chocolate(),
                new Chocolate(), };

            while (chocolateBox.Count > 0)
            {
                Console.WriteLine("press any key to taste chocolate");
                Console.ReadKey();
                // select a chocolate at random 
                var randomIndexGenerator = new Random();
                var IndexofRandomChocolate = randomIndexGenerator.Next(0, chocolateBox.Count);

                var selectedChocolate = chocolateBox[IndexofRandomChocolate];

                chocolateBox.RemoveAt(IndexofRandomChocolate);

                //taste our chocolate
                selectedChocolate.Taste();

            }

            Console.WriteLine("We're all out of chocolates");
        }
    }
}
