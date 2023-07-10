using StudentsGrades.Model;
using StudentsGrades.Services;

namespace StudentsGrades.Views;

public class Runner : IRunner
{
    private const int TopI = 3; // change this if you want to see the top i students

    private readonly ICalculator _calculator;
    private readonly IJsonReader _jsonReader;
    private readonly IPrinter _printer;

    public Runner(ICalculator calculator, IJsonReader jsonReader, IPrinter printer)
    {
        _calculator = calculator;
        _jsonReader = jsonReader;
        _printer = printer;
    }

    public void Run()
    {
        var students =
            _jsonReader.ReadJsonData<Student>(
                @"C:\Users\h.sabour\Documents\RiderProjects\StudentsGrades\StudentsGrades\students.json");
        var grades =
            _jsonReader.ReadJsonData<Grade>(
                @"C:\Users\h.sabour\Documents\RiderProjects\StudentsGrades\StudentsGrades\grades.json");
        var averages = _calculator.CalculateAverages(students, grades);
        _printer.PrintTopIStudents(students, averages, TopI);
    }
}