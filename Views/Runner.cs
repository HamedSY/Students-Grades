using StudentsGrades.Model;
using StudentsGrades.Services;

namespace StudentsGrades.Views;

public class Runner
{
    private const int TopI = 3; // change this if you want to see the top i students

    private readonly ICalculator _calculator;
    private readonly IJsonReader<Student> _studentJsonReader;
    private readonly IJsonReader<Grade> _gradeJsonReader;
    private readonly IPrinter _printer;

    public Runner(ICalculator calculator, IJsonReader<Student> studentJsonReader,
        IJsonReader<Grade> gradeJsonReader, IPrinter printer)
    {
        _calculator = calculator;
        _studentJsonReader = studentJsonReader;
        _gradeJsonReader = gradeJsonReader;
        _printer = printer;
    }

    public void Run()
    {
        var students = _studentJsonReader.ReadJsonData(@"C:\Users\h.sabour\Documents\RiderProjects\StudentsGrades\StudentsGrades\students.json");
        var grades = _gradeJsonReader.ReadJsonData(@"C:\Users\h.sabour\Documents\RiderProjects\StudentsGrades\StudentsGrades\grades.json");
        var averages = _calculator.CalculateAverages(students, grades);
        _printer.PrintTopIStudents(students, averages, TopI);
    }
}