namespace Blind75CSharp.Week03;

public class Solution
{
   public TreeNode InvertTree(TreeNode root)
   {
      if (root is null) return new TreeNode();

      var stack = new Stack<TreeNode>();
      stack.Push(root);

      while (stack.Count > 0)
      {
         var current = stack.Pop();
         (current.left, current.right) = (current.right, current.left); // swapperoo with destruction

         if (current.left is not null)
         {
            stack.Push(current.left);
         }

         if (current.right is not null)
         {
            stack.Push(current.right);
         }
      }

      return root;
   }
   // Runtime: 126 ms, faster than 37.22% of C# online submissions for Invert Binary Tree.
   // Memory Usage: 36.9 MB, less than 53.89% of C# online submissions for Invert Binary Tree.
}

#region "Helper Classes"

public class TreeNode
{
   public int val;
   public TreeNode left;
   public TreeNode right;

   public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
   {
      this.val = val;
      this.left = left;
      this.right = right;
   }
}

#endregion