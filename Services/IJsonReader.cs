namespace StudentsGrades.Services;

public interface IJsonReader
{
    public List<T> ReadJsonData<T>(string fileName);
}