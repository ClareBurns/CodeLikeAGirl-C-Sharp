using System;
using System.Collections.Generic;

namespace Lesson_7_Activity
{
    class Program
    {
        static void Main(string[] args)
        {
            var recommendedBooks = DeclareBooks();
            var members = DeclareMembers(recommendedBooks);

            while (true)
            {
                GiveInstructions();
                var userInput = Console.ReadLine().Trim().ToLower().Replace(" ", "");
                if (userInput == "x")
                {
                    break;
                }

                RespondtoUserCommands(userInput, recommendedBooks, members);

                Console.WriteLine("---------------------------------------------------------------");

            }
        }

        static void GiveInstructions()
        {
            Console.WriteLine("Welcome to the book club!");
            Console.WriteLine("To see a list of the recommended books type BOOKS");
            Console.WriteLine("To see a list of the members type MEMBERS");
            Console.WriteLine("Each see each member's favourite book type FAV BOOK");
            Console.WriteLine("Each see each member's reading list type READING LIST");
            Console.WriteLine("To add a new book type NEW BOOK");
            Console.WriteLine("To add a new member type NEW MEMBER");
            Console.WriteLine("To exit the program type X");
        }

        static void RespondtoUserCommands(string userInput, List<Book> recommendedBooks, List<Member> members)
        {
            switch (userInput)
            {
                case "books":
                    DisplayBooks(recommendedBooks);
                    break;
                case "members":
                    DisplayMembers(members);
                    break;
                case "favbook":
                    DisplayFavBook(members);
                    break;
                case "readinglist":
                    DisplayReadingList(members);
                    break;
                case "newbook":
                    AddBook(recommendedBooks);
                    break;
                case "newmember":
                    AddMember(members);
                    break;
                default:
                    Console.WriteLine("Sorry we don't have the option.");
                    break;
            }
        }
        static List<Book> DeclareBooks()
        {
            var Book1 = new Book
            {
                title = "I Know Why The Caged Bird Sings",
                author = "Maya Angelou"
            };

            var Book2 = new Book
            {
                title = "Ruby Redfort",
                author = "Lauren Child"
            };

            var Book3 = new Book
            {
                title = "Midnight Children",
                author = "Salman Rushdie"
            };

            var Book4 = new Book
            {
                title = "Harry Potter",
                author = "J.K Rowling"
            };

            var Book5 = new Book
            {
                title = "The Book Thief",
                author = "Markus Zusak"
            };

            var recommendedBooks = new List<Book> { Book1, Book2, Book3, Book4, Book5 };

            return recommendedBooks;
        }

        static List<Member> DeclareMembers(List<Book> recommendedBooks)
        {
            var member1 = new Member
            {
                firstName = "Clare",
                secondName = "Burns",
                favouriteBook = recommendedBooks[0],
                readingList = new List<Book> { recommendedBooks[1] }
            };

            var member2 = new Member
            {
                firstName = "Sofia",
                secondName = "Burns",
                favouriteBook = recommendedBooks[1],
                readingList = new List<Book> { recommendedBooks[0], recommendedBooks[4] }
            };

            var member3 = new Member
            {
                firstName = "Penny",
                secondName = "Burns",
                favouriteBook = recommendedBooks[2],
                readingList = new List<Book> { recommendedBooks[0], recommendedBooks[1], recommendedBooks[3] }
            };

            var members = new List<Member> { member1, member2, member3 };

            return members;
        }

        static void DisplayBooks(List<Book> recommendedBooks)
        {
            Console.WriteLine("The following books have been recommeded by the book club: ");
            foreach (var book in recommendedBooks)
            {
                Console.WriteLine($"\t {book.title} by {book.author}");
            }
        }

        static void DisplayMembers(List<Member> members)
        {
            Console.WriteLine("The following are members of the book club: ");
            foreach (var member in members)
            {
                Console.WriteLine($"\t {member.firstName} {member.secondName}");
            }
        }

        static void DisplayReadingList(List<Member> members)
        {
            Console.WriteLine("The reading list for each member is: ");
            foreach (var member in members)
            {
                Console.WriteLine($"For {member.firstName} {member.secondName}: ");
                foreach (var book in member.readingList)
                {
                    Console.WriteLine($"\t {book.title} by {book.author}");
                }
            }
        }

        static void DisplayFavBook(List<Member> members)
        {
            foreach (var member in members)
            {
                member.DisplayMemberDetails();
            }
        }

        static void AddBook(List<Book> recommendedBooks)
        {
            Console.WriteLine("What is the title of the book you would like to add: ");
            var newTitle = Console.ReadLine();
            Console.WriteLine("What is the author of the book you would like to add: ");
            var newAuthor = Console.ReadLine();
            var alreadyAdded = false;
            foreach (var book in recommendedBooks)
            {
                if (book.title == newTitle && book.author == newAuthor)
                {
                    alreadyAdded = true;
                    break;
                }
            }

            if (alreadyAdded)
            {
                Console.WriteLine("This book is already on the recommended book list.");
            }

            else
            {
                var newBook = new Book() { title = newTitle, author = newAuthor, };
                recommendedBooks.Add(newBook);
                Console.WriteLine($"{newBook.title} by {newBook.author} has been added to the recommended book list");

            }

        }

        static void AddMember(List<Member> members)
        {
            Console.WriteLine("What is the first name of the member you would like to add:  ");
            var newFirstName = Console.ReadLine();
            Console.WriteLine("What is the second name of the member you would like to add: ");
            var newSecondName = Console.ReadLine();
            var alreadyAdded = false;
            foreach (var member in members)
            {
                if (member.firstName == newFirstName && member.secondName == newSecondName)
                {
                    alreadyAdded = true;
                    break;
                }
            }

            if (alreadyAdded)
            {
                Console.WriteLine("This member is already in the book club.");
            }

            else
            {
                var newMember = new Member() { firstName = newFirstName, secondName = newSecondName, favouriteBook = new Book(), readingList = new List<Book> { } };
                members.Add(newMember);
                Console.WriteLine($"{newMember.firstName} {newMember.secondName} has been added to the book club");
            }

        }

    }

    public class Book
    {
        public string title;
        public string author;

        public void ShareBookDetails()
        {
            Console.WriteLine($"The book title is {title} and the author is {author}");
        }
    }

    public class Member
    {
        public string firstName;
        public string secondName;
        public Book favouriteBook;

        public List<Book> readingList;

        public void DisplayMemberDetails()
        {
            Console.WriteLine($"{firstName} {secondName}'s favourite book is {favouriteBook.title} by {favouriteBook.author}");
        }
    }

    //https://dotnetfiddle.net/NZYQ8F

}


