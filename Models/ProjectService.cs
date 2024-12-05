using System.IO;
using System.Text.Json;

namespace TOP_Planner.Models;

public static class ProjectService
{
    private const string PATH = "project.json";

    public static IEnumerable<Project>? GetAllProjects()
    {
        var json = File.ReadAllText(PATH);
        return JsonSerializer.Deserialize<IEnumerable<Project>>(json);
    }
}
