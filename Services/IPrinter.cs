using StudentsGrades.Model;

namespace StudentsGrades.Services;

public interface IPrinter
{
    public void PrintTopIStudents(List<Student> students, IOrderedEnumerable<AverageGrade> averages, int topI);
}