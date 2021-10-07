using System;

namespace Lesson_2_Activity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name: ");
            string firstName = Console.ReadLine(); 
            firstName = firstName.Trim(); 
            Console.WriteLine("Please enter your favourite animal: "); 
            string animal = Console.ReadLine(); 
            animal = animal.Trim(); 
            Console.WriteLine("Please enter a name for your animal: ");
            string animalName = Console.ReadLine(); 
            animalName = animalName.Trim(); 
            Console.WriteLine("Please enter your favourite colour: "); 
            var colour = Console.ReadLine();
            colour = colour.Trim();
            Console.WriteLine("Please enter a fun place to visit: "); 
            string place = Console.ReadLine();
            place = place.Trim(); 
            Console.WriteLine("Please enter your favourite food: "); 
            var food = Console.ReadLine(); 
            food = food.Trim(); 


           string script = $"{firstName} had the most amazing day today with a {animal} named {animalName}. But {animalName} wasn't any normal {animal}. See {animalName} was {colour} from head to toe. {animalName} and {firstName} went to visit the {place}! In was at the {place} that they ate yummy ice cream. At the end of the day, {firstName} and {animalName} hugged goodbye and rejoiced in their wonderful day at the {place}.";

            Console.WriteLine(script);


            /* questions for the tutorial: 
            -What is usually uppercase and what is camel case? 
            -when is it best to use var and when is it best to use string? */



        }
    }
}
