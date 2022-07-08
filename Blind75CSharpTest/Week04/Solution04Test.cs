using Blind75CSharp.Week04;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.Week04;

public class Solution04Test
{
   private readonly Solution _testObj = new Solution();

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
}