using System;

namespace Lesson_9_Vet_Clinic.models
{
    public abstract class Pet : Animal
    {
        public string name { get; set; }
        public string breed { get; set; }
    }
}