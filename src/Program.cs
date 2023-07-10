using System.Text.Json;
using Model;
using Controller;
using View;

namespace StudentsGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = JsonSerializer.Deserialize<List<Student>>(File.ReadAllText("students.json"));
            var grades = JsonSerializer.Deserialize<List<Grade>>(File.ReadAllText("grades.json"));

            var averages = Calculator.CalculateAverages(students, grades);
            
            Printer.PrintTopIStudents(students, averages);
        }
    }
}