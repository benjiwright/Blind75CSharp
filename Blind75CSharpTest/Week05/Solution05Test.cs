using System.Linq;
using Blind75CSharp.Week05;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.Week05;

public class Solution05Test
{
   private readonly Solution05 _testObj = new();

   [Theory]
   [InlineData(new[] {"5", "2", "C", "D", "+"}, 30)]
   [InlineData(new[] {"5","-2","4","C","D","9","+","+"}, 27)]
   public void CalPoints_When_BaseballGameIsWeird(string [] inputs, int expected)
   {
      _testObj.CalPoints(inputs).Should().Be(expected);
   }
   
   [Theory]
   [InlineData("aab", "aba")]
   [InlineData("aaab", "")]
   [InlineData("bbbbbbaab", "")]
   [InlineData("bbbbbxbwhbbbbmsybtbbbbbkncyybnjbhxbbrxibcjybb", "bybybybybxbxbxbcbcbhbhbjbjbnbnbibkbmbrbsbtbwb")]
   public void ReorganizeString_When_Valid(string input, string expected)
   {
      _testObj.ReorganizeString(input).ToArray().Should().BeEquivalentTo(expected.ToArray());
   }


   [Fact]
   public void LengthOfLIS_DoThatDp()
   {
      var input = new[] {10, 9, 2, 5, 3, 7, 101, 18}; // 2,3,7,101
      _testObj.LengthOfLIS(input).Should().Be(4);
   }


   #region "Climbing Stair Journey

   // [1] write recursive reoccurrence relation with memoization
   [Theory]
   [InlineData(2, 2)]
   [InlineData(3, 3)]
   [InlineData(4, 5)]
   [InlineData(30, 1_346_269)]
   public void ClimbStairsRecursive_When_Valid(int stairs, int expected)
   {
      _testObj.ClimbStairsRecursive(stairs).Should().Be(expected);
   }

   // [2] write tabulation DP  
   [Theory]
   [InlineData(2, 2)]
   [InlineData(3, 3)]
   [InlineData(4, 5)]
   [InlineData(30, 1_346_269)]
   public void ClimbStairsTabulation_When_Valid(int stairs, int expected)
   {
      _testObj.ClimbStairsTabulation(stairs).Should().Be(expected);
   }

   // [3] write DP only using minimum amount of memory
   [Theory]
   [InlineData(2, 2)]
   [InlineData(3, 3)]
   [InlineData(4, 5)]
   [InlineData(30, 1_346_269)]
   public void ClimbStairsDpMinimumMemory_When_Valid(int stairs, int expected)
   {
      _testObj.ClimbStairsDpMinimumMemory(stairs).Should().Be(expected);
   }

   #endregion
}