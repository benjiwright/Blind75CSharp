using System.Collections.Generic;
using Blind75CSharp.DpBootcamp;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.DpBootcampTest;

public class DynamicProgrammerTest
{
   private readonly DynamicProgrammer _testObject = new DynamicProgrammer();

   [Theory]
   [InlineData(1, 1, 1)]
   [InlineData(2, 3, 3)]
   [InlineData(3, 2, 3)]
   [InlineData(3, 3, 6)]
   [InlineData(10, 20, 6_906_900)]
   public void GridTraveler_When_Valid(int m, int n, int result)
   {
      _testObject.GridTraveler(m, n).Should().Be(result);
   }

   [Theory]
   [InlineData(7, new int[] {2, 3}, true)]
   [InlineData(7, new int[] {5, 3, 4, 7}, true)]
   [InlineData(7, new int[] {2, 4}, false)]
   [InlineData(8, new int[] {2, 3, 5}, true)]
   [InlineData(300, new int[] {7, 14}, false)]
   public void CanSum_When_Valid(int targetSum, int[] nums, bool result)
   {
      _testObject.CanSum(targetSum, nums).Should().Be(result);
   }

   [Fact]
   public void HowSum_When_Valid()
   {
      _testObject.HowSum(7, new[] {2, 3}).Should().BeEquivalentTo(new List<int> {3, 2, 2});
      _testObject.HowSum(7, new[] {5, 3, 4, 7}).Should().BeEquivalentTo(new List<int> {3, 4});
      _testObject.HowSum(7, new[] {2, 4}).Should().BeNull();
      _testObject.HowSum(300, new[] {7, 14}).Should().BeNull();
   }

   [Theory]
   [InlineData(5, 5)]
   [InlineData(6, 8)]
   public void FibTabualtion_When_Valid(int num, int expected)
   {
      _testObject.FibTabualtion(num).Should().Be(expected);
   }
}