using System.Collections.Generic;
using System.Linq;
using Blind75CSharp.Week06;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.Week06;

public class Solution06Test
{
   private readonly Solution06 _testObj = new();


   [Fact]
   public void Generate_Pascals()
   {
      _testObj.Generate(5);
   }
   
   
   [Theory]
   [InlineData(new int[] {10, 8, 0, 5, 3}, new int[] {2, 4, 1, 1, 3}, 12, 3)]
   [InlineData(new int[] {0, 2, 4}, new int[] {4, 2, 1}, 100, 1)]
   public void CarFleet_When_We_Ride(int[] position, int[] speed, int target, int expected)
   {
      _testObj.CarFleet(target, position, speed).Should().Be(expected);
   }


   [Theory]
   [InlineData(new[] {0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1}, 6)]
   [InlineData(new[] {4, 2, 0, 3, 2, 5}, 9)]
   public void Trap_Lc(int[] heights, int expected)
   {
      _testObj.Trap(heights).Should().Be(expected);
   }


   [Fact]
   public void LetterCombinations_Lc()
   {
      var expected = new List<string>
      {
         "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"
      };
      // FIXME: this is broken! Need to Recurse/Backtrack
      //_testObj.LetterCombinations("23").Should().BeEquivalentTo(expected);
   }

   [Fact]
   public void RomanToInt_When_Lc()
   {
      _testObj.RomanToInt("III").Should().Be(3);
      _testObj.RomanToInt("MCMXCIV").Should().Be(1994);
   }

   [Theory]
   [InlineData("abca", true)]
   [InlineData("deeee", true)]
   public void ValidPalindrome_When_Lc(string s, bool expected)
   {
      _testObj.ValidPalindrome(s).Should().Be(expected);
   }


   [Theory]
   [InlineData("substitution", "s10n", true)]
   [InlineData("substitution", "sub4u4", true)]
   [InlineData("substitution", "12", true)]
   [InlineData("substitution", "su3i1u2on", true)]
   [InlineData("substitution", "substitution", true)]
   [InlineData("substitution", "s55n", false)]
   [InlineData("substitution", "s010n", false)]
   [InlineData("substitution", "s0ubstitution", false)]
   [InlineData("apple", "a2e", false)]
   public void ValidWordAbbreviation_When_AllLcExamples(string word, string abbr, bool expected)
   {
      _testObj.ValidWordAbbreviation(word, abbr).Should().Be(expected);
   }


   [Fact]
   public void MostVisitedPattern_When_MultipleVisits()
   {
      var usernames = new[] {"ua", "ua", "ua", "ub", "ub", "ub"};
      var timestamps = new[] {1, 2, 3, 4, 5, 6};
      var websites = new[] {"a", "b", "c", "a", "b", "a"};

      var actual = _testObj.MostVisitedPattern(usernames, timestamps, websites);

      var expected = new[] {"a", "b", "a"};
      actual.Should().BeEquivalentTo(expected, cfg => cfg.WithStrictOrdering());
   }

   [Fact]
   public void MostVisitedPattern_When_TimeMattersNonConsecutive()
   {
      var usernames = new[] {"zkiikgv", "zkiikgv", "zkiikgv", "zkiikgv"};
      var timestamps = new[] {436363475, 710406388, 386655081, 797150921};
      var websites = new[] {"wnaaxbfhxp", "mryxsjc", "oz", "wlarkzzqht"};

      var actual = _testObj.MostVisitedPattern(usernames, timestamps, websites);

      var expected = new[] {"oz", "mryxsjc", "wlarkzzqht"};
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