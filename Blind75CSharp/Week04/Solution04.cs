using System.Text;

namespace Blind75CSharp.Week04;

public class Solution04
{
   public int CountComponents(int n, int[][] edges)
   {
      if (n < 2) return n;

      // build adj list
      var adjList = new Dictionary<int, List<int>>();
      for (var i = 0; i < n; i++)
      {
         adjList.Add(i, new List<int>());
      }

      foreach (var edge in edges)
      {
         adjList[edge[0]].Add(edge[1]);
         adjList[edge[1]].Add(edge[0]);
      }

      // traverse
      var visited = new HashSet<int>();
      var count = 0;
      foreach (var node in adjList.Keys)
      {
         if (!visited.Contains(node))
         {
            count++;
            DfsComponentCounter(adjList, visited, node);
         }
      }

      return count;
   }
   // Runtime: 85 ms, faster than 100.00% of C# online submissions for Number of Connected Components in an Undirected Graph.
   // Memory Usage: 44.3 MB, less than 5.09% of C# online submissions for Number of Connected Components in an Undirected Graph.

   private void DfsComponentCounter(Dictionary<int, List<int>> adjList, HashSet<int> visited, int node)
   {
      if (visited.Contains(node)) return;

      visited.Add(node);
      foreach (var neighbor in adjList[node])
      {
         DfsComponentCounter(adjList, visited, neighbor);
      }
   }


   public int LongestConsecutive(int[] nums)
   {
      // Array.Sort(nums); You wish. O(n log n)
      // use a mix/max heap? O(log n)
      // use tree? O(log n)
      // sets are always good

      var result = 0;
      var set = new HashSet<int>(nums);
      // 0) main loop
      foreach (var num in nums)
      {
         // 1) find the starts of all the sequences O(n)
         var currentLength = 1;
         if (!set.Contains(num - 1))
         {
            // 2 how big is this interval?
            while (set.Contains(num + currentLength))
            {
               currentLength++;
            }

            result = Math.Max(currentLength, result);
         }
      }

      return result;
   }
   // Runtime: 397 ms, faster than 30.60% of C# online submissions for Longest Consecutive Sequence.
   // Memory Usage: 45.9 MB, less than 73.77% of C# online submissions for Longest Consecutive Sequence.


   public int MinMeetingRooms(int[][] intervals)
   {
      if (intervals.Length == 0) return 0;

      var startTimes = intervals.OrderBy(x => x[0]).Select(x => x[0]).ToArray();
      var endTimes = intervals.OrderBy(x => x[1]).Select(x => x[1]).ToArray();

      var currentMeetingsHappening = 0;
      var maxCount = 0;

      var end = 0;
      var start = 0;
      while (start < startTimes.Length)
      {
         if (startTimes[start] < endTimes[end])
         {
            currentMeetingsHappening++;
            start++;
            maxCount = Math.Max(currentMeetingsHappening, maxCount);
         }
         else
         {
            currentMeetingsHappening--;
            end++;
         }
      }

      return maxCount;
   }
   // Runtime: 169 ms, faster than 25.26% of C# online submissions for Meeting Rooms II.
   // Memory Usage: 39.4 MB, less than 65.03% of C# online submissions for Meeting Rooms II.

   public bool CanAttendMeetings(int[][] intervals)
   {
      intervals = intervals.OrderBy(x => x[0]).ToArray();

      for (var i = 0; i < intervals.Length - 1; i++)
      {
         var endCurrent = intervals[i][1];
         var startNext = intervals[i + 1][0];

         if (endCurrent > startNext) return false;
      }

      return true;
   }
   // Runtime: 148 ms, faster than 53.16% of C# online submissions for Meeting Rooms.
   // Memory Usage: 41.8 MB, less than 24.71% of C# online submissions for Meeting Rooms.


   public int[][] Insert(int[][] intervals, int[] newInterval)
   {
      if (intervals.Length == 0) return new List<int[]> {newInterval}.ToArray();

      // dang it, already sorted
      // intervals = intervals.OrderBy(x => x[0]).ToArray();

      var results = new List<int[]>();
      var idx = 0;
      while (idx < intervals.Length && intervals[idx][1] < newInterval[0])
      {
         results.Add(intervals[idx]);
         idx++;
      }

      var start = newInterval[0];
      var end = newInterval[1];
      while (idx < intervals.Length && intervals[idx][0] <= end)
      {
         start = Math.Min(start, intervals[idx][0]);
         end = Math.Max(end, intervals[idx][1]);
         idx++;
      }

      // merge done, add the interval
      results.Add(new[] {start, end});

      // add any remaining intervals that do not require merging
      while (idx < intervals.Length)
      {
         results.Add(intervals[idx++]);
      }

      return results.ToArray();
   }
   // Runtime: 212 ms, faster than 53.74% of C# online submissions for Insert Interval.
   // Memory Usage: 44.4 MB, less than 91.49% of C# online submissions for Insert Interval.


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