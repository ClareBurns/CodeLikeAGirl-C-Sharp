using System;
using System.Collections.Generic;

namespace ExamCentre.Models
{
    public class Exam
    {
        public string Subject { get; set; }
        private List<Student> Students { get; set; }

        //default constructor
        public Exam()
        {
            //maths is the default constructor/exam. If not specified it will be Maths.
            Subject = "Maths";
        }

        public Exam(string subject)
        {
            Subject = subject;
            Students = new List<Student> { };
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        //add students: takes a list of students

        public void MarkPaper(int candidateNumber, int examResult)
        {
            var student = Students.Find(x => x.CandidateNumber == candidateNumber);
            student.AddScore(examResult);
        }

    }
}