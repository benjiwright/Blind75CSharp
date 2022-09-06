using Blind75CSharp.Week06;
using Xunit;

namespace Blind75CSharpTest.Week06;

public class TreeMergeTest
{

   [Fact]
   public void MergeTrees()
   {
      var one = new TreeNode(1);
      one.left = new TreeNode(3);
      one.right = new TreeNode(2);
      one.left.left = new TreeNode(5);

      var two = new TreeNode(2);
      two.left = new TreeNode(1);
      two.right = new TreeNode(3);
      two.left.right = new TreeNode(4);
      two.right.right = new TreeNode(7);


      var testObj = new TreeMerge();
      testObj.MergeTrees(one, two);




   }

}