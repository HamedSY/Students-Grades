namespace StudentsGrades.Model;

public class Grade
{
    public int StudentNumber { get; set; }
    public required string Lesson { get; set; }
    public double Score { get; set; }
}