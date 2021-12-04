using System;

namespace Lesson_9_Vet_Clinic.models
{
    public abstract class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Om Nom!");
        }
    }
}