using System;

namespace Lesson_9_Vet_Clinic.models
{
    public class Dog : Pet
    {
        public void Bark()
        {
            Console.WriteLine("Woof");
        }
    }
}