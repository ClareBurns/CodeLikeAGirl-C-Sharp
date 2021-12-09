using System;

namespace Lesson_9_Activity_LendingLibrary.Models
{
    public class Borrowers
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int LibraryNumber { get; set; }

        public Borrowers(string firstName, string lastName, int libraryNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            LibraryNumber = libraryNumber;
        }
    }
}