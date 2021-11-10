using System;
using System.Collections.Generic;

namespace Lesson_6_marketing
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Elizabeth", "Charles", "William", "George" };
            foreach (var name in names)
            {
                SubscriptionThankYou(name);
            }

        }

        static void SubscriptionThankYou(string name)
        {
            Console.WriteLine($"Dear {name}");
            Console.WriteLine("Thank you fo subscribing to our newsletter");
            Console.WriteLine("Kind Regards");
            Console.WriteLine("The Code Like a Girl Team");
        }
    }
}

