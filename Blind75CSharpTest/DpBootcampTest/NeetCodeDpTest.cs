using Blind75CSharp.DpBootcamp;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.DpBootcampTest;

public class NeetCodeDpTest
{
   [Theory]
   [InlineData(0, 0)]
   [InlineData(1, 1)]
   [InlineData(2, 2)]
   [InlineData(5, 8)]
   [InlineData(1_000, 1_318_412_525)]
   public void ClimbStairs_When_Many(int stairs, int expected)
   {
      var testObj = new NeetCodeDp();
      testObj.ClimbStairs(stairs).Should().Be(expected);
   }
}