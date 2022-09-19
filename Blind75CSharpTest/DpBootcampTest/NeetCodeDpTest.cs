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


   [Theory]
   [InlineData(new[] {10, 15, 20}, 15)]
   [InlineData(new[] {1, 100, 1, 1, 1, 100, 1, 1, 100, 1}, 6)]
   public void MinCostClimbingStairs_When_Many(int[] costs, int expected)
   {
      var testObj = new NeetCodeDp();
      testObj.MinCostClimbingStairs(costs).Should().Be(expected);
   }
   
   [Theory]
   [InlineData(new[] {1,2,3}, 3)]
   [InlineData(new[] {1,2,1,1}, 3)]
   public void HouseRobber_When_Many(int[] costs, int expected)
   {
      var testObj = new NeetCodeDp();
      testObj.Rob(costs).Should().Be(expected);
   }
}