using System;
using System.Collections.Generic;

namespace Lesson_7_Activity
{
    class Program
    {
        static void Main(string[] args)
        {
            var Book1 = new Book
            {
                title = "I know why the caged bird sings",
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

            var member1 = new Member
            {
                firstName = "Clare",
                secondName = "Burns",
                favouriteBook = "I know why the caged bird sings"
            };

            var member2 = new Member
            {
                firstName = "Sofia",
                secondName = "Burns",
                favouriteBook = "Ruby Redfort"
            };

            var member3 = new Member
            {
                firstName = "Penny",
                secondName = "Burns",
                favouriteBook = "Midnight Children"
            };

            var members = new List<Member> { member1, member2, member3 };

            foreach (var member in members)
            {
                member.DisplayMemberDetails();
            }
        }
    }

    public class Book
    {
        public string title;
        public string author;
    }
    public class Member
    {
        public string firstName;
        public string secondName;
        public string favouriteBook;

        public void DisplayMemberDetails()
        {
            Console.WriteLine($"{firstName} {secondName}'s favourite book is {favouriteBook}");
        }
    }
}

