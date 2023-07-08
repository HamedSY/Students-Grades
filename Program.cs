using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Text.Json;

namespace StudentsGrades
{
    public class Grade
    {
        public int StudentNumber { get; set; }
        public string Lesson { get; set; }
        public double Score { get; set; }
    }

    public class Student
    {
        public int StudentNumber {set; get;}
        public string FirstName {set; get;}
        public string LastName {set; get;}
    }

    class Program
    {
        static void Main(string[] args)
        {
            var students = JsonSerializer.Deserialize<List<Student>>(File.ReadAllText("students.json"));
            var grades = JsonSerializer.Deserialize<List<Grade>>(File.ReadAllText("grades.json"));
        }
    }
}