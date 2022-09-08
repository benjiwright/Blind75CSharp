using Blind75CSharp.Week06;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.Week06;

public class BananasTest
{
   [Theory]
   [InlineData(new [] {805_306_368,805_306_368,805_306_368},1_000_000_000, 3)]
   [InlineData(new []{3, 6, 7, 11}, 8, 4)]
   public void Bananas_MinEatingSpeed(int [] input, int hours, int expected)
   {
      var testObj = new Bananas();
      testObj.MinEatingSpeed(input, hours).Should().Be(expected);
   }
}

