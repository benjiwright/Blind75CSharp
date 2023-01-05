using Blind75CSharp.Xero;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.ZeroTest;

public class XeroSovlerTest
{
   // Input: 
   // Output: 2
   [Fact]
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
   [InlineData(new int[] {2, 1, 2}, 5)]
   public void FindDistanceToOrigin(int[] input, int expected)
   {
      var testObj = new XeroSolver();
   }


   [Theory]
   [InlineData(new string[] {"apple", "app"}, "abcdefghijklmnopqrstuvwxyz", false)]
   public void IsAlienSortedTester(string[] words, string order, bool expected)
   {
      var testObj = new XeroSolver();
      testObj.IsAlienSorted(words, order).Should().Be(expected);
   }


   [Theory]
   [InlineData(new int[] {0, 1, 2, 2, 3, 0, 4, 2}, 2, 5)]
   public void RemoveElementTester(int[] input, int val, int expected)
   {
      var testObj = new XeroSolver();
      testObj.RemoveElement(input, val).Should().Be(expected);
   }

   [Theory]
   [InlineData(new[] {2, 3, 1, 2, 4, 3}, 7, 2)]
   [InlineData(new[] {1, 4, 4}, 4, 1)]
   [InlineData(new[] {1, 1, 1, 1, 1, 1, 1, 1}, 11, 0)]
   public void MinSubArrayLenTester(int[] nums, int target, int expected)
   {
      var testObj = new XeroSolver();
      testObj.MinSubArrayLen(target, nums).Should().Be(expected);
   }
}