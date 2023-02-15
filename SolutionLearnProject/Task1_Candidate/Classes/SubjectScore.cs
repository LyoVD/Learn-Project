using System;

namespace Task1_Candidate.Classes
{
    public class SubjectScore
    {
        const int maxScore = 10;
        const int minScore = 0;
        private int _score;
        public int Score 
        { 
            get
            {
                return _score;
            }
            set
            {
                if (value <= maxScore && value >= minScore)
                {
                    _score = value;
                }
            }
        }
        public string Subject { get; set; }
        
        public SubjectScore(string subject, int score)
        {
            Score = score;
            Subject = subject;
        }
    }
}