using System.Reflection;

namespace AdventOfCode.Utils;

public static class FileReader
{
    public static string[] ReadAllLines(string fileName)
    {
        var fullPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty,
            fileName);

        return File.ReadAllLines(fullPath);
    }
}