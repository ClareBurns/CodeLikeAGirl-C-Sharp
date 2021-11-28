using System;
using System.Collections.Generic;
using ExamCentre.Models;

namespace ExamCentre
{
    class Program
    {
        static void Main(string[] args)
        {
            var exam = new Exam("BioChemistry");

            var student1 = new Student(1, "Clare");
            var student2 = new Student(2, "Sofia");
            var student3 = new Student(3, "Gemma");

            var student4 = new Student(4, 50);

            exam.AddStudent(student1);
            exam.AddStudent(student2);
            exam.AddStudent(student3);

            exam.MarkPaper(1, 60);
            exam.MarkPaper(2, 90);
            exam.MarkPaper(3, 70);

            Console.WriteLine(student1.Score);
            Console.WriteLine(student4.Score);
        }
    }
}

