using System;

namespace Lesson_2_Activity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name: ");
            var firstName = Console.ReadLine().Trim();
            Console.WriteLine("Please enter your favourite animal: "); 
            var animal = Console.ReadLine().Trim(); 
            Console.WriteLine("Please enter a name for your animal: ");
            var animalName = Console.ReadLine().Trim(); 
            Console.WriteLine("Please enter your favourite colour: "); 
            var colour = Console.ReadLine().Trim();
            Console.WriteLine("Please enter a fun place to visit: "); 
            var place = Console.ReadLine().Trim(); 
            Console.WriteLine("Please enter your favourite food: "); 
            var food = Console.ReadLine().Trim(); 
            
           Console.WriteLine($"{firstName} had the most amazing day today with a {animal} named {animalName}.");
           Console.WriteLine($"But {animalName} wasn't any normal {animal}. See {animalName} was {colour} from head to toe.");
           Console.WriteLine($"{animalName} and {firstName} went to visit the {place}! In was at the {place} that they ate yummy ice cream.");
           Console.WriteLine($"At the end of the day, {firstName} and {animalName} hugged goodbye and rejoiced in their wonderful day at the {place}.");
            


            /* questions for the tutorial: 
            -What is usually uppercase and what is camel case? 
            -when is it best to use var and when is it best to use string? */



        }
    }
}
