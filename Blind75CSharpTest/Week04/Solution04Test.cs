using Blind75CSharp.Week04;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.Week04;

public class Solution04Test
{
   private readonly Solution04 _testObj = new Solution04();

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