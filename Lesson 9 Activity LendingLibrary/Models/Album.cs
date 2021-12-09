using System;

namespace Lesson_9_Activity_LendingLibrary.Models
{
    public class Album : CD
    {
        public string Artist { get; set; }

        public Album(string title, string artist, int numberoftracks, int publicationyear)
        {
            //make camelCase
            Title = title;
            Artist = artist;
            NumberOfTracks = numberoftracks;
            PublicationYear = publicationyear;
        }

        public void PrintAlbum()
        {
            Console.WriteLine($"\t Album titled {Title} by {Artist}, {PublicationYear}, number of tracks: {NumberOfTracks}");
        }
    }
}