using Task2_UniversityEmployee.Classes;

namespace Task2_UniversityEmployee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniversityEmployee[] universityEmployees = new UniversityEmployee[10]
            {
                new Teacher(new Person("William", "Black", new Address("London", "Red street", "9", "5")), "253862", new Course("Biology", "Science of living beings")),
                new SupportStaff(new Person("John", "White", new Address("London", "White street", "3", "15")), "253004", "security guard"),
                new DegreeTeacher(new Person("Olivia", "Grey", new Address("London", "Grey street", "19", "25")), "259457", new Course("Biology", "Science of living beings"), "Bachelor of Science", "Reader"),
                new SupportStaff(new Person("Emily", "Green", new Address("London", "Green street", "12", "23")), "250422", "cleaner"),
                new Teacher(new Person("John", "Red", new Address("London", "Black street", "8", "9")), "253142", new Course("Geography", "Earth science")),
                new DegreeTeacher(new Person("Ethan", "Blue", new Address("London", "Blue street", "10", "6")), "247262", new Course("Biology", "Science of living beings"), "Doctoral Degree", "Lecturer"),
                new DegreeTeacher(new Person("Riley", "Yellow", new Address("London", "Yellow street", "59", "1")), "254320", new Course("Biology", "Science of living beings"), "Doctoral Degree", "Lecturer"),
                new Teacher(new Person("Emily", "Brown", new Address("London", "Brown street", "7", "45")), "201562", new Course("Biology", "Science of living beings")),
                new DegreeTeacher(new Person("Lily", "Purple", new Address("London", "Purple street", "19", "4")), "251212", new Course("Biology", "Science of living beings"), "Bachelor of Science", "Reader"),
                new Teacher(new Person("James", "Orange", new Address("London", "Orange street", "49", "5")), "254239", new Course("Geography", "Earth science")),
            };

            foreach (UniversityEmployee i in universityEmployees)
            {
                Console.WriteLine(" " + i.GetOfficialDuties());
            }

            Console.WriteLine(" ");

            foreach (UniversityEmployee i in universityEmployees)
            {
                if ((i is Teacher) || (i is DegreeTeacher))
                {
                    Console.WriteLine(" " + i.GetOfficialDuties());
                }
            }
            
            Console.ReadLine();
            
        }
    }
}