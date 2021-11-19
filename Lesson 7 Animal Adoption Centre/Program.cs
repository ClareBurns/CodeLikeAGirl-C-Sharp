using System;
using System.Collections.Generic;

namespace Lesson_7_Animal_Adoption_Centre
{
    class Program
    {
        static void Main(string[] args)
        {
            var pet1 = new Pet
            {
                animal = "cat",
                name = "Sooty",
                age = 4
            };

            var pet2 = new Pet();

            pet2.animal = "dog";
            pet2.name = "Lola";
            pet2.age = 2;

            var pet3 = new Pet
            {
                animal = "tortoise",
                name = "Tan",
                age = 16
            };

            var pets = new List<Pet>
            {
                pet1, pet2, pet3
            };

            foreach (var pet in pets)
            {
                pet.DisplayDetails();
            }
        }

        public class Pet
        {
            public string animal;
            public string name;
            public int age;

            public void DisplayDetails()
            {
                Console.WriteLine($"A {age} year old {animal} named {name} is availale for adoption!");
            }

        }
    }
}
