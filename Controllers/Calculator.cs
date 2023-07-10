using StudentsGrades.Model;
using StudentsGrades.Services;

namespace StudentsGrades.Controllers;

public class Calculator : ICalculator
{
    public IOrderedEnumerable<AverageGrade> CalculateAverages(List<Student> students, List<Grade> grades)
    {
        var studentsAverageGrades = new List<AverageGrade>();
        for (int i = 1; i <= students.Count; i++)
        {
            var ithStudentGrades = grades.Where(g => g.StudentNumber == i);
            var averageGrade = Queryable.Average(ithStudentGrades.Select(i => i.Score).AsQueryable());
            studentsAverageGrades.Add(new AverageGrade(i, averageGrade));
        }

        var sortedAverageGrades = studentsAverageGrades.OrderByDescending(g => g.Average);

        return sortedAverageGrades;
    }
}