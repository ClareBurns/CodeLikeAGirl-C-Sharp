using System;

namespace Lesson_10_ChocolateRoulette.Models
{
    public class Chocolate
    {
        public virtual void Taste()
        {
            Console.WriteLine("This chocolate tastes nice!");
        }
    }

    public class ChilliChocolate : Chocolate
    {
        public override void Taste()
        {
            Console.WriteLine("Ouch! That was spicy... must be the chilli");
        }
    }
}