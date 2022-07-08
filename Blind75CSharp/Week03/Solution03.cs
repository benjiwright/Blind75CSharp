namespace Blind75CSharp.Week03;

public class Solution03
{
   public bool CanPartition(int[] nums)
   {
      if (nums.Length == 0) return true;
      var target = nums.Sum();
      if (target % 2 == 1) return false;
      target /= 2;

      var set = new HashSet<int> {0};

      for (var i = 0; i < nums.Length; i++)
      {
         var tmpSet = new HashSet<int>(set);

         foreach (var num in set)
         {
            var newNum = nums[i] + num;
            if (newNum == target) return true;
            tmpSet.Add(newNum);
         }

         set = new HashSet<int>(tmpSet);
      }

      return false;
   }
   // Runtime: 203 ms, faster than 43.33% of C# online submissions for Partition Equal Subset Sum.
   // Memory Usage: 43.3 MB, less than 44.10% of C# online submissions for Partition Equal Subset Sum.


   public int[] TopKFrequentUsingLinq(int[] nums, int k)
   {
      var freq = new Dictionary<int, int>();
      // O(n)
      foreach (var num in nums)
      {
         if (!freq.ContainsKey(num))
         {
            freq.Add(num, 0);
         }

         freq[num]++;
      }

      // O(n log n) for sorting
      return freq.OrderByDescending(kp => kp.Value).Take(k).Select(x => x.Key).ToArray();
   }
   // Runtime: 273 ms, faster than 16.55% of C# online submissions for Top K Frequent Elements.
   // Memory Usage: 44.4 MB, less than 89.49% of C# online submissions for Top K Frequent Elements.


   public int[] TopKFrequentUsingHeap(int[] nums, int k)
   {
      // O(n)
      var freq = new Dictionary<int, int>();
      foreach (var num in nums)
      {
         if (!freq.ContainsKey(num))
         {
            freq.Add(num, 0);
         }

         freq[num]++;
      }

      // O(n) - Insert is cheap!
      var maxHeap = new PriorityQueue<int, int>();
      foreach (var kp in freq)
      {
         maxHeap.Enqueue(kp.Key, kp.Value * -1);
      }

      // O(k)
      var result = new int[k];
      for (var i = 0; i < k; i++)
      {
         result[i] = maxHeap.Dequeue();
      }

      return result;
   }
   // Runtime: 209 ms, faster than 57.55% of C# online submissions for Top K Frequent Elements. ** Much better! **
   // Memory Usage: 44.7 MB, less than 57.97% of C# online submissions for Top K Frequent Elements.


   public TreeNode BuildTree(int[] preorder, int[] inorder)
   {
      var root = new TreeNode();
      // TODO: I'm going to come back to this one. If seen in an interview, you are being weeded out.

      return root;
   }

   public int EraseOverlapIntervals(int[][] intervals)
   {
      if (intervals.Length < 1) return 0;

      // assume not sorted? That was correct
      var sorted = intervals.OrderBy(x => x[0]).ToList();
      var ends = sorted[0][1];
      var result = 0;

      for (var i = 1; i < intervals.GetLength(0); i++)
      {
         var interval = sorted[i];

         if (ends > interval[0])
         {
            // throw out bigger interval
            ends = Math.Min(ends, interval[1]);
            result++;
         }
         else
         {
            ends = interval[1];
         }
      }

      return result;
   }
   // Runtime: 655 ms, faster than 30.38% of C# online submissions for Non-overlapping Intervals.
   // Memory Usage: 64.9 MB, less than 26.79% of C# online submissions for Non-overlapping Intervals.

   public bool IsValidBST(TreeNode root)
   {
      return IsValidSubTree(root, long.MinValue, long.MaxValue);
   }

   private bool IsValidSubTree(TreeNode? node, long min, long max)
   {
      if (node is null) return true;

      if (node.val >= max || node.val <= min) return false;

      return IsValidSubTree(node.left, min, node.val) && IsValidSubTree(node.right, node.val, max);
   }
   // Runtime: 151 ms, faster than 38.90% of C# online submissions for Validate Binary Search Tree.
   // Memory Usage: 40.4 MB, less than 71.49% of C# online submissions for Validate Binary Search Tree.

   public bool ValidTree(int n, int[][] edges)
   {
      if (n == 0) return true;

      // build and adjacency list
      var adjacencyList = new Dictionary<int, IList<int>>();
      for (var i = 0; i < n; i++)
      {
         adjacencyList.Add(i, new List<int>());
      }

      foreach (var edge in edges)
      {
         adjacencyList[edge[0]].Add(edge[1]);
         adjacencyList[edge[1]].Add(edge[0]);
      }

      var visited = new HashSet<int>();

      return DfsValidTree(0, adjacencyList, visited, -1) && visited.Count == n;
   }
   // Runtime: 181 ms, faster than 23.06% of C# online submissions for Graph Valid Tree.
   // Memory Usage: 43.4 MB, less than 23.49% of C# online submissions for Graph Valid Tree.

   private bool DfsValidTree(int node, Dictionary<int, IList<int>> adjacencyList, HashSet<int> visited, int previous)
   {
      // cycle 
      if (visited.Contains(node)) return false;

      visited.Add(node);

      // visit neighbors
      foreach (var neighbor in adjacencyList[node])
      {
         if (neighbor == previous) continue;

         var result = DfsValidTree(neighbor, adjacencyList, visited, node);
         if (!result) return false;
      }

      return true;
   }

   public TreeNode InvertTreeIterative(TreeNode root)
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

   public TreeNode? InvertTreeRecursive(TreeNode? root)
   {
      if (root == null) return null;
      var right = InvertTreeRecursive(root.right);
      var left = InvertTreeRecursive(root.left);
      root.left = right;
      root.right = left;
      return root;
   }
   // Runtime: 91 ms, faster than 87.25% of C# online submissions for Invert Binary Tree.
   // Memory Usage: 38.3 MB, less than 6.89% of C# online submissions for Invert Binary Tree.
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