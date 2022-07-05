namespace Blind75CSharp.Week04;

public class Solution
{
   public bool IsSubtree(TreeNode root, TreeNode subRoot)
   {
      if (root is null) return false;

      if (AreSame(root, subRoot)) return true;

      return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
   }
   // Runtime: 127 ms, faster than 80.42% of C# online submissions for Subtree of Another Tree.
   // Memory Usage: 45.7 MB, less than 11.38% of C# online submissions for Subtree of Another Tree.

   private bool AreSame(TreeNode root, TreeNode subRoot)
   {
      if (root is null && subRoot is null) return true;
      if (root is null || subRoot is null) return false;

      if (root.val != subRoot.val) return false;

      return AreSame(root.left, subRoot.left) && AreSame(root.right, subRoot.right);
   }
}


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