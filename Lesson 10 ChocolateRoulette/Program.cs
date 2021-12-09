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


            // select a chocolate at random 
            var randomIndexGenerator = new Random();
            var IndexofRandomChocolate = randomIndexGenerator.Next(0, chocolateBox.Count);

            var selectedChocolate = chocolateBox[IndexofRandomChocolate];

            //taste our chocolate
            selectedChocolate.Taste();
        }
    }
}
