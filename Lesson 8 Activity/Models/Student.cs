namespace ExamCentre.Models
{
    public class Student
    {
        public int CandidateNumber;
        private string Name;
        public int Score;

        public Student(int candidateNumber, string name)
        {
            CandidateNumber = candidateNumber;
            Name = name;
        }

        public void AddScore(int score)
        {
            Score = score;
        }
    }
}