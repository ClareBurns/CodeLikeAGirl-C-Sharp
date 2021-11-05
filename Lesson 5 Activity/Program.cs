using System;
using System.Collections.Generic;

namespace Lesson_5_Activity
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defining lists 
            var students = new List<string> { "clare burns", "sofia burns", "gemma burns" };
            var courses = new List<string> { "science", "arts", "commerce" };
            var studentClareBurns = new List<string> { "science" };
            var studentSofiaBurns = new List<string> { "commerce" };
            var studentGemmaBurns = new List<string> { "commerce", "science" };
            var courseScience = new List<string> { "clare burns", "gemma burns" };
            var courseCommerce = new List<string> { "sofia burns", "gemma burns" };
            var courseArts = new List<string> { };

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
                        Console.WriteLine("What is the full name of the student you would like to get the details of?");
                        var studentName = Console.ReadLine().Trim().ToLower();
                        if (students.Contains(studentName))
                        {
                            switch (studentName)
                            {
                                case "clare burns":
                                    Console.Write($"Clare Burns is enrolled in ");
                                    foreach (var course in studentClareBurns)
                                    {
                                        Console.WriteLine($"{course}");
                                    }
                                    break;
                                case "sofia burns":
                                    Console.Write($"Sofia Burns is enrolled in ");
                                    foreach (var course in studentSofiaBurns)
                                    {
                                        Console.WriteLine($"{course}");
                                    }
                                    break;

                                case "gemma burns":
                                    Console.WriteLine($"Gemma Burns is enrolled in: ");
                                    foreach (var course in studentGemmaBurns)
                                    {
                                        Console.WriteLine($"{course}");
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Sorry the student you have entered is not in the database.");
                        }
                        break;
                    case "enrol":
                        Console.WriteLine("Please enter the full name of the student you would like to enrol");
                        var newStudent = Console.ReadLine().Trim().ToLower();
                        while (!string.IsNullOrEmpty(newStudent))
                        {
                            if (students.Contains(newStudent))
                            {
                                Console.WriteLine("Sorry, this student is already enrolled");
                            }
                            else if (int.TryParse(newStudent, out int numberEnrolError))
                            {
                                Console.WriteLine("Sorry, you have entered numbers instead of a name. Please try again");
                            }
                            else
                            {
                                students.Add(newStudent);
                                Console.WriteLine($"{newStudent} has been enrolled. Thank you!");
                            }
                            Console.WriteLine("If you wish to enrol another student please enter their name. Otherwise, press enter.");
                            newStudent = Console.ReadLine().Trim().ToLower();
                        }
                        break;
                    case "unenrol":
                        Console.WriteLine("Please enter the full name of the student you would like to unenrol");
                        var removedStudent = Console.ReadLine().Trim().ToLower();
                        while (!string.IsNullOrEmpty(removedStudent))
                        {
                            if (students.Contains(removedStudent))
                            {
                                students.Remove(removedStudent);
                                Console.WriteLine($"{removedStudent} has been unenrolled. Thank you!");
                            }
                            else if (int.TryParse(removedStudent, out int numberUnenrolError))
                            {
                                Console.WriteLine("Sorry, you have entered numbers instead of a name. Please try again");
                            }
                            else
                            {
                                Console.WriteLine($"{removedStudent} is not currently enrolled.");
                            }
                            Console.WriteLine("If you wish to unenrol another student please enter their name. Otherwise, press enter.");
                            removedStudent = Console.ReadLine().Trim().ToLower();
                        }
                        break;
                    case "add course":
                        Console.WriteLine("Please enter the name of the student you would like to add to the course");
                        studentName = Console.ReadLine().Trim().ToLower();
                        while (!string.IsNullOrEmpty(studentName))
                        {
                            if (!students.Contains(studentName))
                            {
                                Console.WriteLine("Sorry the student you have entered is not in the database. Please enrol this student before adding their courses.");
                            }
                            else
                            {
                                Console.WriteLine($"Please enter the course you would like to enrol {studentName} to");
                                var courseName = Console.ReadLine().Trim().ToLower();
                                while (!string.IsNullOrEmpty(courseName))
                                {
                                    if (!courses.Contains(courseName))
                                    {
                                        Console.WriteLine("Sorry the course you have entered is not offered at the university.");
                                    }
                                    else
                                    {

                                        if (courseName == "science" && !courseScience.Contains(studentName) && courseScience.Count <= 2)
                                        {
                                            courseScience.Add(studentName);
                                        }
                                        else if (courseName == "commerce" && !courseCommerce.Contains(studentName) && courseCommerce.Count <= 2)
                                        {
                                            courseCommerce.Add(studentName);
                                        }
                                        else if (courseName == "arts" && !courseArts.Contains(studentName) && courseArts.Count <= 2)
                                        {
                                            courseArts.Add(studentName);
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry, {courseName} is full! Try again next year.");
                                            break;
                                        }

                                        if (studentName == "clare burns" && !studentClareBurns.Contains(courseName))
                                        {
                                            studentClareBurns.Add(courseName);
                                            Console.WriteLine($"{studentName} is now enrolled in {courseName}");
                                        }
                                        else if (studentName == "sofia burns" && !studentSofiaBurns.Contains(courseName))
                                        {
                                            studentSofiaBurns.Add(courseName);
                                            Console.WriteLine($"{studentName} is now enrolled in {courseName}");
                                        }
                                        else if (studentName == "gemma burns" && !studentGemmaBurns.Contains(courseName))
                                        {
                                            studentGemmaBurns.Add(courseName);
                                            Console.WriteLine($"{studentName} is now enrolled in {courseName}");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry, {studentName} is already enrolled in {courseName}");
                                        }
                                    }
                                    Console.WriteLine($"If you wish to add {studentName} to another course please enter the course. Otherwise, press enter.");
                                    courseName = Console.ReadLine().Trim().ToLower();
                                }
                            }
                            Console.WriteLine("If you wish to add courses to another student please enter their name. Otherwise, press enter.");
                            studentName = Console.ReadLine().Trim().ToLower();
                        }
                        break;
                    case "remove course":
                        Console.WriteLine("Please enter the name of the student you would like to remove from a course");
                        studentName = Console.ReadLine().Trim().ToLower();
                        while (!string.IsNullOrEmpty(studentName))
                        {
                            if (!students.Contains(studentName))
                            {
                                Console.WriteLine("Sorry the student you have entered is not in the database.");
                            }
                            else
                            {
                                Console.WriteLine($"Please enter the course you would like to remove {studentName} from");
                                var courseName = Console.ReadLine().Trim().ToLower();
                                while (!string.IsNullOrEmpty(courseName))
                                {
                                    if (!courses.Contains(courseName))
                                    {
                                        Console.WriteLine("Sorry the course you have entered is not offered at the university.");
                                    }
                                    else
                                    {

                                        if (courseName == "science" && courseScience.Contains(studentName))
                                        {
                                            courseScience.Remove(studentName);
                                        }
                                        else if (courseName == "commerce" && !courseCommerce.Contains(studentName) && courseCommerce.Count <= 2)
                                        {
                                            courseCommerce.Remove(studentName);
                                        }
                                        else if (courseName == "arts" && courseArts.Contains(studentName))
                                        {
                                            courseArts.Remove(studentName);
                                        }
                                        if (studentName == "clare burns" && studentClareBurns.Contains(courseName))
                                        {
                                            studentClareBurns.Remove(courseName);
                                            Console.WriteLine($"{studentName} is now removed from {courseName}");
                                        }
                                        else if (studentName == "sofia burns" && studentSofiaBurns.Contains(courseName))
                                        {
                                            studentSofiaBurns.Remove(courseName);
                                            Console.WriteLine($"{studentName} is now removed in {courseName}");
                                        }
                                        else if (studentName == "gemma burns" && studentGemmaBurns.Contains(courseName))
                                        {
                                            studentGemmaBurns.Remove(courseName);
                                            Console.WriteLine($"{studentName} is now removed in {courseName}");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry, {studentName} is already unenrolled from {courseName}");
                                        }
                                    }
                                    Console.WriteLine($"If you wish to remove {studentName} from another course please enter the course. Otherwise, press enter.");
                                    courseName = Console.ReadLine().Trim().ToLower();
                                }

                            }
                            Console.WriteLine("If you wish to remove courses from another student please enter their name. Otherwise, press enter.");
                            studentName = Console.ReadLine().Trim().ToLower();
                        }
                        break;
                    default:
                        Console.WriteLine("Sorry, the database does not have that function.");
                        break;


                }

                Console.WriteLine("------------------------------------------------------------------------------");
            }
        }
    }
}

// how do variables move from if statements to switch statements etcccc. 
