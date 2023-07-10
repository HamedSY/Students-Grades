using Model;

namespace Controller
{
    public class Calculator
    {
        public static IOrderedEnumerable<AverageGrade> CalculateAverages(List<Student> students, List<Grade> grades) 
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
}