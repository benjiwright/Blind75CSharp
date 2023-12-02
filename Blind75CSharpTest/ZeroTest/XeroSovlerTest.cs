using System.Runtime.CompilerServices;
using Blind75CSharp.Xero;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.ZeroTest;

public class XeroSovlerTest
{
   // Input: 
   // Output: 2
   [Fact(Skip = "shit is hard, yo")]
   public void ShortestBridgeTest()
   {
      var testObj = new XeroSolver();

      var map = new[]
      {
         new[] {0, 1, 0},
         new[] {0, 0, 2},
         new[] {0, 0, 1},
         new[] {0, 0, 1}
      };
      testObj.ShortestBridge(map).Should().Be(2);
   }

   [Theory]
   [InlineData(new string[] { "apple", "app" }, "abcdefghijklmnopqrstuvwxyz", false)]
   public void IsAlienSortedTester(string[] words, string order, bool expected)
   {
      var testObj = new XeroSolver();
      testObj.IsAlienSorted(words, order).Should().Be(expected);
   }


   [Theory]
   [InlineData(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5)]
   public void RemoveElementTester(int[] input, int val, int expected)
   {
      var testObj = new XeroSolver();
      testObj.RemoveElement(input, val).Should().Be(expected);
   }

   [Theory]
   [InlineData(new[] { 2, 3, 1, 2, 4, 3 }, 7, 2)]
   [InlineData(new[] { 1, 4, 4 }, 4, 1)]
   [InlineData(new[] { 1, 1, 1, 1, 1, 1, 1, 1 }, 11, 0)]
   public void MinSubArrayLenTester(int[] nums, int target, int expected)
   {
      var testObj = new XeroSolver();
      testObj.MinSubArrayLen(target, nums).Should().Be(expected);
   }

   [Theory]
   [InlineData(new[] { 1, 2, 3, 4 }, new[] { 1, 2, 3, 5 })]
   [InlineData(new[] { 9 }, new[] { 1, 0 })]
   public void PlusOne_Tester(int[] input, int[] expected)
   {
      var sut = new XeroSolver();
      sut.PlusOne(input).Should().BeEquivalentTo(expected);
   }

   [Fact(Skip = "Appears to be broken")]
   public void MinimumTime_Tester()
   {
      var relations = new[]
      {
         new[] {1, 3},
         new[] {2, 3},
      };

      var time = new[] { 3, 2, 5 };
      var courses = 3;

      var sut = new XeroSolver();

      // act
      var actual = sut.MinimumTime(courses, relations, time);

      actual.Should().Be(3);

   }
}