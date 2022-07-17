using Blind75CSharp.Week05;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.Week05;

public class Solution05Test
{
   private readonly Solution05 _testObj = new();

   [Fact]
   public void LengthOfLIS_DoThatDp()
   {
      var input = new[] {10, 9, 2, 5, 3, 7, 101, 18}; // 2,3,7,101
      _testObj.LengthOfLIS(input).Should().Be(4);
   }
}