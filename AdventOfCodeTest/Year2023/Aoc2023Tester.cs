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

      var fileName = @$"Year2023\inputs\Day{day}-Part{part}.txt";
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

      var fileName = @$"Year2023\inputs\Day{day}-Part{part}.txt";
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


   [Fact]
   public void Day02_Part01()
   {
      const string day = "02";
      const string part = "01";
      const int expected = 2679;

      int red = 12;
      int green = 13;
      int blue = 14;

      var fileName = @$"Year2023\inputs\Day{day}-Part{part}.txt";
      var lines = FileReader.ReadAllLines(fileName);
      AoC2023Day02 sut = new();
      sut.Part01(lines,red,green,blue).Should().Be(expected);
   }

   [Fact]
   public void Day02_Part02()
   {
      const string day = "02";
      const string part = "02";
      const int expected = 77607;

      var fileName = @$"Year2023\inputs\Day{day}-Part{part}.txt";
      var lines = FileReader.ReadAllLines(fileName);
      AoC2023Day02 sut = new();
      sut.Part02(lines).Should().Be(expected);
   }
   
   [Fact]
   public void Day03_Part01()
   {
      const string day = "03";
      const string part = "01";
      const int expected = 537732;
      var fileName = @$"Year2023\inputs\Day{day}-Part{part}.txt";
      var lines = FileReader.ReadAllLines(fileName);
      AoC2023Day03 sut = new();
      sut.Part01(lines).Should().Be(expected);
   }

   [Fact]
   public void Day03_Part2()
   {
      const string day = "03";
      const string part = "02";
      const int expected = 84_883_664;

      var fileName = @$"Year2023\inputs\Day{day}-Part{part}.txt";
      var lines = FileReader.ReadAllLines(fileName);
      AoC2023Day03 sut = new();
      sut.Part02(lines).Should().Be(expected);
   }
   
   [Fact]
   public void Day04_Part01()
   {
      const string day = "04";
      const string part = "01";
      const int expected = 22488;
      var fileName = @$"Year2023\inputs\Day{day}-Part{part}.txt";
      var lines = FileReader.ReadAllLines(fileName);
      AoC2023Day04 sut = new();
      sut.Part01(lines).Should().Be(expected);
   }
   
   [Fact]
   public void Day04_Part02()
   {
      const string day = "04";
      const string part = "02";
      const int expected = 7_013_204;
      var fileName = @$"Year2023\inputs\Day{day}-Part{part}.txt";
      var lines = FileReader.ReadAllLines(fileName);
      AoC2023Day04 sut = new();
      sut.Part02(lines).Should().Be(expected);
   }
   
   [Fact]
   public void Day06_Part01()
   {
      const string day = "06";
      const string part = "01";
      const int expected = 505_494;
      var fileName = @$"Year2023\inputs\Day{day}-Part{part}.txt";
      var lines = FileReader.ReadAllLines(fileName);
      AoC2023Day06 sut = new();
      sut.Part01(lines).Should().Be(expected);
   }
   
   [Fact]
   public void Day06_Part02()
   {
      const string day = "06";
      const string part = "01"; //repeated
      var expected = 23632299L;
      var fileName = @$"Year2023\inputs\Day{day}-Part{part}.txt";
      var lines = FileReader.ReadAllLines(fileName);
      AoC2023Day06 sut = new();
      sut.Part02(lines).Should().Be(expected);
   }
   
}