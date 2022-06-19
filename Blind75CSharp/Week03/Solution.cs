namespace Blind75CSharp.Week03;

public class Solution
{
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
         if(neighbor == previous) continue;

         var result = DfsValidTree(neighbor, adjacencyList, visited, node);
         if (!result) return false;
      }

      return true;
   }


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