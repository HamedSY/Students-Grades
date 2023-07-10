using StudentsGrades.Model;

namespace StudentsGrades.Services;

public interface ICalculator
{
    public IOrderedEnumerable<AverageGrade> CalculateAverages(List<Student> students, List<Grade> grades);
}