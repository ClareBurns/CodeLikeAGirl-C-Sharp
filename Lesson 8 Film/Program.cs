using System;

namespace Lesson_8_Film
{
    class Program
    {
        static void Main(string[] args)
        {
            var film = new Film("Toy Story", 1994);
            Console.WriteLine(film.ReleaseYear);
        }
    }

    public class Film
    {
        public string Title { get; set; }
        public int ReleaseYear { get; set; }

        public Film(string title, int releaseYear)
        {
            Title = title;
            ReleaseYear = releaseYear;
        }
    }
}
