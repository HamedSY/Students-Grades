using Model;

namespace View
{
    public class Printer
    {
        public static void PrintTopIStudents(List<Student> students, IOrderedEnumerable<AverageGrade> averages)
        {
            const int topI = 3; // change this if you want to see the top i students
            int i = 0;
            foreach (var average in averages)
            {
                i++;
                Student student = students.Where(s => s.StudentNumber == average.StudentNumber).ToArray()[0];
                Console.WriteLine("The Student Number " + i + ":");
                Console.WriteLine("Firstname: " + student.FirstName);
                Console.WriteLine("Lastname: " + student.LastName);
                Console.WriteLine("Average Grade: " + average.Average);
                Console.WriteLine("----------------------------------");
                if (i == topI) break;
            }
        }
    }
}