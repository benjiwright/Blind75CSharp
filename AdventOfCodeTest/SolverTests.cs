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
   
   [Fact]
   public void Day03_WarmUp()
   {
      var fileName = @"Year2022\inputs\Day03-WarmUp.txt";
      var lines = FileReader.ReadAllLines(fileName);
      AoC2022Day03 sut = new(lines);
      // 16 (p), 38 (L), 42 (P), 22 (v), 20 (t), and 19 (s)
      sut.Part01().Should().Be(157);
   }
   
   [Fact]
   public void Day03_WarmUpLarge()
   {
      var fileName = @"Year2022\inputs\Day03-WarmUpLarge.txt";
      var lines = FileReader.ReadAllLines(fileName);
      AoC2022Day03 sut = new(lines);
      sut.Part01().Should().Be(7428);
   }
   
   [Fact]
   public void Day03_Part02WarmUp()
   {
      var fileName = @"Year2022\inputs\Day03-Part02-WarmUp.txt";
      var lines = FileReader.ReadAllLines(fileName);
      AoC2022Day03 sut = new(lines);
      sut.Part02().Should().Be(70);
   }
   
   [Fact]
   public void Day03_Part02_Large()
   {
      var fileName = @"Year2022\inputs\Day03-WarmUpLarge.txt";
      var lines = FileReader.ReadAllLines(fileName);
      AoC2022Day03 sut = new(lines);
      sut.Part02().Should().Be(2650);
   }

   
}