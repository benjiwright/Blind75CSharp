using Blind75CSharp.Week01;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.Week01;

public class MaxSubArrayFinderTest
{
   [Theory]
   [InlineData(new int[] {-2, 1, -3, 4, -1, 2, 1, -5, 4}, 6)]
   public void MaxSubArray_When_Valid(int[] input, int expected)
   {
      var testObject = new MaxSubArrayFinder();
      var actual = testObject.MaxSubArray(input);

      actual.Should().Be(expected);
   }

   [Theory]
   [InlineData(new int[] {2, 3, -2, 4}, 6)]
   [InlineData(new int[] {-1, 8}, 8)]
   [InlineData(new int[] {-2, 3, -4}, 24)]
   public void MaxProduct_When_Valid(int[] input, int expected)
   {
      var testObject = new MaxSubArrayFinder();
      var actual = testObject.MaxProduct(input);

      actual.Should().Be(expected);
   }
}