using System;

namespace Lesson_9_Vet_Clinic.models
{
    public abstract class Pet
    {
        public string name { get; set; }
        public string breed { get; set; }

        public void Eat()
        {
            Console.WriteLine("Om Nom!");
        }
    }
}