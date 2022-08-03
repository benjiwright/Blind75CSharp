using System.Linq;
using Blind75CSharp.Week06;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.Week06;

public class Solution06Test
{
   private readonly Solution06 _testObj = new();

   [Fact]
   public void MostVisitedPattern_When_MultipleVisits()
   {
      var usernames = new[] {"ua","ua","ua","ub","ub","ub"};
      var timestamps = new[] {1, 2, 3, 4, 5, 6};
      var websites = new[] {"a","b","c","a","b","a"};

      var actual = _testObj.MostVisitedPattern(usernames, timestamps, websites);

      var expected = new[] {"a","b","a"};
      actual.Should().BeEquivalentTo(expected, cfg => cfg.WithStrictOrdering());
   }
   
   [Fact]
   public void MostVisitedPattern_When_TimeMattersNonConsecutive()
   {
      var usernames = new[] {"zkiikgv","zkiikgv","zkiikgv","zkiikgv"};
      var timestamps = new[] {436363475,710406388,386655081,797150921};
      var websites = new[] {"wnaaxbfhxp","mryxsjc","oz","wlarkzzqht"};

      var actual = _testObj.MostVisitedPattern(usernames, timestamps, websites);

      var expected = new[] {"oz","mryxsjc","wlarkzzqht"};
      actual.Should().BeEquivalentTo(expected, cfg => cfg.WithStrictOrdering());
   }

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