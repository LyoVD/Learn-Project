using Task1_Candidate.Classes;

namespace Task1_Candidate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Candidate[] candidates = new Candidate[5];

            Person person1 = new Person("Ivan", "Ivanov", new Address("Moscow", "Krasnozvezdnaya street", "95D", "58"));
            SubjectScore[] subjectScores1 = new SubjectScore[10] 
            { 
                new SubjectScore("Math", 9),
                new SubjectScore("Physics", 10),
                new SubjectScore("English", 8),
                new SubjectScore("Russian", 9),
                new SubjectScore("Biology", 7),
                new SubjectScore("Chemistry", 6),
                new SubjectScore("Physical culture", 6),
                new SubjectScore("Geography", 7),
                new SubjectScore("History", 5),
                new SubjectScore("Music", 8)
            };

            Person person2 = new Person("Petr", "Petrov", new Address("Paris", "Rivoli street", "7G", "6"));
            SubjectScore[] subjectScores2 = new SubjectScore[10] 
            { 
                new SubjectScore("Math", 5),
                new SubjectScore("Physics", 6),
                new SubjectScore("English", 9),
                new SubjectScore("Russian", 4),
                new SubjectScore("Biology", 8),
                new SubjectScore("Chemistry", 8),
                new SubjectScore("Physical culture", 7),
                new SubjectScore("Geography", 8),
                new SubjectScore("History", 7),
                new SubjectScore("Music", 6)
            };
            
            Person person3 = new Person("Jack", "O'honor", new Address("London", "Bond street", "43", "21"));
            SubjectScore[] subjectScores3 = new SubjectScore[10] 
            { 
                new SubjectScore("Math", 6),
                new SubjectScore("Physics", 5),
                new SubjectScore("English", 7),
                new SubjectScore("Russian", 2),
                new SubjectScore("Biology", 6),
                new SubjectScore("Chemistry", 5),
                new SubjectScore("Physical culture", 8),
                new SubjectScore("Geography", 9),
                new SubjectScore("History", 9),
                new SubjectScore("Music", 9)
            };
            
            Person person4 = new Person("Peter", "Black", new Address("Boston", "Washington street", "54", "21"));
            SubjectScore[] subjectScores4 = new SubjectScore[10] 
            { 
                new SubjectScore("Math", 6),
                new SubjectScore("Physics", 7),
                new SubjectScore("English", 6),
                new SubjectScore("Russian", 4),
                new SubjectScore("Biology", 8),
                new SubjectScore("Chemistry", 6),
                new SubjectScore("Physical culture", 9),
                new SubjectScore("Geography", 6),
                new SubjectScore("History", 9),
                new SubjectScore("Music", 8)
            };
            
            Person person5 = new Person("Paulo", "Medici", new Address("Romе", "Giulia street", "24", "6"));
            SubjectScore[] subjectScores5 = new SubjectScore[10] 
            { 
                new SubjectScore("Math", 7),
                new SubjectScore("Physics", 7),
                new SubjectScore("English", 6),
                new SubjectScore("Russian", 4),
                new SubjectScore("Biology", 9),
                new SubjectScore("Chemistry", 7),
                new SubjectScore("Physical culture", 5),
                new SubjectScore("Geography", 7),
                new SubjectScore("History", 6),
                new SubjectScore("Music", 6)
            };

            candidates[0] = new Candidate(person1, subjectScores1);
            candidates[1] = new Candidate(person2, subjectScores2);
            candidates[2] = new Candidate(person3, subjectScores3);
            candidates[3] = new Candidate(person4, subjectScores4);
            candidates[4] = new Candidate(person5, subjectScores5);






            Console.WriteLine("Hello, World!");
        }
    }
}