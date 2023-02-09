using Task1_Candidate.Classes;

namespace Task1_Candidate
{
    internal class Program
    {
        const string Subject = "Russian";
        static void Main(string[] args)
        {
            Person person1 = new(
                "Ivan",
                "Ivanov",
                new("Moscow", "Krasnozvezdnaya street", 95, 58)
                );

            SubjectScore[] subjectScores1 = new SubjectScore[10]
            {
                new ("Math", 9),
                new ("Physics", 10),
                new ("English", 8),
                new ("Russian", 7),
                new ("Biology", 7),
                new ("Chemistry", 6),
                new ("Physical culture", 6),
                new ("Geography", 7),
                new ("History", 5),
                new ("Music", 8)
            };

            Person person2 = new(
                "Petr",
                "Petrov",
                new("Paris", "Rivoli street", 7, 6)
                );

            SubjectScore[] subjectScores2 = new SubjectScore[10]
            {
                new ("Math", 5),
                new ("Physics", 6),
                new ("English", 9),
                new ("Russian", 4),
                new ("Biology", 8),
                new ("Chemistry", 8),
                new ("Physical culture", 7),
                new ("Geography", 8),
                new ("History", 7),
                new ("Music", 6)
            };

            Person person3 = new(
                "Jack",
                "O'honor",
                new("London", "Bond street", 43, 21)
                );

            SubjectScore[] subjectScores3 = new SubjectScore[10]
            {
                new ("Math", 6),
                new ("Physics", 5),
                new ("English", 7),
                new ("Russian", 2),
                new ("Biology", 6),
                new ("Chemistry", 5),
                new ("Physical culture", 8),
                new ("Geography", 9),
                new ("History", 9),
                new ("Music", 9)
            };

            Person person4 = new(
                "Peter",
                "Black",
                new("Boston", "Washington street", 54, 21)
                );

            SubjectScore[] subjectScores4 = new SubjectScore[10]
            {
                new ("Math", 6),
                new ("Physics", 7),
                new ("English", 6),
                new ("Russian", 4),
                new ("Biology", 8),
                new ("Chemistry", 6),
                new ("Physical culture", 9),
                new ("Geography", 6),
                new ("History", 9),
                new ("Music", 8)
            };

            Person person5 = new(
                "Paulo",
                "Medici",
                new("Romе", "Giulia street", 24, 6)
                );

            SubjectScore[] subjectScores5 = new SubjectScore[10]
            {
                new ("Math", 7),
                new ("Physics", 7),
                new ("English", 6),
                new ("Russian", 4),
                new ("Biology", 9),
                new ("Chemistry", 7),
                new ("Physical culture", 5),
                new ("Geography", 7),
                new ("History", 6),
                new ("Music", 6)
            };

            Candidate[] candidates = new Candidate[5] {
                new(person1, subjectScores1),
                new(person2, subjectScores2),
                new(person3, subjectScores3),
                new(person4, subjectScores4),
                new(person5, subjectScores5)
            };

            foreach (var candidate in candidates)
            {
                Console.WriteLine(candidate.Person.Address.Street);
            }

            int maxScore = 0;
            for (int i = 0; i < candidates.Length; i++)
            {
                for (int j = 0; j < candidates[i].SubjectScore.Length; j++)
                {
                    if (candidates[i].SubjectScore[j].Subject == Subject 
                        && maxScore < candidates[i].SubjectScore[j].Score)
                    {
                        maxScore = candidates[i].SubjectScore[j].Score;
                        
                    }
                }
            }
            Console.WriteLine(maxScore);

            Console.ReadLine();
        }
    }
}