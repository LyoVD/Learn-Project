using System;

namespace Task1_Candidate.Classes
{
    public class SubjectScore
    {
        public int Score { get; set; }
        public string Subject { get; set; }
        public SubjectScore(string subject, int score)
        {
            Score = score;
            Subject = subject;
        }
    }
}