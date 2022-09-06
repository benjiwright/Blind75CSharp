namespace Blind75CSharp.Week06;

public class TreeMerge
{
   public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
   {
      if (root1 is null && root2 is null) return null;

      var left = root1?.val ?? 0;
      var right = root2?.val ?? 0;

      var combined = new TreeNode(left + right);
      combined.left = MergeTrees(root1?.left, root2?.left);
      combined.right = MergeTrees(root1?.right, root2?.right);

      return combined;
   }
}
// Runtime: 209 ms, faster than 7.42% of C# online submissions for Merge Two Binary Trees.
// Memory Usage: 40.1 MB, less than 16.86% of C# online submissions for Merge Two Binary Trees.

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