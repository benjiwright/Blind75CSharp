using AdventOfCode.Utils;
using AdventOfCode.Year2022;
using FluentAssertions;

namespace AdventOfCodeTest;

public class SolverTests
{

   [Fact]
   public void Day01()
   {
      var fileName = @"Year2022\inputs\Day01.txt";
      // top 3 elves
      AoC2022Day01 sut = new();
      sut.Day01(fileName).Should().Be(208_180);
   }
   
   
   [Fact]
   public void Day02()
   {
      var fileName = @"Year2022\inputs\Day02-WarmUp.txt";
      AoC2022Day02 sut = new();
      var lines = FileReader.ReadAllLines(fileName);
      sut.PlayGame(lines).Should().Be(12); // 4 + 1 + 7
   }
   
   [Fact]
   public void Day02_Real()
   {
      var fileName = @"Year2022\inputs\Day02-Real.txt";
      AoC2022Day02 sut = new();
      var lines = FileReader.ReadAllLines(fileName);
      sut.PlayGame(lines).Should().Be(14_416);
   }
   
}