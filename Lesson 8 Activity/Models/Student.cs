namespace ExamCentre.Models
{
    public class Student
    {
        //default property is private
        public int CandidateNumber { get; set; }
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

        internal void AddScore(int score)
        {
            Score = score;
        }
    }
}