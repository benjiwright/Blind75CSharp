using System.Linq;
using Blind75CSharp.Week06;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.Week06;

public class Solution06Test
{
   private readonly Solution06 _testObj = new();

   [Theory]
   [InlineData("catsandog", new[] {"cats", "dog", "sand", "and", "cat"}, false)]
   [InlineData("catsanddog", new[] {"cats", "dog", "sand", "and", "cat"}, true)]
   public void WordBreak(string input, string[] wordDict, bool expected)
   {
      _testObj.WordBreak(input, wordDict).Should().Be(expected);
   }


   [Theory]
   [InlineData(new[] {3, 5, 6, -3, 7, 11, 1}, new[] {-3, 1, 3, 5, 6, 7, 11})]
   public void QuickSortLists_When_Good(int[] input, int[] expected)
   {
      _testObj.QuickSortLists(input.ToList()).Should()
         .BeEquivalentTo(expected.ToList(),
            cfg => cfg.WithStrictOrdering());
   }
}