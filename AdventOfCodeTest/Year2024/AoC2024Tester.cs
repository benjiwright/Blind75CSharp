using AdventOfCode.Year2024;
using FluentAssertions;

namespace AdventOfCodeTest.Year2024;

public class AoC2024Tester
{
    [Fact]
    public void Day01_SumDistances_WhenSimpleCase()
    {
        var a = new List<int> { 3, 4, 2, 1, 3, 3 };
        var b = new List<int> { 4, 3, 5, 3, 9, 3 };
        var sut = new AoC2024Day01();

        var actual = sut.SumDistances(a, b);

        actual.Should().Be(11);
    }

    [Fact]
    public void Day01_SumDistances_WhenPart1DataSet()
    {
        var fileName = @$"Year2024\Data\Day01.txt";
        var lines = ReadAllLines(fileName);

        var sut = new AoC2024Day01();
        var (a, b) = sut.LinesToLists(lines);

        var actual = sut.SumDistances(a, b);

        actual.Should().Be(1_970_720);
    }

    [Fact]
    public void Day01_LinesToLists_CreatesLists()
    {
        string[] input = new[]
        {
            "1 2",
            "-3 5",
            "100 123",
        };
        var sut = new AoC2024Day01();

        var (actualA, actualB) = sut.LinesToLists(input);

        actualA.Should().ContainInOrder(1, -3, 100);
        actualB.Should().ContainInOrder(2, 5, 123);
    }

    [Fact]
    public void Day01_LinesToLists_HandlesMultipleWhitespace()
    {
        string[] input = new[]
        {
            "1    2",
        };
        var sut = new AoC2024Day01();

        var (actualA, actualB) = sut.LinesToLists(input);

        actualA.Should().ContainInOrder(1);
        actualB.Should().ContainInOrder(2);
    }

    [Fact]
    public void Day01_SimilarityScore_Simple()
    {
        var a = new List<int> { 3, 4, 2, 1, 3, 3 };
        var b = new List<int> { 4, 3, 5, 3, 9, 3 };
        var sut = new AoC2024Day01();

        var actual = sut.SimilarityScore(a, b);

        actual.Should().Be(31);
    }

    [Fact]
    public void Day01_SimilarityScore_Real()
    {
        var fileName = @$"Year2024\Data\Day01.txt";
        var lines = ReadAllLines(fileName);

        var sut = new AoC2024Day01();
        var (a, b) = sut.LinesToLists(lines);

        var actual = sut.SimilarityScore(a, b);

        actual.Should().Be(17191599);
    }


    private static string[] ReadAllLines(string fileName)
    {
        var assemblyLocation = typeof(AoC2024Tester).Assembly.Location;
        var testDirectory = Path.GetDirectoryName(assemblyLocation);
        var fullPath = Path.Combine(testDirectory!, fileName);
        return File.ReadAllLines(fullPath);
    }
}