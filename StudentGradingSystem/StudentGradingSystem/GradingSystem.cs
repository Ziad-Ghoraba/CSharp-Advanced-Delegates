using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradingSystem
{
    class GradingSystem
    {
        public void DisplayGradingInfo(List<Student> students,
            Func<List<int>, double> calculateAverage,
            Predicate<double> checkIfPassed,
            Action<Student, double, bool> displayData)
        {
            foreach(Student student in students)
            {
                double avgGrades = calculateAverage(student.Grades);
                bool isStudentPass = checkIfPassed(avgGrades);
                displayData(student, avgGrades, isStudentPass);
            }
        }
    }
}
