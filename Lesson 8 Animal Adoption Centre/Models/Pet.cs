using System;

namespace Lesson_8_Animal_Adoption_Centre.Models    
{
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