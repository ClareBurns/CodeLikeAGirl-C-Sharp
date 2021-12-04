using System;

namespace Lesson_9_Vet_Clinic.models
{
    public class Cat
    {
        public string name { get; set; }
        public string breed { get; set; }

        public void Eat()
        {
            Console.WriteLine("Om Nom!");
        }

        public void Meow()
        {
            Console.WriteLine("Meow");
        }
    }
}