using Blind75CSharp.Week06;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.Week06;

public class SwimTest
{
   [Fact]
   public void LetsSwimInTheDeepEnd()
   {
      var grid = new[]
      {
         new[] {00, 01, 02, 03, 04},
         new[] {24, 23, 22, 21, 05},
         new[] {12, 13, 14, 15, 16},
         new[] {11, 17, 18, 19, 20},
         new[] {10, 09, 08, 07, 06},
      };

      var testObj = new Swim();
      testObj.SwimInWater(grid).Should().Be(16);
   }

   [Fact]
   public void EasyMode()
   {
      var grid = new[]
      {
         new[] {3, 2},
         new[] {0, 1},
      };

      var testObj = new Swim();
      testObj.SwimInWater(grid).Should().Be(3);
   }
}