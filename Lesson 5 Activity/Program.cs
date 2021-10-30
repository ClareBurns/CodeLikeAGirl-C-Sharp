using System;
using System.Collections.Generic;

namespace Lesson_5_Activity
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defining lists 
            var students = new List<string> { "Clare Burns", "Sofia Burns", "Gemma Burns" };
            var courses = new List<string> { "Science", "Arts", "Commence", "IT" };
            var studentClareBurns = new List<string> { "Science" };
            var studentSofiaBurns = new List<string> { "Commence" };
            var studentGemmaBurns = new List<string> { "Commence", "IT" };
            var courseScience = new List<string> { "Clare Burns" };
            var courseCommence = new List<string> { "Sofia Burns", "Gemma Burns" };
            var courseArts = new List<string> { };
            var courseIT = new List<string> { "Gemma Burns" };

            while (true)
            {
                Console.WriteLine("Welcome to the university's database.");
                Console.WriteLine("This database has the following functions:");
                Console.WriteLine("List the students enrolled at the university. To see this type STUDENTS.");
                Console.WriteLine("List the courses avaliable at the university. To see this type COURSES.");
                Console.WriteLine("List the courses each student is enrolled in. To see this type STUDENT DETAILS");
                Console.WriteLine("Enrol students to the university. To do this type ENROL");
                Console.WriteLine("Unenrol students from the university. To do this type UNENROL");
                Console.WriteLine("Add students to a specific course. To do this type ADD COURSE");
                Console.WriteLine("Remove students from a specific course. To do this type REMOVE COURSE");
                Console.WriteLine("Exit the program. Type X.");
                var userInput = Console.ReadLine().Trim().ToLower();

                if (userInput == "x")
                {
                    break;
                }

                switch (userInput)
                {
                    case "students":
                        Console.WriteLine("The following students are enrolled at the university: ");
                        foreach (var student in students)
                        {
                            Console.WriteLine($"{student}");
                        }
                        break;
                    case "courses":
                        Console.WriteLine("The following courses are avaliable at the university: ");
                        foreach (var course in courses)
                        {
                            Console.WriteLine($"{course}");
                        }
                        break;
                    case "student details":
                        Console.WriteLine("What is the full name of the student you would like to");
                        var studentName = Console.ReadLine().Trim().ToLower();
                        if (studentName == "clare burns")
                        {
                            Console.Write($"Clare Burns is enrolled in ");
                            foreach (var course in studentClareBurns)
                            {
                                Console.WriteLine($"{course}");
                            }
                        }
                        if (studentName == "sofia burns")
                        {
                            Console.Write($"Sofia Burns is enrolled in ");
                            foreach (var course in studentSofiaBurns)
                            {
                                Console.WriteLine($"{course}");
                            }
                        }
                        if (studentName == "gemma burns")
                        {
                            Console.Write($"Gemma Burns is enrolled in ");
                            foreach (var course in studentGemmaBurns)
                            {
                                Console.WriteLine($"{course}");
                            }
                        }
                        break;
                    case "enrol":
                        Console.WriteLine("How many students would you like to enrol today?");
                        var enrollmentNumber = int.Parse(Console.ReadLine());
                        for (var i = 1; i <= enrollmentNumber; i++)
                        {
                            Console.WriteLine("Please enter the full name of the student you would like to enrol");
                            var newStudent = Console.ReadLine();
                            students.Add(newStudent);
                            Console.WriteLine($"{newStudent} has been enrolled. Thank you!");
                        }
                        break;
                    case "unenrol":
                        Console.WriteLine("How many students would you like to unenrol today?");
                        var unenrollmentNumber = int.Parse(Console.ReadLine());
                        for (var i = 1; i <= unenrollmentNumber; i++)
                        {
                            Console.WriteLine("Please enter the full name of the student you would like to enrol");
                            var removedStudent = Console.ReadLine();
                            students.Remove(removedStudent);
                            Console.WriteLine($"{removedStudent} has been unenrolled. Thank you!");
                        }
                        break;
                    /*case "add course":
                        Console.WriteLine("What is the full name of the student you would like to add courses for?");
                        studentName = Console.ReadLine();
                        while (true)
                        {
                            Console.WriteLine("What courses would you like to add? Type X when you are done adding courses.");
                            var addedCourse = Console.ReadLine();
                            if (addedCourse == "X")
                            {
                                break;
                            }
                            else
                            {
                                var student{ } = Console.ReadLine();
                                students.Remove(removedStudent);
                                Console.WriteLine($"{removedStudent} has been unenrolled. Thank you!");
                            }
                        }
                        break; */
                    default:
                        Console.WriteLine("Sorry, the database does not have that function.");
                        break;
                }

                //need to use a for each loop even if just one variable? 
                //how do you make a list using a for loop? --> make an empty array
            }
        }
    }

}

