﻿using System.Linq;
using Blind75CSharp.Week02;
using Blind75CSharp.Week05;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.Week05;

public class Solution05Test
{
   private readonly Solution05 _testObj = new();

   [Fact]
   public void MergeKLists_When_Valid()
   {
      var input = new ListNode[]
      {
         new(1)
         {
            next = new ListNode(4)
            {
               next = new ListNode(5)
            }
         },
         new(1)
         {
            next = new ListNode(3)
            {
               next = new ListNode(4)
            }
         },
         new(2)
         {
            next = new ListNode(6)
         },
      };

      _testObj.MergeKLists(input).Should().NotBeNull();
   }
   
   [Fact]
   public void MergeKLists_When_OutOfMemoryError()
   {
      var input = new ListNode[]
      {
         new(1)
         {
            next = new ListNode(2)
            {
               next = new ListNode(2)
            }
         },
         new(1)
         {
            next = new ListNode(1)
            {
               next = new ListNode(2)
            }
         },
      };

      _testObj.MergeKLists(input).Should().NotBeNull();
   }


   [Theory]
   [InlineData(new int[] {1, 3, 4, 5}, 7, 2)]
   [InlineData(new int[] {2}, 3, -1)]
   [InlineData(new int[] {1, 2, 3}, 0, 0)]
   public void CoinChange_DpJourney(int[] coins, int target, int expected)
   {
      _testObj.CoinChangeRecursive(coins, target).Should().Be(expected);
      _testObj.CoinChangeDp(coins, target).Should().Be(expected);
   }


   [Theory]
   [InlineData(new[] {"5", "2", "C", "D", "+"}, 30)]
   [InlineData(new[] {"5", "-2", "4", "C", "D", "9", "+", "+"}, 27)]
   public void CalPoints_When_BaseballGameIsWeird(string[] inputs, int expected)
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