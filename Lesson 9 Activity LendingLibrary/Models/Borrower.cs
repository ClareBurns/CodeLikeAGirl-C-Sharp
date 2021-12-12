using System;

namespace Lesson_9_Activity_LendingLibrary.Models
{
    public class Borrower
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int LibraryNumber { get; set; }

        public Borrower(string firstName, string lastName, int libraryNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            LibraryNumber = libraryNumber;
        }

        public void PrintBorrower()
        {
            Console.WriteLine($"\t {FirstName} {LastName}, Library Number: {LibraryNumber}");
        }
    }
}