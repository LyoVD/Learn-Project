using Task2_UniversityEmployee.Classes;

namespace Task2_UniversityEmployee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniversityEmployee[] universityEmployees = new UniversityEmployee[10]
            {
                new Teacher(
                    new ("William", 
                         "Black", 
                         new ("London", "Red street", 9, 5)), 
                    253862, 
                    new ("Biology", "Science of living beings")
                    ),
                new SupportStaff(
                    new ("John", 
                         "White", 
                         new ("London", "White street", 3, 15)), 
                    253004, 
                    "security guard"
                    ),
                new DegreeTeacher(
                    new ("Olivia", 
                         "Grey", 
                         new ("London", "Grey street", 19, 25)), 
                    259457, 
                    new ("Biology", "Science of living beings"), 
                    "Bachelor of Science", 
                    "Reader"
                    ),
                new SupportStaff(
                    new ("Emily", 
                         "Green", 
                         new ("London", "Green street", 12, 23)), 
                    250422, 
                    "cleaner"
                    ),
                new Teacher(
                    new ("John", 
                         "Red", 
                         new ("London", "Black street", 8, 9)), 
                    253142, 
                    new ("Geography", "Earth science")
                    ),
                new DegreeTeacher(
                    new ("Ethan", 
                         "Blue", 
                         new ("London", "Blue street", 10, 6)), 
                    247262, 
                    new ("Biology", "Science of living beings"), 
                    "Doctoral Degree", 
                    "Lecturer"
                    ),
                new DegreeTeacher(
                    new ("Riley", 
                         "Yellow", 
                         new ("London", "Yellow street", 59, 1)), 
                    254320, 
                    new ("Biology", "Science of living beings"), 
                    "Doctoral Degree", 
                    "Lecturer"
                    ),
                new Teacher(
                    new ("Emily", 
                         "Brown", 
                         new ("London", "Brown street", 7, 45)), 
                    201562, 
                    new ("Biology", "Science of living beings")
                    ),
                new DegreeTeacher(
                    new ("Lily", 
                         "Purple", 
                         new ("London", "Purple street", 19, 4)), 
                    251212, 
                    new ("Biology", "Science of living beings"), 
                    "Bachelor of Science", 
                    "Reader"
                    ),
                new Teacher(
                    new ("James", 
                         "Orange", 
                         new ("London", "Orange street", 49, 5)), 
                    254239, 
                    new ("Geography", "Earth science")
                    ),
            };

            foreach (UniversityEmployee employee in universityEmployees)
            {
                Console.WriteLine(" " + employee.GetOfficialDuties());
            }

            Console.WriteLine(" ");

            foreach (UniversityEmployee employee in universityEmployees)
            {
                if (employee is Teacher) 
                {
                    Console.WriteLine(" " + employee.GetOfficialDuties());
                }
            }
            
            Console.ReadLine();
            
        }
    }
}