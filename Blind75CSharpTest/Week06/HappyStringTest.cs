using Blind75CSharp.Week06;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.Week06;

public class HappyStringTest
{
   [Theory]
   [InlineData(1, 1, 7, "ccaccbcc")]
   [InlineData(7, 1, 0, "aabaa")]
   [InlineData(2, 4, 1, "bbababc")]
   public void LongestDiverseString_All_Cases(int a, int b, int c, string expected)
   {
      var testObj = new HappyString();
      testObj.LongestDiverseString(a, b, c).Should().Be(expected);
   }
}