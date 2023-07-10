namespace StudentsGrades.Model;

public class AverageGrade
{
    public int StudentNumber {get; set; }
    public double Average { get; set; }

    public AverageGrade(int studentNumber, double average) {
        StudentNumber = studentNumber;
        Average = average;
    }
}