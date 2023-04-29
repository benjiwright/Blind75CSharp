namespace Blind75CSharp.TreeHouseParty;

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

   public TreeNode(int? val, TreeNode left = null, TreeNode right = null)
   {
      this.val = val ?? 0;
      this.left = left;
      this.right = right;
   }
}