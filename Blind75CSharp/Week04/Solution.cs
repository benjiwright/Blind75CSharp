using System.Text;

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


   public bool IsPalindrome(string s)
   {
      var sb = new StringBuilder();

      foreach (var letter in s)
      {
         if (Char.IsLetterOrDigit(letter))
         {
            sb.Append(letter.ToString().ToLower());
         }
      }

      var left = sb.Length / 2;
      var right = sb.Length / 2;

      if (sb.Length % 2 == 0) // even
      {
         left -= 1;
      }

      for (; right < sb.Length; right++)
      {
         if (sb[right] != sb[left]) return false;
         left--;
      }

      return true;
   }
   // Runtime: 118 ms, faster than 50.29% of C# online submissions for Valid Palindrome.
   // Memory Usage: 39.4 MB, less than 49.64% of C# online submissions for Valid Palindrome.
   
   
   
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