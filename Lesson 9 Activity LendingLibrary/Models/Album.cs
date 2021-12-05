namespace Lesson_9_Activity_LendingLibrary.Models
{
    public class Album : CD
    {
        public string Artist { get; set; }

        public Album(string title, string artist, int numberoftracks, int publicationyear)
        {
            Title = title;
            Artist = artist;
            NumberOfTracks = numberoftracks;
            PublicationYear = publicationyear;
        }
    }
}