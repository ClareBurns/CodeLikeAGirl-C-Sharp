using System;
using System.Collections.Generic;

namespace ExamCentre.Models
{
    public class Exam
    {
        public string Subject { get; set; }
        public List<Student> Students { get; set; }

        public Exam()
        {
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