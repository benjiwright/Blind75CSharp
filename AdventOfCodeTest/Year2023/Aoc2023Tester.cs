using AdventOfCode.Utils;
using AdventOfCode.Year2023;
using FluentAssertions;

namespace AdventOfCodeTest.Year2023;

public class Aoc2023Tester
{
    [Fact(Skip = "copy/paste boiler plate")]
    public void DayXX_Part01()
    {
        const string day = "XXX";
        const string part = "01";
        const int expected = -1;

        var fileName = @$"Year2023\inputs\2023\Day{day}-Part{part}.txt";
        var lines = FileReader.ReadAllLines(fileName);
        AoC2023Day01 sut = new();
        sut.Part01(lines).Should().Be(expected);
    }

    [Fact(Skip = "copy/paste boiler plate")]
    public void DayXX_Part02()
    {
        const string day = "XXX";
        const string part = "02";
        const int expected = -1;

        var fileName = @$"Year2023\inputs\2023\Day{day}-Part{part}.txt";
        var lines = FileReader.ReadAllLines(fileName);
        AoC2023Day01 sut = new();
        sut.Part02(lines).Should().Be(expected);
    }

    [Fact]
    public void Day01_Part01()
    {
        const string day = "01";
        const string part = "01";
        const int expected = 56397;
        var fileName = @$"Year2023\inputs\Day{day}-Part{part}.txt";
        var lines = FileReader.ReadAllLines(fileName);
        AoC2023Day01 sut = new();
        sut.Part01(lines).Should().Be(expected);
    }

    [Fact]
    public void Day01_Part2()
    {
        const string day = "01";
        const string part = "02";
        const int expected = 55701;

        var fileName = @$"Year2023\inputs\Day{day}-Part{part}.txt";
        var lines = FileReader.ReadAllLines(fileName);
        AoC2023Day01 sut = new();
        sut.Part02(lines).Should().Be(expected);
    }
}