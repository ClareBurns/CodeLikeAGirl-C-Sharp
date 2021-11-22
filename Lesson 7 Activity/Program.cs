using System;
using System.Collections.Generic;

namespace Lesson_7_Activity
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                GiveInstructions();
                var userInput = Console.ReadLine().Trim().ToLower().Replace(" ", "");
                if (userInput == "x")
                {
                    break;
                }

                RespondtoUserCommands(userInput);

                Console.WriteLine("---------------------------------------------------------------");


                var members = DeclareMembers();

                foreach (var member in members)
                {
                    member.DisplayMemberDetails();
                    foreach (var book in member.readingList)
                    {
                        book.ShareBookDetails();
                    }
                }
            }
        }

        static void GiveInstructions()
        {
            Console.WriteLine("Welcome to the book club!");
            Console.WriteLine("To see a list of the recommended books type BOOKS");
            Console.WriteLine("To see a list of the members type MEMBERS");
            Console.WriteLine("To add a new member type NEW MEMBER");
            Console.WriteLine("To add a new book type NEW BOOK");
            Console.WriteLine("To exit the program type X");
        }

        static void RespondtoUserCommands(string userInput)
        {
            var recommendedBooks = DeclareBooks();
            var members = DeclareMembers();

            switch (userInput)
            {
                case "books":
                    DisplayBooks(recommendedBooks);
                    break;
                case "members":
                    Console.WriteLine("members");
                    DisplayMembers(members);
                    break;
                case "addmembers":
                    Console.WriteLine("add members");
                    break;
                case "addbooks":
                    Console.WriteLine("add books");
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

            var recommendedBooks = new List<Book> { Book1, Book2, Book3 };

            return recommendedBooks;
        }

        static List<Member> DeclareMembers()
        {
            var member1 = new Member
            {
                firstName = "Clare",
                secondName = "Burns",
                favouriteBook = "I know why the caged bird sings",
                readingList = new List<Book> { new Book() }
            };

            var member2 = new Member
            {
                firstName = "Sofia",
                secondName = "Burns",
                favouriteBook = "Ruby Redfort",
                readingList = new List<Book> { new Book() }
            };

            var member3 = new Member
            {
                firstName = "Penny",
                secondName = "Burns",
                favouriteBook = "Midnight Children",
                readingList = new List<Book> { new Book() }
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
        public string favouriteBook;

        public List<Book> readingList;

        public void DisplayMemberDetails()
        {
            Console.WriteLine($"{firstName} {secondName}'s favourite book is {favouriteBook}");
        }
    }


    //https://dotnetfiddle.net/NZYQ8F

}


