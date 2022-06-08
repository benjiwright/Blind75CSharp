using Blind75CSharp.Week01;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.Week01;

public class MaxSubArrayFinderTest
{
   [Fact]
   public void MaxSubArrayFinderTest_When_Valid()
   {
      var input = new int[] {-2, 1, -3, 4, -1, 2, 1, -5, 4};
      var testObject = new MaxSubArrayFinder();
      var actual = testObject.MaxSubArray(input);

      actual.Should().Be(6);
   }
}