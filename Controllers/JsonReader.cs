using System.Text.Json;
using StudentsGrades.Services;

namespace StudentsGrades.Controllers;

public class JsonReader : IJsonReader
{
    public List<T> ReadJsonData<T>(string fileName)
    {
        return JsonSerializer.Deserialize<List<T>>(File.ReadAllText(fileName));
    }
}