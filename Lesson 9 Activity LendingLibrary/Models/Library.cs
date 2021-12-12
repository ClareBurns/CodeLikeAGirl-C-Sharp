using System.Collections.Generic;
using System;

namespace Lesson_9_Activity_LendingLibrary.Models
{
    public class Library
    {
        public string Name { get; set; }
        public List<Novel> Novels { get; set; }

        public List<TextBook> TextBooks { get; set; }

        public List<Album> Albums { get; set; }

        public List<AudioBook> AudioBooks { get; set; }

        public List<Borrower> Borrowers { get; set; }

        public Library(string name)
        {
            Name = name;
            Novels = new List<Novel> { };
            TextBooks = new List<TextBook> { };
            Albums = new List<Album> { };
            AudioBooks = new List<AudioBook> { };
            Borrowers = new List<Borrower> { };
        }

        public void AddNovel(Novel novel)
        {
            Novels.Add(novel);
        }

        public void AddTextBook(TextBook textbook)
        {
            TextBooks.Add(textbook);
        }

        public void AddAlbum(Album album)
        {
            Albums.Add(album);
        }

        public void AddAudioBook(AudioBook audiobook)
        {
            AudioBooks.Add(audiobook);
        }

        public void AddBorrower(Borrower borrower)
        {
            Borrowers.Add(borrower);
        }

        public void ListNovels()
        {
            Console.WriteLine($"The following novels are in the {Name}:");
            foreach (var Novel in Novels)
            {
                Novel.PrintNovel();
            }
        }

        public void ListTextbooks()
        {
            Console.WriteLine($"The following textbooks are in the {Name}:");
            foreach (var Textbook in TextBooks)
            {
                Textbook.PrintTextBook();
            }
        }

        public void ListAlbums()
        {
            Console.WriteLine($"The following albums are in the {Name}:");
            foreach (var Album in Albums)
            {
                Album.PrintAlbum();
            }
        }

        public void ListAudioBooks()
        {
            Console.WriteLine($"The following audiobooks are in the {Name}:");
            foreach (var AudioBook in AudioBooks)
            {
                AudioBook.PrintAudioBook();
            }
        }

        public void ListBorrowers()
        {
            Console.WriteLine($"The following borrowers are members at the {Name}:");
            foreach (var Borrower in Borrowers)
            {
                Borrower.PrintBorrower();
            }
        }

        public void LibraryOptions()
        {
            while (true)
            {
                Console.WriteLine($"Welcome to the {Name}");
                Console.WriteLine("Type 'VIEW MEDIA' if you would like to see the existing items at the library");
                Console.WriteLine("Type 'ADD MEDIA' if you would like to add items to the library");
                Console.WriteLine("Type 'X' to exit the program");
                var LibraryOptionsUserInput = Console.ReadLine().Trim().ToLower().Replace("'", "").Replace(" ", "");

                if (LibraryOptionsUserInput == "x")
                {
                    break;
                }
                switch (LibraryOptionsUserInput)
                {
                    case "viewmedia":
                        {
                            ViewMedia();
                            break;
                        }
                    case "addmedia":
                        {
                            AddMedia();
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Sorry we do not have that option please try again");
                            break;
                        }
                }

                Console.WriteLine("------------------------------------------");
            }
        }

        public void ViewMedia()
        {
            Console.WriteLine("Viewing the media");
        }

        public void AddMedia()
        {
            while (true)
            {
                GiveInstructionsToAddMedia();
                var AddMediaUserInput = Console.ReadLine().Trim().Replace("'", "").Replace(" ", "").ToLower();

                if (AddMediaUserInput == "x")
                {
                    break;
                }
                MediaTypeToAdd(AddMediaUserInput);


                Console.WriteLine("---------------------------------");
            }
        }

        public void GiveInstructionsToAddMedia()
        {
            Console.WriteLine("What type of Media would you like to add to the Library");
            Console.WriteLine("Type 'NOVEL' to add novels");
            Console.WriteLine("Type 'TEXTBOOK' to add textbooks");
            Console.WriteLine("Type 'ALBUM' to add albums");
            Console.WriteLine("Type 'AUDIOBOOK' to add audiobook");
            Console.WriteLine("Type 'X' to stop adding media");
        }

        public void MediaTypeToAdd(string addMediaUserInput)
        {
            switch (addMediaUserInput)
            {
                case "novel":
                    {
                        UserInputNovel();
                        break;
                    }
                case "textbook":
                    {
                        UserInputTextBook();
                        break;
                    }
                case "album":
                    {
                        UserInputAlbum();
                        break;
                    }
                case "audiobook":
                    {
                        UserInputAudioBook();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Sorry we do not have that object");
                        break;
                    }
            }
        }

    }
}