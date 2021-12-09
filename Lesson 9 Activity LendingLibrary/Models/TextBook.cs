using System;

namespace Lesson_9_Activity_LendingLibrary.Models
{
    public class TextBook : Book
    {
        public string Subject { get; set; }

        public TextBook(string title, string author, int publicationyear, string subject)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationyear;
            Subject = subject;
        }

        public void PrintTextBook()
        {
            Console.WriteLine($"\t TextBook titled {Title} by {Author}, {PublicationYear}, subject: {Subject}");
        }
    }
}