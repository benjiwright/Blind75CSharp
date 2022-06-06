using Blind75CSharp.Week01;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.Week01;

public class TwoSummerTest
{
   private readonly TwoSummer _testObject = new TwoSummer();

   [Fact]
   public void TwoSumTest_When_Valid()
   {
      var input = new int[] {2, 7, 11, 15};
      var actual = _testObject.TwoSum(input, 9);

      actual.Should().Contain(new int[] {0, 1});
   }
}