using StudentsGrades.Controllers;
using StudentsGrades.Model;
using StudentsGrades.Views;

namespace StudentsGrades;

public class Program
{
    public static void Main(string[] args)
    {
        Runner runner = new Runner(new Calculator(), new JsonReader<Student>(),
            new JsonReader<Grade>(), new Printer());
        runner.Run();
    }
}