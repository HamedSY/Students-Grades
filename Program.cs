using Microsoft.Extensions.DependencyInjection;
using StudentsGrades.Controllers;
using StudentsGrades.DIManager;
using StudentsGrades.Model;
using StudentsGrades.Services;
using StudentsGrades.Views;

namespace StudentsGrades;

public class Program
{
    public static void Main(string[] args)
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddGradeService();
        var provider = serviceCollection.BuildServiceProvider();
        var runner = provider.GetRequiredService<IRunner>();
        runner.Run();
    }
}
