using Lesson_9_Vet_Clinic.models;

namespace Lesson_9_Vet_Clinic
{
    class Program
    {
        static void Main(string[] args)
        {
            var Luke = new Cat();
            Luke.Eat();
            var Leia = new Dog();
            Leia.Eat();

            var koala = new Koala();
            koala.Sleep();
        }
    }
}
