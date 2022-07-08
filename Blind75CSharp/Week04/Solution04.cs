using System.Text;

namespace Blind75CSharp.Week04;

public class Solution
{
   public int[][] Insert(int[][] intervals, int[] newInterval)
   {
      // n (log n) to sort
      var sorted = intervals.OrderBy(x => x[0]).ToArray();
      
      return null;
   }


   // Constraint: TreeNode is a BST
   public int KthSmallest(TreeNode root, int k)
   {
      // BST implies "inOrder" traversal
      var results = new List<int>();
      InOrderTraversal(root, results);
      return results[k - 1];
   }
   // Runtime: 118 ms, faster than 71.84% of C# online submissions for Kth Smallest Element in a BST.
   // Memory Usage: 40.8 MB, less than 51.72% of C# online submissions for Kth Smallest Element in a BST.

   private void InOrderTraversal(TreeNode? node, ICollection<int> results)
   {
      if (node is null) return;

      InOrderTraversal(node.left, results);
      results.Add(node.val);
      InOrderTraversal(node.right, results);
   }


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

   public string LongestPalindrome(string s)
   {
      if (string.IsNullOrEmpty(s)) return "";

      var result = s[0].ToString();

      // O(n)
      for (var i = 0; i < s.Length; i++)
      {
         var left = i;
         var right = i;

         // O(n/2) aka O(n)
         // odds
         while (left >= 0 && right < s.Length && s[left] == s[right])
         {
            if (right - left + 1 > result.Length)
            {
               result = s.Substring(left, right - left + 1);
            }

            left--;
            right++;
         }

         // even
         left = i;
         right = i + 1;
         while (left >= 0 && right < s.Length && s[left] == s[right])
         {
            if (right - left + 1 > result.Length)
            {
               result = s.Substring(left, right - left + 1);
            }

            left--;
            right++;
         }
      }

      return result;
   }
   // Runtime: 144 ms, faster than 60.40% of C# online submissions for Longest Palindromic Substring.
   // Memory Usage: 37.7 MB, less than 51.08% of C# online submissions for Longest Palindromic Substring.
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