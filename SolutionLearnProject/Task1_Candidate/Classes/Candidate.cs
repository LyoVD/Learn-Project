using System;

namespace Task1_Candidate.Classes
{
    public class Candidate
    {
        public SubjectScore[] SubjectScore { get; set; }
        public Person Person { get; set; }
        public Candidate(Person person, SubjectScore[] subjectScore)
        {
            Person = person;
            SubjectScore = subjectScore;

        }
    }
}