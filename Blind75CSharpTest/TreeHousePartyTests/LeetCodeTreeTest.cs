using Blind75CSharp.TreeHouseParty;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.TreeHousePartyTests;

public class LeetCodeTreeTest
{
   [Fact]
   public void LetsBuild()
   {
      
      //                10 
      //          5            15
      //       3     7       n   18  
      //      1 n   6  n
      //
      //                        L   R  L  R   L   R
      var arr = new int?[] {10, 5, 15, 3, 7, null, 18, 1, null, 6};
      var actualRoot = LeetCodeTree.Build(arr);

      
      // height 2
      var right = actualRoot.right;
      var left = actualRoot.left;
      left.val.Should().Be(5);
      right.val.Should().Be(15);

      // height 3
      left.left.val.Should().Be(3);
      left.right.val.Should().Be(7);

      right.left.Should().BeNull();
      right.right.val.Should().Be(18);
      
      // height 4
      actualRoot.left.left.left.val.Should().Be(1);
      actualRoot.left.left.right.Should().BeNull();
      
      actualRoot.left.right.left.val.Should().Be(6);
      actualRoot.left.right.right.Should().BeNull();


   }
}