using Blind75CSharp.Week06;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.Week06;

public class CountVowelTest
{
   [Theory]
   [InlineData(1, 5)]
   [InlineData(2, 10)]
   [InlineData(5, 68)]
   [InlineData(144, 18208803)]
   public void CountVowelPermutation_AllCases(int input, int expected)
   {
      var testObj = new CountVowel();
      testObj.CountVowelPermutation(input).Should().Be(expected);
   }
}