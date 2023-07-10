namespace StudentsGrades.Services;

public interface IJsonReader<T>
{
    public List<T> ReadJsonData(string fileName);
}