using System;
using System.Collections.Generic;

namespace Lesson_5_Activity
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defining lists move to repsond to user command method
            var students = new List<string> { "clareburns", "sofiaburns", "gemmaburns" };
            var courses = new List<string> { "science", "arts", "commerce" };
            var studentClareBurns = new List<string> { "science" };
            var studentSofiaBurns = new List<string> { "commerce" };
            var studentGemmaBurns = new List<string> { "commerce", "science" };
            var courseScience = new List<string> { "clareburns", "gemmaburns" };
            var courseCommerce = new List<string> { "sofiaburns", "gemmaburns" };
            var courseArts = new List<string> { };

            while (true)
            {

                GiveInstructions();

                var userInput = Console.ReadLine().Trim().ToLower().Replace(" ", "");

                if (userInput == "x")
                {
                    break;
                }

                RespondToUserCommand(userInput, students, courses, studentClareBurns, studentSofiaBurns, studentGemmaBurns, courseScience, courseArts, courseCommerce);
                Console.WriteLine("------------------------------------------------------------------------------");
            }
        }


        static void GiveInstructions()
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
        }

        static void RespondToUserCommand(string userInput, List<string> students, List<string> courses, List<string> studentClareBurns, List<string> studentSofiaBurns, List<string> studentGemmaBurns, List<string> courseScience, List<string> courseArts, List<string> courseCommerce)
        {
            switch (userInput)
            {


                case "students":
                    ListStudents(students);
                    break;
                case "courses":
                    ListCourses(courses);
                    break;
                case "studentdetails":
                    ShareStudentDetails(studentClareBurns, studentSofiaBurns, studentGemmaBurns);
                    break;
                case "enrol":
                    EnrolStudents(students);
                    break;
                case "unenrol":
                    UnenrolStudents(students);
                    break;
                case "addcourse":
                    AddCourses(students, courses, studentClareBurns, studentSofiaBurns, studentGemmaBurns, courseScience, courseArts, courseCommerce);
                    break;
                case "removecourse":
                    RemoveCourses(students, courses, studentClareBurns, studentSofiaBurns, studentGemmaBurns, courseScience, courseArts, courseCommerce);
                    break;
                default:
                    Console.WriteLine("Sorry, the database does not have that function.");
                    break;

            }

        }
        static void ListStudents(List<string> students)
        {
            Console.WriteLine("The following students are enrolled at the university: ");
            foreach (var student in students)
            {
                Console.WriteLine($"{student}");
            }
        }

        static void ListCourses(List<string> courses)
        {
            Console.WriteLine("The following courses are available at the university: ");
            foreach (var course in courses)
            {
                Console.WriteLine($"{course}");
            }
        }

        static void ShareStudentDetails(List<string> studentClareBurns, List<string> studentSofiaBurns, List<string> studentGemmaBurns)
        {
            Console.WriteLine("What is the full name of the student you would like to get the details of?");
            var studentName = Console.ReadLine().Trim().ToLower().Replace(" ", "");
            switch (studentName)
            {
                case "clareburns":
                    Console.WriteLine($"Clare Burns is enrolled in: ");
                    foreach (var course in studentClareBurns)
                    {
                        Console.WriteLine($"{course}");
                    }
                    break;
                case "sofiaburns":
                    Console.WriteLine($"Sofia Burns is enrolled in: ");
                    foreach (var course in studentSofiaBurns)
                    {
                        Console.WriteLine($"{course}");
                    }
                    break;

                case "gemmaburns":
                    Console.WriteLine($"Gemma Burns is enrolled in: ");
                    foreach (var course in studentGemmaBurns)
                    {
                        Console.WriteLine($"{course}");
                    }
                    break;
                default:
                    Console.WriteLine("Sorry the student you have entered is not in the database.");
                    break;
            }
        }

        static void EnrolStudents(List<string> students)
        {
            Console.WriteLine("Please enter the full name of the student you would like to enrol");
            var newStudent = Console.ReadLine().Trim().ToLower().Replace(" ", "");
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
        }

        static void UnenrolStudents(List<string> students)
        {
            Console.WriteLine("Please enter the full name of the student you would like to unenrol");
            var removedStudent = Console.ReadLine().Trim().ToLower().Replace(" ", "");
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
                removedStudent = Console.ReadLine().Trim().ToLower().Replace(" ", "");
            }
        }

        static void AddCourses(List<string> students, List<string> courses, List<string> studentClareBurns, List<string> studentSofiaBurns, List<string> studentGemmaBurns, List<string> courseScience, List<string> courseArts, List<string> courseCommerce)
        {
            Console.WriteLine("Please enter the name of the student you would like to add to the course");
            var studentName = Console.ReadLine().Trim().ToLower().Replace(" ", "");
            while (!string.IsNullOrEmpty(studentName))
            {
                if (!students.Contains(studentName))
                {
                    Console.WriteLine("Sorry the student you have entered is not in the database. Please enrol this student before adding their courses.");
                }
                else
                {
                    Console.WriteLine($"Please enter the course you would like to enrol {studentName} to");
                    var courseName = Console.ReadLine().Trim().ToLower().Replace(" ", "");
                    while (!string.IsNullOrEmpty(courseName))
                    {
                        if (!courses.Contains(courseName))
                        {
                            Console.WriteLine("Sorry the course you have entered is not offered at the university.");
                        }
                        else
                        {

                            if (courseName == "science" && !courseScience.Contains(studentName) && courseScience.Count < 20)
                            {
                                courseScience.Add(studentName);
                            }
                            else if (courseName == "commerce" && !courseCommerce.Contains(studentName) && courseCommerce.Count < 20)
                            {
                                courseCommerce.Add(studentName);
                            }
                            else if (courseName == "arts" && !courseArts.Contains(studentName) && courseArts.Count < 20)
                            {
                                courseArts.Add(studentName);
                            }
                            else
                            {
                                //make courseArts.Count a boolean
                                Console.WriteLine($"Sorry, {courseName} is full! Try again next year.");
                                break;
                            }

                            if (studentName == "clareburns" && !studentClareBurns.Contains(courseName))
                            {
                                studentClareBurns.Add(courseName);
                                Console.WriteLine($"{studentName} is now enrolled in {courseName}");
                            }
                            else if (studentName == "sofiaburns" && !studentSofiaBurns.Contains(courseName))
                            {
                                studentSofiaBurns.Add(courseName);
                                Console.WriteLine($"{studentName} is now enrolled in {courseName}");
                            }
                            else if (studentName == "gemmaburns" && !studentGemmaBurns.Contains(courseName))
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
                        courseName = Console.ReadLine().Trim().ToLower().Replace(" ", "");
                    }
                }
                Console.WriteLine("If you wish to add courses to another student please enter their name. Otherwise, press enter.");
                studentName = Console.ReadLine().Trim().ToLower().Replace(" ", "");
            }
        }

        static void RemoveCourses(List<string> students, List<string> courses, List<string> studentClareBurns, List<string> studentSofiaBurns, List<string> studentGemmaBurns, List<string> courseScience, List<string> courseArts, List<string> courseCommerce)
        {
            Console.WriteLine("Please enter the name of the student you would like to remove from a course");
            var studentName = Console.ReadLine().Trim().ToLower().Replace(" ", "");
            while (!string.IsNullOrEmpty(studentName))
            {
                if (!students.Contains(studentName))
                {
                    Console.WriteLine("Sorry the student you have entered is not in the database.");
                }
                else
                {
                    Console.WriteLine($"Please enter the course you would like to remove {studentName} from");
                    var courseName = Console.ReadLine().Trim().ToLower().Replace(" ", "");
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
                            else if (courseName == "commerce" && courseCommerce.Contains(studentName))
                            {
                                courseCommerce.Remove(studentName);
                            }
                            else if (courseName == "arts" && courseArts.Contains(studentName))
                            {
                                courseArts.Remove(studentName);
                            }
                            if (studentName == "clareburns" && studentClareBurns.Contains(courseName))
                            {
                                studentClareBurns.Remove(courseName);
                                Console.WriteLine($"{studentName} is now removed from {courseName}");
                            }
                            else if (studentName == "sofiaburns" && studentSofiaBurns.Contains(courseName))
                            {
                                studentSofiaBurns.Remove(courseName);
                                Console.WriteLine($"{studentName} is now removed in {courseName}");
                            }
                            else if (studentName == "gemmaburns" && studentGemmaBurns.Contains(courseName))
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
                        courseName = Console.ReadLine().Trim().ToLower().Replace(" ", "");
                    }

                }
                Console.WriteLine("If you wish to remove courses from another student please enter their name. Otherwise, press enter.");
                studentName = Console.ReadLine().Trim().ToLower().Replace(" ", "");
            }
        }
    }
}

// how do variables move from if statements to switch statements etcccc. 

