using System.Text.Json;
using StudentsGrades.Services;

namespace StudentsGrades.Controllers;

public class JsonReader<T> : IJsonReader<T>
{
    public List<T> ReadJsonData(string fileName)
    {
        return JsonSerializer.Deserialize<List<T>>(File.ReadAllText(fileName));
    }
}