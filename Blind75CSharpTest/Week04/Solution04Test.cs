using System;
using Blind75CSharp.Week04;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.Week04;

public class Solution04Test
{
   private readonly Solution04 _testObj = new Solution04();


   [Fact]
   public void AlienDictionary_When_BadLeetCodeTestCaseBugfixInDescription()
   {
      var input = new[] {"qb", "qts", "qs", "qa", "s"};
      _testObj.AlienOrder(input).Should().Be("qbtsa");
   }

   [Fact]
   public void AlienOrder_When_Valid()
   {
      _testObj.AlienOrder(new string[] {"wrt", "wrf", "er", "ett", "rftt"}).Should().Be("wertf");
   }

   [Fact]
   public void AlienOrder_When_TruncatingWordAddressingLeetCodeBug()
   {
      // Description: A string s is lexicographically smaller than a string t if at the first letter where they differ,
      // the letter in s comes before the letter in t in the alien language. If the first min(s.length, t.length)
      // letters are the same, then s is smaller if and only if s.length < t.length.
      // **sigh** 
      _testObj.AlienOrder(new string[] {"abc", "ab"}).Should().Be(string.Empty);
   }


   [Fact]
   public void CountComponents_When_SoloIslands()
   {
      var input = new int[][]
      {
         new int[] {0, 1}, new int[] {1, 2}, new int[] {3, 4}
      };
      _testObj.CountComponents(5, input).Should().Be(2);
   }

   [Fact]
   public void CountComponents_When_MultipleIslands()
   {
      var input = new int[][]
      {
         new int[] {0, 1},
         new int[] {1, 2},
         new int[] {3, 4},
      };
      _testObj.CountComponents(5, input).Should().Be(2);
   }

   [Theory]
   [InlineData(new int[] {100, 4, 200, 1, 3, 2}, 4)] // 1,2,3,4
   [InlineData(new int[] {0, 3, 7, 2, 5, 8, 4, 6, 0, 1}, 9)]
   public void LongestConsecutive_When_Valid(int[] nums, int expected)
   {
      _testObj.LongestConsecutive(nums).Should().Be(expected);
   }


   [Theory]
   [InlineData("A man, a plan, a canal: Panama", true)]
   [InlineData("race a car", false)]
   [InlineData(" ", true)]
   [InlineData("canac", true)]
   public void IsPalindrome_When_Valid(string input, bool expected)
   {
      _testObj.IsPalindrome(input).Should().Be(expected);
   }

   [Theory]
   [InlineData("babad", "bab")]
   [InlineData("abb", "bb")]
   public void LongestPalindrome_When_Valid(string input, string expected)
   {
      _testObj.LongestPalindrome(input).Should().Be(expected);
   }

   [Fact]
   public void KthSmallest_When_Basic()
   {
      var root = new TreeNode(3);
      var one = new TreeNode(1);
      one.right = new TreeNode(2);
      root.left = one;
      root.right = new TreeNode(4);

      _testObj.KthSmallest(root, 1).Should().Be(1);
   }

   [Fact]
   public void Insert_Intervals()
   {
      int[][] input = {new[] {1, 5}};
      var actual = _testObj.Insert(input, new[] {6, 8});
   }
}