using System;

namespace Lesson_9_Activity_LendingLibrary.Models
{
    public class AudioBook : CD
    {
        public string Author { get; set; }

        public AudioBook(string title, string author, int numberoftracks, int publicationyear)
        {
            Title = title;
            Author = author;
            NumberOfTracks = numberoftracks;
            PublicationYear = publicationyear;
        }

        public void PrintAudioBook()
        {
            Console.WriteLine($"\t AudioBook titled {Title} by {Author}, {PublicationYear}, number of tracks: {NumberOfTracks}");
        }
    }
}