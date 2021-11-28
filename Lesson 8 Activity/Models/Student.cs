namespace ExamCentre.Models
{
    public class Student
    {
        //default property is internal
        private int CandidateNumber { get; set; }
        private string Name { get; set; }
        public int Score { get; set; }

        public Student(int candidateNumber, string name)
        {
            CandidateNumber = candidateNumber;
            Name = name;
        }

        public Student(int candidateNumber, int score)
        {
            CandidateNumber = candidateNumber;
            Score = score;
        }

        private void AddScore(int score)
        {
            Score = score;
        }
    }
}