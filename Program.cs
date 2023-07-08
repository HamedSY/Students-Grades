using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Text.Json;
using Microsoft.VisualBasic;

namespace StudentsGrades
{
    public class Grade
    {
        public int StudentNumber { get; set; }
        public string Lesson { get; set; }
        public double Score { get; set; }
    }

    public class AverageGrade
    {
        public int StudentNumber {get; set; }
        public double Average { get; set; }

        public AverageGrade(int studentNumber, double average) {
            StudentNumber = studentNumber;
            Average = average;
        }
    }

    public class Student
    {
        public int StudentNumber {set; get;}
        public string FirstName {set; get;}
        public string LastName {set; get;}
    }

    class Program
    {
        public static IOrderedEnumerable<AverageGrade> calculateAverages(List<Student> students, List<Grade> grades) 
        {
            var studentsAverageGrades = new List<AverageGrade>();
            for (int i = 1; i <= students.Count; i++)
            {
                var ithStudentGrades = grades.Where(g => g.StudentNumber == i);
                double averageGrade = Queryable.Average(ithStudentGrades.Select(i => i.Score).AsQueryable());
                studentsAverageGrades.Add(new AverageGrade(i, averageGrade));
            }
            
            var sortedAverageGrades = studentsAverageGrades.OrderByDescending(g => g.Average);

            return sortedAverageGrades;
        }

        public static void printTopIStudents(List<Student> students, IOrderedEnumerable<AverageGrade> averages)
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

        static void Main(string[] args)
        {
            var students = JsonSerializer.Deserialize<List<Student>>(File.ReadAllText("students.json"));
            var grades = JsonSerializer.Deserialize<List<Grade>>(File.ReadAllText("grades.json"));

            var averages = calculateAverages(students, grades);
            
            printTopIStudents(students, averages);
        }
    }
}