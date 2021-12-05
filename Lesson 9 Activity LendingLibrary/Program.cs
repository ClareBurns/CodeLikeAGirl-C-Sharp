using System;
using System.Collections.Generic;
using Lesson_9_Activity_LendingLibrary.Models;

namespace Lesson_9_Activity_LendingLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var Novel1 = new Novel("Harry Potter", "J.K Rowling", 2008, "Fiction");
            var TextBook1 = new TextBook("Coding", "Clare Burns", 2021, "IT");
            var Album1 = new Album("21", "Adele", 21, 2010);
            var AudioBook1 = new AudioBook("How We Love", "Clementine Ford", 20, 2021);

            Library.AddNovel(Novel1);
            Library.AddTextBook(TextBook1);
            Library.AddAlbum(Album1);
            Library.AddAudioBook(AudioBook1);

        }
    }
}
