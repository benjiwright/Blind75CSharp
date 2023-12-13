using AdventOfCode.Utils;
using AdventOfCode.Year2022;
using FluentAssertions;

namespace AdventOfCodeTest;

public class SolverTests
{
   [Fact(Skip = "copy/paste boiler plate")]
   public void Dayxx_Part01()
   {
      const string day = "xx";
      const string part = "01";
      const int expected = 123;

      var fileName = @$"Year2022\inputs\Day{day}-Part{part}.txt";
      var lines = FileReader.ReadAllLines(fileName);
      AoC2022Day04 sut = new();
      sut.Part01(lines).Should().Be(expected);
   }

   [Fact(Skip = "copy/paste boiler plate")]
   public void Dayxx_Part02()
   {
      const string day = "xx";
      const string part = "02";
      const int expected = 123;

      var fileName = @$"Year2022\inputs\Day{day}-Part{part}.txt";
      var lines = FileReader.ReadAllLines(fileName);
      AoC2022Day04 sut = new();
      sut.Part02(lines).Should().Be(expected);
   }

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

   [Fact]
   public void Day04_Part01()
   {
      const string day = "04";
      const string part = "01";
      const int expected = 526;

      var fileName = @$"Year2022\inputs\Day{day}-Part{part}.txt";
      var lines = FileReader.ReadAllLines(fileName);
      AoC2022Day04 sut = new();
      sut.Part01(lines).Should().Be(expected);
   }

   [Fact]
   public void Day04_Part02()
   {
      const string day = "04";
      const string part = "02";
      const int expected = 886;

      var fileName = @$"Year2022\inputs\Day{day}-Part{part}.txt";
      var lines = FileReader.ReadAllLines(fileName);
      AoC2022Day04 sut = new();
      sut.Part02(lines).Should().Be(expected);
   }

   [Fact]
   public void Day05_Part01_WarmUp()
   {
      const string day = "05";
      const string part = "01a";
      const string expected = "CMZ";

      var fileName = @$"Year2022\inputs\Day{day}-Part{part}.txt";
      var lines = FileReader.ReadAllLines(fileName);
      AoC2022Day05 sut = new();
      var actual = sut.Part01(lines);
      actual.Should().Be(expected);
   }
   
   [Fact]
   public void Day05_Part01()
   {
      const string day = "05";
      const string part = "01";
      const string expected = "RLFNRTNFB";

      var fileName = @$"Year2022\inputs\Day{day}-Part{part}.txt";
      var lines = FileReader.ReadAllLines(fileName);
      AoC2022Day05 sut = new();
      var actual = sut.Part01(lines);
      actual.Should().Be(expected);
   }
   
   [Fact]
   public void Day05_Part02()
   {
      const string day = "05";
      const string part = "02";
      const string expected = "MHQTLJRLB";

      var fileName = @$"Year2022\inputs\Day{day}-Part{part}.txt";
      var lines = FileReader.ReadAllLines(fileName);
      AoC2022Day05 sut = new();
      var actual = sut.Part02(lines);
      actual.Should().Be(expected);
   }

   [Theory]
   [InlineData("bvwbjplbgvbhsrlpgdmjqwftvncz",5)]
   [InlineData("nppdvjthqldpwncqszvftbrmjlhg",6)]
   [InlineData("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg",10)]
   [InlineData("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw",11)]
   public void Day06_Part01_SmallData(string input, int expected)
   {
      var sut = new AoC2022Day06();
      var actual = sut.Part01And02(input);
      actual.Should().Be(expected);
   }

   [Fact]
   public void Day06_Part01()
   {
      const string day = "06";
      const string part = "01";
      const int expected = 1142;

      var fileName = @$"Year2022\inputs\Day{day}-Part{part}.txt";
      var lines = FileReader.ReadAllLines(fileName);
      var sut = new AoC2022Day06();
      var actual = sut.Part01And02(lines[0]);
      actual.Should().Be(expected);
   }

   [Fact]
   public void Day06_Part02()
   {
      const string day = "06";
      const string part = "02";
      const int expected = 2803;

      var fileName = @$"Year2022\inputs\Day{day}-Part{part}.txt";
      var lines = FileReader.ReadAllLines(fileName);
      var sut = new AoC2022Day06();
      var actual = sut.Part01And02(lines[0],14);
      actual.Should().Be(expected);
   }
}