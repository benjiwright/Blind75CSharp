using System.Collections.Generic;
using Blind75CSharp.Week03;
using Xunit;

namespace Blind75CSharpTest.Week03;

public class SolutionTest
{
   [Fact]
   public void InvertTree()
   {
      var nodes = new int[] {4, 2, 7, 1, 3, 6, 9};
      var root = BuildTree(nodes);
   }

   private TreeNode BuildTree(int[] nums)
   {
      var root = new TreeNode(nums[0]);
      var queue = new Queue<TreeNode>();
      queue.Enqueue(root);

      var i = 1;
      while (queue.Count > 0)
      {
         var current = queue.Dequeue();

         if (i >= nums.Length) continue;
         var left = new TreeNode(nums[i]);
         current.left = left;
         queue.Enqueue(left);

         if (i + 1 >= nums.Length) continue;
         var right = new TreeNode(nums[i + 1]);
         current.right = right;
         queue.Enqueue(right);
         i += 2;
      }


      return root;
   }
}