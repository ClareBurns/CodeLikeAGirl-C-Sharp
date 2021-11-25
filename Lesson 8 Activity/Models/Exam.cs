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
        }

        public void AddStudent(Student student); 
        {
            Students.Add(student); 
        }
}
}