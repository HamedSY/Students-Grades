using Microsoft.Extensions.DependencyInjection;
using StudentsGrades.Controllers;
using StudentsGrades.Services;
using StudentsGrades.Views;

namespace StudentsGrades.DIManager;

public static class DependecyInjector
{
    public static void AddGradeService(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<ICalculator,Calculator>();
        serviceCollection.AddSingleton<IJsonReader,JsonReader>();
        serviceCollection.AddSingleton<IPrinter,Printer>();
        serviceCollection.AddSingleton<IRunner,Runner>();
    }
}