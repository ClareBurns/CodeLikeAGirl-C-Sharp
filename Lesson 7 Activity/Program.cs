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
                var userInput = Console.ReadLine().Trim().ToLower();
                if (userInput == "x")
                {
                    break;
                }

                var members = CreateMembers();
                var recommendedBooks = ChooseBooks();

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
            Console.WriteLine("To see a list of the members type MEMBERS");
            Console.WriteLine("To see a list of the recommended books type BOOKS");
            Console.WriteLine("To add a new member type NEW MEMBER");
            Console.WriteLine("To add a new book type NEW BOOK");
            Console.WriteLine("To exit the program type X");
        }

        static List<Member> CreateMembers()
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
        static List<Book> ChooseBooks()
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

}


