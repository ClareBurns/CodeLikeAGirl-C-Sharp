using System;
using System.Collections.Generic;
using Lesson_9_Activity_LendingLibrary.Models;

namespace Lesson_9_Activity_LendingLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            //create media objects
            var Novel1 = new Novel("Harry Potter", "J.K Rowling", 2008, "Fiction");
            var Novel2 = new Novel("Ruby Redford", "Lauren Childs", 2004, "Fiction");
            var TextBook1 = new TextBook("Coding", "Clare Burns", 2021, "IT");
            var TextBook2 = new TextBook("Science", "Sofia Burns", 2020, "Science");
            var Album1 = new Album("21", "Adele", 21, 2010);
            var Album2 = new Album("30", "Adele", 30, 2021);
            var AudioBook1 = new AudioBook("How We Love", "Clementine Ford", 20, 2021);
            var AudioBook2 = new AudioBook("Fight like a girl", "Clementine Ford", 20, 2010);

            //initiate Library 
            var Library = new Library("State Library");

            //add media objects to Library s
            Library.AddNovel(Novel1);
            Library.AddNovel(Novel2);
            Library.AddTextBook(TextBook1);
            Library.AddTextBook(TextBook2);
            Library.AddAlbum(Album1);
            Library.AddAlbum(Album2);
            Library.AddAudioBook(AudioBook1);
            Library.AddAudioBook(AudioBook2);

            //create borrowers
            var person1 = new Borrower("Clare", "Burns", 121);
            var person2 = new Borrower("Sofia", "Burns", 123);
            var person3 = new Borrower("Gemma", "Burns", 124);

            //add borrowers to the library
            Library.AddBorrower(person1);
            Library.AddBorrower(person2);
            Library.AddBorrower(person3);

            //Listing all the objects in the Library
            /*Library.ListNovels();
            Library.ListTextbooks();
            Library.ListAlbums();
            Library.ListAudioBooks();
            Library.ListBorrowers(); */

            Library.LibraryOptions();
        }
    }
}
