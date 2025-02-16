namespace StudentGradingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>(); //List of students in the system

            while (true) 
            { 
                Console.WriteLine("Welcome to the grading system");
                Console.WriteLine("Please enter 'done' when you finished instead of your name.");
                Console.Write("Please enter your name: ");
                string studentName = Console.ReadLine();

                if (studentName.ToLower() == "done")
                    break;

                List<int> studentGrades = new List<int>(); //List of grades for a specific student

                Console.WriteLine("Please enter your grades: (5 Subjects)");
                for(int i = 1; i <= 5; i++)
                {
                    Console.Write($"Subject {i}: ");
                    int gradeValue = Convert.ToInt32(Console.ReadLine());
                    studentGrades.Add(gradeValue);
                }
                Student student = new Student() { Grades = studentGrades, Name = studentName };
                students.Add(student);
                Console.WriteLine($"A new student added to the system with name {student.Name}, With total {student.Grades.Count()} subjects successfully.");

            }

            GradingSystem gradingSystem = new GradingSystem();
            gradingSystem.DisplayGradingInfo(students, calculateAverageType01, isUserPassed => isUserPassed>=30, displayData);


        }

        private static void displayData(Student student, double avgGrades, bool isStudentPass)
        {
            string status = "Failed";

            if (isStudentPass)
                status = "Passed";

            Console.WriteLine($"Name: {student.Name} \t Average Grade: {avgGrades} \t Status: {status} ");
        }

        private static double calculateAverageType01(List<int> grades)
        {
            return (double)grades.Sum()/grades.Count();
        }

        private static bool checkIfStudentPassed(double avgGrade)
        {
            return avgGrade >= 40;
        }



    }
}
