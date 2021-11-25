using System;
using System.Collections.Generic;

namespace ExamCentre.Models
{
    public class Exam
    {
        public string Subject;
        public List<Student> Students;

        public Exam(string subject)
        {
            Subject = subject;
            Students = new List<Student> { };
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void MarkPaper(int candidateNumber, int examResult)
        {
            var student = Students.Find(x => x.CandidateNumber == candidateNumber);
            student.AddScore(examResult);
        }


    }
}